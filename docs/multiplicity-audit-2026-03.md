# Multiplicity Audit — March 2026

**Date:** 2026-03-13
**Method:** 28 randomly sampled C# component records compared against the ISO 20022 MCP server
(snapshot 2025-04-24).
**Status:** Documented; C# model fixes deferred (breaking API change — widespread impact).

## Summary

Two systemic defects were found in the original code generator:

1. **0..∞ fields collapsed to single nullable (`T?`)** — 18 fields across 8 components should be
   `ValueList<T>` collections but are modelled as single nullable properties.

2. **1..∞ collections lack minimum enforcement** — 3 fields use `ValueList<T> = []`, which allows
   an empty list. The spec requires at least one element. These are flagged at the validator layer
   (see `FluentValidation` project) pending a model fix.

---

## Defect 1 — 0..∞ collapsed to `T?`

The fix is to change each affected property from `T? Prop { get; init; }` to
`ValueList<T> Prop { get; init; } = [];` (or equivalent `IReadOnlyList<T>`).
This is a **breaking change** to the public API surface.

| Component | Field | Spec Max | C# Type (wrong) | Correct C# type |
|-----------|-------|----------|-----------------|-----------------|
| `AdditionalInformation30` | `Target` | ∞ | `UserInterface8Code?` | `ValueList<UserInterface8Code>` |
| `ApplicationParameters7` | `Parameters` | ∞ | `IsoMax100KBinary?` | `ValueList<IsoMax100KBinary>` |
| `CardPaymentBatchTransferResponse3` | `TransactionTotals` | ∞ | `TransactionTotals3?` | `ValueList<TransactionTotals3>` |
| `CardPaymentBatchTransferResponse3` | `DataSet` | ∞ | `CardPaymentDataSet12?` | `ValueList<CardPaymentDataSet12>` |
| `CardTransactionAmount1` | `DetailedAmount` | ∞ | `DetailedAmount9?` | `ValueList<DetailedAmount9>` |
| `CurrencyConversion9` | `CommissionDetails` | ∞ | `Commission19?` | `ValueList<Commission19>` |
| `CurrencyConversion9` | `MarkUpDetails` | ∞ | `Commission18?` | `ValueList<Commission18>` |
| `PEPISATransfer11` | `OtherIndividualInvestor` | ∞ | `IndividualPerson8?` | `ValueList<IndividualPerson8>` |
| `PEPISATransfer11` | `OtherCorporateInvestor` | ∞ | `Organisation4?` | `ValueList<Organisation4>` |
| `PEPISATransfer11` | `Extension` | ∞ | `Extension1?` | `ValueList<Extension1>` |
| `PassengerTransportSummary2` | `CustomerReference` | ∞ | `CustomerReference1?` | `ValueList<CustomerReference1>` |
| `PassengerTransportSummary2` | `Passenger` | ∞ | `Customer8?` | `ValueList<Customer8>` |
| `PassengerTransportSummary2` | `TotalAmount` | ∞ | `AmountDetails2?` | `ValueList<AmountDetails2>` |
| `RequestDetails19` | `AdditionalRequestInformation` | ∞ | `IsoMax35Text?` | `ValueList<IsoMax35Text>` |
| `SettlementDetails171` | `SettlementTransactionCondition` | ∞ | `SettlementTransactionCondition16Choice_?` | `ValueList<SettlementTransactionCondition16Choice_>` |
| `TradeTypeQueryCriteria1` | `SecuritiesFinancingTransactionType` | ∞ | `ExposureType6Code?` | `ValueList<ExposureType6Code>` |
| `TradeTypeQueryCriteria1` | `CollateralComponentType` | ∞ | `CollateralType6Code?` | `ValueList<CollateralType6Code>` |
| `VolumeCapResult1` | `TradingUnderWaiverBreakdown` | ∞ | `TradingUnderWaiversPercentage1?` | `ValueList<TradingUnderWaiversPercentage1>` |

### Notes

- The same generator defect is almost certainly present in many of the other ~12,600 component
  records not yet audited. This sample of 28 produced 18 affected fields — a high hit rate.
- Before fixing, do a full grep for patterns like `public T? Prop` where T is a component type,
  to assess total scope.
- A future audit pass using `show_item_details` for each affected type will be needed to produce
  a complete fix list.

---

## Defect 2 — 1..∞ min not enforced

These components have collections that the spec mandates must contain at least one element, but the
C# model initialises them to empty (`= []`), silently allowing zero elements.

**Mitigation applied:** The FluentValidation validators for these components enforce
`.NotEmpty()` on the collection so that messages with zero elements are rejected at runtime.

| Component | Field | Spec | C# (model) | Validator mitigation |
|-----------|-------|------|------------|----------------------|
| `DistributionRejectionStatus1` | `Reason` | 1..∞ | `ValueList<...> = []` | `DistributionRejectionStatus1Validator` |
| `PEPISATransfer11` | `ProductTransfer` | 1..∞ | `ValueList<...> = []` | `PEPISATransfer11Validator` |
| `RedemptionMultipleOrder2` | `IndividualOrderDetails` | 1..∞ | `ValueList<...> = []` | `RedemptionMultipleOrder2Validator` |

---

## How the audit was run

1. 28 component names were randomly sampled from the 12,653 files in `Components/`.
2. Each was queried via `mcp__iso20022-local__show_item_details`.
3. The returned `Min`/`Max` for each element was compared to the C# property declaration
   (`required` = Min 1, `?` = Min 0, `ValueList<T>` = Max ∞).
4. `IsabelEpaymentTokenResponse1` and `SecuritiesOptionSD1` were not found in the 2025-04-24
   snapshot and were excluded.
