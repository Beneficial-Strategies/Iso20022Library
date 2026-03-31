// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security or other asset.
/// </summary>
[IsoId("_lvXP3ZNBEemQB_8XA98K0Q")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument83
{
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("_mC_9f5NBEemQB_8XA98K0Q")]
    [DisplayName("Line Identification")]
    [IsoXmlTag("LineId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LineIdentification { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("_mC_9gZNBEemQB_8XA98K0Q")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrument63Choice_ Instrument { get; init; }

    /// <summary>
    /// Quantity of asset transferred or to be transferred.
    /// </summary>
    [IsoId("_mC_9g5NBEemQB_8XA98K0Q")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity47? Quantity { get; init; }

    /// <summary>
    /// Indicates that the quantity of asset to be transferred is a partially instructed quantity.
    /// </summary>
    [IsoId("_x-gfYZQAEemyZbjY08A1Vw")]
    [DisplayName("Partial Instructed Quantity")]
    [IsoXmlTag("PrtlInstdQty")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialInstructedQuantity { get; init; }

    /// <summary>
    /// Percentage rate of assets to be transferred or transferred, as originally instructed.
    /// </summary>
    [IsoId("_08aOQN7bEem3a9o3PV2p1g")]
    [DisplayName("Original Percentage Instructed")]
    [IsoXmlTag("OrgnlPctgInstd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? OriginalPercentageInstructed { get; init; }

    /// <summary>
    /// Specifies how the financial instrument is transferred.
    /// </summary>
    [IsoId("_mC_9hZNBEemQB_8XA98K0Q")]
    [DisplayName("Transfer Type")]
    [IsoXmlTag("TrfTp")]
    public required TransferType2Choice_ TransferType { get; init; }

    /// <summary>
    /// Indicates the asset is a new asset, not previously identified by the transferor party (ceding party) in the account holding discovery process.
    /// </summary>
    [IsoId("_rdmGY5QcEemqYPWMBuVawg")]
    [DisplayName("Additional Asset")]
    [IsoXmlTag("AddtlAsst")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AdditionalAsset { get; init; }

    /// <summary>
    /// Indicates the asset is no longer available at the transferor party (ceding party).
    /// </summary>
    [IsoId("_rdmGYpQcEemqYPWMBuVawg")]
    [DisplayName("Not Available")]
    [IsoXmlTag("NotAvlbl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NotAvailable { get; init; }

    /// <summary>
    /// Security is to be converted into another security before transfer.
    /// </summary>
    [IsoId("_mC_9h5NBEemQB_8XA98K0Q")]
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public Conversion1? Conversion { get; init; }

    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [IsoId("_mC_9iZNBEemQB_8XA98K0Q")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit11> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_mC_9i5NBEemQB_8XA98K0Q")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_mC_9jZNBEemQB_8XA98K0Q")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Business process in which the actors are involved. This will facilitate the right business process to be triggered, according to the market business model, which may require matching instructions (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_mC_9j5NBEemQB_8XA98K0Q")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("_mC_9kZNBEemQB_8XA98K0Q")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("_mC_9k5NBEemQB_8XA98K0Q")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_mC_9lZNBEemQB_8XA98K0Q")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public DateAndAmount2? TotalBookValue { get; init; }

    /// <summary>
    /// Original amount paid for the asset at the point of purchase. May also be known as the book cost.
    /// </summary>
    [IsoId("_mC_9l5NBEemQB_8XA98K0Q")]
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; }

    /// <summary>
    /// Date and market value of the asset.
    /// </summary>
    [IsoId("_mC_9mZNBEemQB_8XA98K0Q")]
    [DisplayName("Latest Valuation")]
    [IsoXmlTag("LatstValtn")]
    public DateAndAmount2? LatestValuation { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// (Party and account into which the transferee receives the financial instrument from the transferor.)
    /// </summary>
    [IsoId("_mC_9m5NBEemQB_8XA98K0Q")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account28? TransfereeAccount { get; init; }

    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    [IsoId("_mC_9nZNBEemQB_8XA98K0Q")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public Account28? Transferor { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_H9j-0aIyEem3ELMJcnCmxA")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Date to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_mC_9n5NBEemQB_8XA98K0Q")]
    [DisplayName("Requested Trade Date")]
    [IsoXmlTag("ReqdTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedTradeDate { get; init; }

    /// <summary>
    /// Date on which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_mC_9oZNBEemQB_8XA98K0Q")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("_mC_9o5NBEemQB_8XA98K0Q")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public DateAndDateTime2Choice_? EffectiveTransferDate { get; init; }

    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_mC_9pZNBEemQB_8XA98K0Q")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_mC_9p5NBEemQB_8XA98K0Q")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument14? PaymentDetails { get; init; }

    /// <summary>
    /// Number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund. This is typically relevant to a pension fund.
    /// </summary>
    [IsoId("_mC_9qZNBEemQB_8XA98K0Q")]
    [DisplayName("Crystallisation Details")]
    [IsoXmlTag("CrstllstnDtls")]
    public ValueList<Crystallisation2> CrystallisationDetails { get; init; } = [];

    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [IsoId("_mC_9q5NBEemQB_8XA98K0Q")]
    [DisplayName("Tax Valuation Point")]
    [IsoXmlTag("TaxValtnPt")]
    public Tax36? TaxValuationPoint { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_mC_9rZNBEemQB_8XA98K0Q")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters17? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("_mC_9r5NBEemQB_8XA98K0Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
