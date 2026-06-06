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
    /// <summary>
    /// Unique and unambiguous identifier for the transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("fab83d91-8b7b-4dcf-bebe-d785e49bf902")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("74def2c9-1923-4900-91d6-6f1c0bd51baa")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("bb1387fd-f168-49d8-9701-837cdb220afb")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("b64c95a9-1567-478d-b8f9-2a2f86794177")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    [IsoId("0f7c63b7-a996-425e-849f-8d63fe28f0ea")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    public DateFormat1Choice_? RequestedTransferDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("f97bd3c4-dea7-4187-87e9-c2cb0f1ace73")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Date on which the investor signed the transfer order form.
    /// </summary>
    [IsoId("f2b158ff-c9fa-4fb4-8c0b-35ca06f28b0e")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    public IsoISODate? TransferOrderDateForm { get; init; }

    /// <summary>
    /// Reason for the transfer.
    /// </summary>
    [IsoId("4ae5775f-329b-4cd6-82c5-8ed3f0830170")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1Choice_? TransferReason { get; init; }

    /// <summary>
    /// Specifies information about investment plans included in the holding.
    /// </summary>
    [IsoId("ac5e600e-6c8e-4303-be6f-11e2e76ace9d")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];

    /// <summary>
    /// Information related to the financial instrument to be transferred.
    /// </summary>
    [IsoId("fb66905c-de5f-4ce3-9138-139d06a085b6")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument116 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Total quantity of securities to be transferred, expressed as a number of units or a percentage rate.
    /// </summary>
    [IsoId("f71fabd4-2b36-4974-8e45-0bce9bbe09a3")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity82Choice_ Quantity { get; init; }

    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    [IsoId("a502ea91-e1f2-4bbb-a98e-8a8d33fe4d7a")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit14> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("619056bb-09dd-41b1-873a-3d220fc1747e")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Original amount paid for the asset at the point of purchase. May also be known as the book cost.
    /// </summary>
    [IsoId("d667477c-1811-436a-bb44-e147b6b97a58")]
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; }

    /// <summary>
    /// Value of the security, as booked in the account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("ba68838f-7e81-4095-a772-141340cb0cb2")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("f4c8c488-6c9f-4b5f-8b93-980f9fc0b0f6")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("b089fc1a-fae3-4bac-a14f-25192190985a")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; }

    /// <summary>
    /// Additional specific settlement information for the fund.
    /// </summary>
    [IsoId("e3e940f4-b858-49c2-abbc-c10fbaaa6261")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Specifies how the payment of fees and taxes as a result of the transfer is covered, that is, whether by cash or the redemption of units.
    /// </summary>
    [IsoId("e839c5a0-a7ef-432f-b018-5d46917bfc0c")]
    [DisplayName("Transfer Expenses Payment Type")]
    [IsoXmlTag("TrfExpnssPmtTp")]
    public ChargePaymentMethod1Choice_? TransferExpensesPaymentType { get; init; }
}
