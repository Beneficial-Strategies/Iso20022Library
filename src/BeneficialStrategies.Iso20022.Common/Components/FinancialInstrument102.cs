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
[IsoId("_psqnQelwEeuJptoA6B9tfA")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument102
{
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("_qTQtP-lwEeuJptoA6B9tfA")]
    [DisplayName("Line Identification")]
    [IsoXmlTag("LineId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LineIdentification { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("_qTQtQelwEeuJptoA6B9tfA")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrument63Choice_ Instrument { get; init; }

    /// <summary>
    /// Quantity of asset to be transferred.
    /// </summary>
    [IsoId("_qTQtQ-lwEeuJptoA6B9tfA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity47? Quantity { get; init; }

    /// <summary>
    /// Indicates that the quantity of asset to be transferred is a partially instructed quantity.
    /// </summary>
    [IsoId("_qTQtRelwEeuJptoA6B9tfA")]
    [DisplayName("Partial Instructed Quantity")]
    [IsoXmlTag("PrtlInstdQty")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialInstructedQuantity { get; init; }

    /// <summary>
    /// Specifies how the financial instrument is transferred.
    /// </summary>
    [IsoId("_qTQtR-lwEeuJptoA6B9tfA")]
    [DisplayName("Transfer Type")]
    [IsoXmlTag("TrfTp")]
    public required TransferType2Choice_ TransferType { get; init; }

    /// <summary>
    /// Indicates the asset is a new asset, not previously identified by the transferor party (ceding party) in the account holding discovery process.
    /// </summary>
    [IsoId("_qTQtSelwEeuJptoA6B9tfA")]
    [DisplayName("Additional Asset")]
    [IsoXmlTag("AddtlAsst")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AdditionalAsset { get; init; }

    /// <summary>
    /// Indicates the asset is no longer available at the transferor party (ceding party).
    /// </summary>
    [IsoId("_qTQtS-lwEeuJptoA6B9tfA")]
    [DisplayName("Not Available")]
    [IsoXmlTag("NotAvlbl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NotAvailable { get; init; }

    /// <summary>
    /// Security is to be converted into another security before transfer.
    /// </summary>
    [IsoId("_qTQtTelwEeuJptoA6B9tfA")]
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public Conversion1? Conversion { get; init; }

    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [IsoId("_qTQtT-lwEeuJptoA6B9tfA")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit11> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_qTQtUelwEeuJptoA6B9tfA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_qTQtU-lwEeuJptoA6B9tfA")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Business process in which the actors are involved. This will facilitate the right business process to be triggered, according to the market business model, which may require matching instructions (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_qTQtVelwEeuJptoA6B9tfA")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("_qTQtV-lwEeuJptoA6B9tfA")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("_qTQtWelwEeuJptoA6B9tfA")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_qTQtW-lwEeuJptoA6B9tfA")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public DateAndAmount2? TotalBookValue { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// (Party and account into which the transferee receives the financial instrument from the transferor.)
    /// </summary>
    [IsoId("_qTQtXelwEeuJptoA6B9tfA")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account28? TransfereeAccount { get; init; }

    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    [IsoId("_qTQtX-lwEeuJptoA6B9tfA")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public Account28? Transferor { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_qTQtYelwEeuJptoA6B9tfA")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    [IsoId("_qTQtY-lwEeuJptoA6B9tfA")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedTransferDate { get; init; }

    /// <summary>
    /// Date to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_qTQtZelwEeuJptoA6B9tfA")]
    [DisplayName("Requested Trade Date")]
    [IsoXmlTag("ReqdTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedTradeDate { get; init; }

    /// <summary>
    /// Date at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_qTQtZ-lwEeuJptoA6B9tfA")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_qTQtaelwEeuJptoA6B9tfA")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument14? PaymentDetails { get; init; }

    /// <summary>
    /// Number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund. This is typically relevant to a pension fund.
    /// </summary>
    [IsoId("_qTQta-lwEeuJptoA6B9tfA")]
    [DisplayName("Crystallisation Details")]
    [IsoXmlTag("CrstllstnDtls")]
    public ValueList<Crystallisation2> CrystallisationDetails { get; init; } = [];

    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [IsoId("_qTQtbelwEeuJptoA6B9tfA")]
    [DisplayName("Tax Valuation Point")]
    [IsoXmlTag("TaxValtnPt")]
    public Tax36? TaxValuationPoint { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_qTQtb-lwEeuJptoA6B9tfA")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters17? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Indicates whether the assets are held in an individual’s own name.
    /// </summary>
    [IsoId("_xaCioOlwEeuJptoA6B9tfA")]
    [DisplayName("Assets Held In Own Name")]
    [IsoXmlTag("AsstsHeldInOwnNm")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AssetsHeldInOwnName { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_0wdr4OlwEeuJptoA6B9tfA")]
    [DisplayName("Transfer Results In Change Of Beneficial Owner")]
    [IsoXmlTag("TrfRsltsInChngOfBnfclOwnr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransferResultsInChangeOfBeneficialOwner { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("_qTQtcelwEeuJptoA6B9tfA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
