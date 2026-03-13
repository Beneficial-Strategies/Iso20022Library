// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="RedemptionMultipleOrder2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _VddsSdp-Ed-ak6NoX_4Aeg_-438010863
/// Spec source: queried via ISO 20022 MCP server (2026-03-13).
/// <list type="table">
///   <item><term>PlaceOfTrade</term><description>CountryCode — optional (0..1)</description></item>
///   <item><term>OrderDateTime</term><description>ISODateTime — optional (0..1)</description></item>
///   <item><term>ExpiryDateTime</term><description>ISODateTime — optional (0..1)</description></item>
///   <item><term>CancellationRight</term><description>CancellationRight1 — optional (0..1)</description></item>
///   <item><term>InvestmentAccountDetails</term><description>InvestmentAccount13 — required (1..1)</description></item>
///   <item><term>BeneficiaryDetails</term><description>IndividualPerson2 — optional (0..1)</description></item>
///   <item><term>IndividualOrderDetails</term><description>RedemptionOrder4 — required (1..∞)</description></item>
///   <item><term>BulkCashSettlementDetails</term><description>PaymentTransaction15 — optional (0..1)</description></item>
/// </list>
///
/// Model defect: <c>IndividualOrderDetails</c> is declared as <c>ValueList&lt;T&gt; = []</c> (allows
/// empty) but the spec requires at least one element (Min=1). This validator enforces the minimum
/// at runtime. See docs/multiplicity-audit-2026-03.md — Defect 2.
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>BulkCashSettlementDetails1Rule</term>
///     <description>
///       Either IndividualOrderDetails/CashSettlementDetails or BulkCashSettlementDetails may be
///       present, but not both. Business-context constraint — cannot be enforced structurally from
///       this component alone (requires inspecting nested IndividualOrderDetails elements).
///     </description>
///   </item>
///   <item>
///     <term>SettlementCurrency5Rule</term>
///     <description>
///       If BulkCashSettlementDetails is present, then Currency in IndividualOrderDetails/NetAmount
///       and GrossAmount must match IndividualOrderDetails/RequestedSettlementCurrency across all
///       occurrences. Business-context constraint — cannot be enforced structurally.
///     </description>
///   </item>
/// </list>
/// </remarks>
public sealed class RedemptionMultipleOrder2Validator : AbstractValidator<RedemptionMultipleOrder2>
{
    public RedemptionMultipleOrder2Validator()
    {
        // IndividualOrderDetails is 1..∞ but the C# model allows empty (model defect — see XML doc).
        RuleFor(x => x.IndividualOrderDetails)
            .NotEmpty()
                .WithMessage("RedemptionMultipleOrder2.IndividualOrderDetails must contain at least one element (1..∞).");

        // BulkCashSettlementDetails1Rule and SettlementCurrency5Rule: business-context only —
        // cannot be enforced structurally. See XML doc on this class for the full constraint text.
    }
}
