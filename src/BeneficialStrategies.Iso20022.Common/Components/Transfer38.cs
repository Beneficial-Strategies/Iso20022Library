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
    /// <summary>
    /// Unique and unambiguous identifier for the transfer execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("6d917cdb-cf8d-49db-8f32-847fe70d913a")]
    [DisplayName("Transfer Confirmation Reference")]
    [IsoXmlTag("TrfConfRef")]
    public required IsoMax35Text TransferConfirmationReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("6bd116c8-39cb-4f7f-861a-7614e6ce9889")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("6bea2059-f117-4ff5-8c2a-caeb277b4f6a")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("7ac80b88-f6b6-4944-8b55-1a6225cd0373")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("015fa518-3365-43ca-913f-1af8d11e4b8a")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("abe9a551-7127-4a82-9dbc-f944f043c599")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("d517ac33-b6d0-40aa-95be-dc795138e9ed")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public required DateAndDateTime2Choice_ EffectiveTransferDate { get; init; }

    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("aa9834e9-cb3c-4712-a00d-91583be8afd6")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the transaction is completed and cleared, that is, securities are delivered.
    /// </summary>
    [IsoId("40fadbae-0193-48b4-ad68-91de921ce621")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public DateAndDateTime2Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date on which the investor signed the transfer order form.
    /// </summary>
    [IsoId("fd6f3b1e-58ed-4682-aeb8-49149d583d4e")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    public IsoISODate? TransferOrderDateForm { get; init; }

    /// <summary>
    /// Reason for the transfer.
    /// </summary>
    [IsoId("ce59dff8-8526-46c2-8335-0eec93e046b8")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1Choice_? TransferReason { get; init; }

    /// <summary>
    /// Specifies information about investment plans included in the holding.
    /// </summary>
    [IsoId("dce7c29a-d110-49b8-826d-c8feb67357c7")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];

    /// <summary>
    /// Information related to the financial instrument transferred.
    /// </summary>
    [IsoId("be0b4e8c-6ad8-4030-a2e5-4970cb59a852")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument116 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Number of units transferred.
    /// </summary>
    [IsoId("64874970-e38f-46b8-bb10-c6660009f9ea")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public required Unit1Choice_ TotalUnitsNumber { get; init; }

    /// <summary>
    /// Quantity of securities transferred as a percentage of the holding.
    /// </summary>
    [IsoId("570ee1b9-d9c7-4b90-87cb-d4b84f2c433e")]
    [DisplayName("Transfer Rate")]
    [IsoXmlTag("TrfRate")]
    public IsoPercentageRate? TransferRate { get; init; }

    /// <summary>
    /// Breakdown of units transferred.
    /// </summary>
    [IsoId("1184b7f2-98f9-458a-bb0a-74fbf4116b53")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit14> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("3026fc36-87dc-457a-b320-f99655ef6e0b")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Original amount paid for the asset at the point of purchase. May also be known as the book cost.
    /// </summary>
    [IsoId("1284474a-cd66-4526-aa82-d2d6bb0fc510")]
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; }

    /// <summary>
    /// Weighted average price of the units in the account before the transfer was executed.
    /// </summary>
    [IsoId("bc226507-862a-4a14-91e1-6d3f01c04cf9")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Weighted average price of the units in the account after the transfer was executed.
    /// </summary>
    [IsoId("e1ff837c-68b2-4248-931a-a0e91ecfaaf6")]
    [DisplayName("New Average Price")]
    [IsoXmlTag("NewAvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? NewAveragePrice { get; init; }

    /// <summary>
    /// Trade date of the average weighted data of units in the account before the transfer was executed.
    /// </summary>
    [IsoId("820fa702-2ae0-4805-b10c-384bfe61b6d7")]
    [DisplayName("Average Date")]
    [IsoXmlTag("AvrgDt")]
    public IsoISODate? AverageDate { get; init; }

    /// <summary>
    /// Trade date of the average weighted data of units in the account after the transfer was executed.
    /// </summary>
    [IsoId("887ecd01-91d2-4c20-811b-ebe8e5f5b098")]
    [DisplayName("New Average Date")]
    [IsoXmlTag("NewAvrgDt")]
    public IsoISODate? NewAverageDate { get; init; }

    /// <summary>
    /// Currency used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("1f219d41-6f10-4b58-987d-e13e7da64c60")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("4809f539-9208-4c6c-bddb-68145e3257f1")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("203bcd1e-7201-40bb-9ad3-c41ad45cc9c2")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Specifies how the payment of fees and taxes as a result of the transfer is covered, that is, whether by cash or the redemption of units.
    /// </summary>
    [IsoId("3891364d-3b2e-4dad-a004-b56162afa146")]
    [DisplayName("Transfer Expenses Payment Type")]
    [IsoXmlTag("TrfExpnssPmtTp")]
    public ChargePaymentMethod1Choice_? TransferExpensesPaymentType { get; init; }
}
