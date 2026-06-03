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
[IsoId("42a74f68-a2ba-499f-ac3b-0aafaed85cb7")]
[DisplayName("Transfer38")]
public record Transfer38
{
    [IsoId("6d917cdb-cf8d-49db-8f32-847fe70d913a")]
    [DisplayName("Transfer Confirmation Reference")]
    [IsoXmlTag("TrfConfRef")]
    public required IsoMax35Text TransferConfirmationReference { get; init; }

    [IsoId("6bd116c8-39cb-4f7f-861a-7614e6ce9889")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    public required IsoMax35Text TransferReference { get; init; }

    [IsoId("6bea2059-f117-4ff5-8c2a-caeb277b4f6a")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    [IsoId("7ac80b88-f6b6-4944-8b55-1a6225cd0373")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    [IsoId("015fa518-3365-43ca-913f-1af8d11e4b8a")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    [IsoId("abe9a551-7127-4a82-9dbc-f944f043c599")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    public IsoISODate? RequestedSettlementDate { get; init; }

    [IsoId("d517ac33-b6d0-40aa-95be-dc795138e9ed")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public required DateAndDateTime2Choice EffectiveTransferDate { get; init; }

    [IsoId("aa9834e9-cb3c-4712-a00d-91583be8afd6")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice? EffectiveSettlementDate { get; init; }

    [IsoId("40fadbae-0193-48b4-ad68-91de921ce621")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public DateAndDateTime2Choice? TradeDate { get; init; }

    [IsoId("fd6f3b1e-58ed-4682-aeb8-49149d583d4e")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    public IsoISODate? TransferOrderDateForm { get; init; }

    [IsoId("ce59dff8-8526-46c2-8335-0eec93e046b8")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1Choice? TransferReason { get; init; }

    [IsoId("dce7c29a-d110-49b8-826d-c8feb67357c7")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];

    [IsoId("be0b4e8c-6ad8-4030-a2e5-4970cb59a852")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument116 FinancialInstrumentDetails { get; init; }

    [IsoId("64874970-e38f-46b8-bb10-c6660009f9ea")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public required Unit1Choice TotalUnitsNumber { get; init; }

    [IsoId("570ee1b9-d9c7-4b90-87cb-d4b84f2c433e")]
    [DisplayName("Transfer Rate")]
    [IsoXmlTag("TrfRate")]
    public IsoPercentageRate? TransferRate { get; init; }

    [IsoId("1184b7f2-98f9-458a-bb0a-74fbf4116b53")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit14> UnitsDetails { get; init; } = [];

    [IsoId("3026fc36-87dc-457a-b320-f99655ef6e0b")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    [IsoId("1284474a-cd66-4526-aa82-d2d6bb0fc510")]
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; }

    [IsoId("bc226507-862a-4a14-91e1-6d3f01c04cf9")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    [IsoId("e1ff837c-68b2-4248-931a-a0e91ecfaaf6")]
    [DisplayName("New Average Price")]
    [IsoXmlTag("NewAvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? NewAveragePrice { get; init; }

    [IsoId("820fa702-2ae0-4805-b10c-384bfe61b6d7")]
    [DisplayName("Average Date")]
    [IsoXmlTag("AvrgDt")]
    public IsoISODate? AverageDate { get; init; }

    [IsoId("887ecd01-91d2-4c20-811b-ebe8e5f5b098")]
    [DisplayName("New Average Date")]
    [IsoXmlTag("NewAvrgDt")]
    public IsoISODate? NewAverageDate { get; init; }

    [IsoId("1f219d41-6f10-4b58-987d-e13e7da64c60")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    [IsoId("4809f539-9208-4c6c-bddb-68145e3257f1")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; }

    [IsoId("203bcd1e-7201-40bb-9ad3-c41ad45cc9c2")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    [IsoId("3891364d-3b2e-4dad-a004-b56162afa146")]
    [DisplayName("Transfer Expenses Payment Type")]
    [IsoXmlTag("TrfExpnssPmtTp")]
    public ChargePaymentMethod1Choice? TransferExpensesPaymentType { get; init; }
}
