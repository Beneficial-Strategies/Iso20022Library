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
[IsoId("_Rfs3ARXxEeOBE-jZfcm4KQ")]
[DisplayName("Transfer")]
public record Transfer27
{
    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SElsxxXxEeOBE-jZfcm4KQ")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_SEvdwRXxEeOBE-jZfcm4KQ")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_SEvdwxXxEeOBE-jZfcm4KQ")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference2? CounterpartyReference { get; init; }

    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_SEvdxRXxEeOBE-jZfcm4KQ")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_SEvdxxXxEeOBE-jZfcm4KQ")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Identifies in which date the investor signed the transfer order form.
    /// </summary>
    [IsoId("_SEvdyRXxEeOBE-jZfcm4KQ")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TransferOrderDateForm { get; init; }

    /// <summary>
    /// Identifies the transfer reason.
    /// </summary>
    [IsoId("_SEvdyxXxEeOBE-jZfcm4KQ")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1? TransferReason { get; init; }

    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    [IsoId("_SEvdzRXxEeOBE-jZfcm4KQ")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];

    /// <summary>
    /// Information related to the financial instrument to be withdrawn.
    /// </summary>
    [IsoId("_SEvdzxXxEeOBE-jZfcm4KQ")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Total quantity of securities to be transferred, expressed in a number of units or a percentage rate.
    /// </summary>
    [IsoId("_SEvd0RXxEeOBE-jZfcm4KQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity13Choice_ Quantity { get; init; }

    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_SEvd0xXxEeOBE-jZfcm4KQ")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit3> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_SEvd1RXxEeOBE-jZfcm4KQ")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_SEvd1xXxEeOBE-jZfcm4KQ")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Identifies the currency to be used to transfer the holdings.
    /// </summary>
    [IsoId("_SEvd2RXxEeOBE-jZfcm4KQ")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public CurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_SEvd2xXxEeOBE-jZfcm4KQ")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_SEvd3RXxEeOBE-jZfcm4KQ")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("_SEvd3xXxEeOBE-jZfcm4KQ")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public PartyIdentificationAndAccount93? ReceivingAgentDetails { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("_SEvd4RXxEeOBE-jZfcm4KQ")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; }

    /// <summary>
    /// Specifies how the payment of charges, taxes and commissions as a result of the transfer is covered, that is, whether by cash or the redemption of units.
    /// </summary>
    [IsoId("_rhYQMBXxEeOBE-jZfcm4KQ")]
    [DisplayName("Transfer Expenses Payment Type")]
    [IsoXmlTag("TrfExpnssPmtTp")]
    public ChargePaymentMethod1Choice_? TransferExpensesPaymentType { get; init; }
}
