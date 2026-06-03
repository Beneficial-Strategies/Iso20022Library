// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("ae3b3cf3-0f34-4065-8ea5-43cf4649949b")]
[DisplayName("Transfer39")]
public record Transfer39
{
    [IsoId("fab83d91-8b7b-4dcf-bebe-d785e49bf902")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    public required IsoMax35Text TransferReference { get; init; }

    [IsoId("74def2c9-1923-4900-91d6-6f1c0bd51baa")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    [IsoId("bb1387fd-f168-49d8-9701-837cdb220afb")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    [IsoId("b64c95a9-1567-478d-b8f9-2a2f86794177")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    [IsoId("0f7c63b7-a996-425e-849f-8d63fe28f0ea")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    public DateFormat1Choice? RequestedTransferDate { get; init; }

    [IsoId("f97bd3c4-dea7-4187-87e9-c2cb0f1ace73")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    public IsoISODate? RequestedSettlementDate { get; init; }

    [IsoId("f2b158ff-c9fa-4fb4-8c0b-35ca06f28b0e")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    public IsoISODate? TransferOrderDateForm { get; init; }

    [IsoId("4ae5775f-329b-4cd6-82c5-8ed3f0830170")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1Choice? TransferReason { get; init; }

    [IsoId("ac5e600e-6c8e-4303-be6f-11e2e76ace9d")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];

    [IsoId("fb66905c-de5f-4ce3-9138-139d06a085b6")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument116 FinancialInstrumentDetails { get; init; }

    [IsoId("f71fabd4-2b36-4974-8e45-0bce9bbe09a3")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity82Choice Quantity { get; init; }

    [IsoId("a502ea91-e1f2-4bbb-a98e-8a8d33fe4d7a")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit14> UnitsDetails { get; init; } = [];

    [IsoId("619056bb-09dd-41b1-873a-3d220fc1747e")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    [IsoId("d667477c-1811-436a-bb44-e147b6b97a58")]
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; }

    [IsoId("ba68838f-7e81-4095-a772-141340cb0cb2")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    [IsoId("f4c8c488-6c9f-4b5f-8b93-980f9fc0b0f6")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    [IsoId("b089fc1a-fae3-4bac-a14f-25192190985a")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; }

    [IsoId("e3e940f4-b858-49c2-abbc-c10fbaaa6261")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    [IsoId("e839c5a0-a7ef-432f-b018-5d46917bfc0c")]
    [DisplayName("Transfer Expenses Payment Type")]
    [IsoXmlTag("TrfExpnssPmtTp")]
    public ChargePaymentMethod1Choice? TransferExpensesPaymentType { get; init; }
}
