// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial Instrument105.
/// </summary>
[IsoId("_BeLSMX_5Ee-5A_neRtHpSQ")]
[DisplayName("Financial Instrument105")]
public record FinancialInstrument105
{
    /// <summary>
    /// Additional Asset.
    /// </summary>
    [DisplayName("Additional Asset")]
    [IsoXmlTag("AddtlAsst")]
    public IsoYesNoIndicator? AdditionalAsset { get; init; }

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Assets Held In Own Name.
    /// </summary>
    [DisplayName("Assets Held In Own Name")]
    [IsoXmlTag("AsstsHeldInOwnNm")]
    public IsoYesNoIndicator? AssetsHeldInOwnName { get; init; }

    /// <summary>
    /// Average Acquisition Price.
    /// </summary>
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Business Flow Type.
    /// </summary>
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Client Reference.
    /// </summary>
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Conversion.
    /// </summary>
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public Conversion3? Conversion { get; init; }

    /// <summary>
    /// Counterparty Reference.
    /// </summary>
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Crystallisation Details.
    /// </summary>
    [DisplayName("Crystallisation Details")]
    [IsoXmlTag("CrstllstnDtls")]
    public ValueList<Crystallisation2> CrystallisationDetails { get; init; } = [];

    /// <summary>
    /// Effective Settlement Date.
    /// </summary>
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Effective Transfer Date.
    /// </summary>
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public DateAndDateTime2Choice_? EffectiveTransferDate { get; init; }

    /// <summary>
    /// Instrument.
    /// </summary>
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrument63Choice_ Instrument { get; init; }

    /// <summary>
    /// Intermediary Information.
    /// </summary>
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Latest Valuation.
    /// </summary>
    [DisplayName("Latest Valuation")]
    [IsoXmlTag("LatstValtn")]
    public DateAndAmount2? LatestValuation { get; init; }

    /// <summary>
    /// Line Identification.
    /// </summary>
    [DisplayName("Line Identification")]
    [IsoXmlTag("LineId")]
    public IsoMax35Text? LineIdentification { get; init; }

    /// <summary>
    /// Not Available.
    /// </summary>
    [DisplayName("Not Available")]
    [IsoXmlTag("NotAvlbl")]
    public IsoYesNoIndicator? NotAvailable { get; init; }

    /// <summary>
    /// Original Cost.
    /// </summary>
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; }

    /// <summary>
    /// Original Percentage Instructed.
    /// </summary>
    [DisplayName("Original Percentage Instructed")]
    [IsoXmlTag("OrgnlPctgInstd")]
    public IsoPercentageRate? OriginalPercentageInstructed { get; init; }

    /// <summary>
    /// Partial Instructed Quantity.
    /// </summary>
    [DisplayName("Partial Instructed Quantity")]
    [IsoXmlTag("PrtlInstdQty")]
    public IsoYesNoIndicator? PartialInstructedQuantity { get; init; }

    /// <summary>
    /// Payment Details.
    /// </summary>
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument20? PaymentDetails { get; init; }

    /// <summary>
    /// Quantity.
    /// </summary>
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity50? Quantity { get; init; }

    /// <summary>
    /// Requested Settlement Date.
    /// </summary>
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Requested Trade Date.
    /// </summary>
    [DisplayName("Requested Trade Date")]
    [IsoXmlTag("ReqdTradDt")]
    public IsoISODate? RequestedTradeDate { get; init; }

    /// <summary>
    /// Settlement Parties Details.
    /// </summary>
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters17? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Tax Valuation Point.
    /// </summary>
    [DisplayName("Tax Valuation Point")]
    [IsoXmlTag("TaxValtnPt")]
    public Tax36? TaxValuationPoint { get; init; }

    /// <summary>
    /// Total Book Value.
    /// </summary>
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public DateAndAmount2? TotalBookValue { get; init; }

    /// <summary>
    /// Transfer Currency.
    /// </summary>
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Transferee Account.
    /// </summary>
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account28? TransfereeAccount { get; init; }

    /// <summary>
    /// Transferor.
    /// </summary>
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public Account28? Transferor { get; init; }

    /// <summary>
    /// Transfer Results In Change Of Beneficial Owner.
    /// </summary>
    [DisplayName("Transfer Results In Change Of Beneficial Owner")]
    [IsoXmlTag("TrfRsltsInChngOfBnfclOwnr")]
    public IsoYesNoIndicator? TransferResultsInChangeOfBeneficialOwner { get; init; }

    /// <summary>
    /// Transfer Type.
    /// </summary>
    [DisplayName("Transfer Type")]
    [IsoXmlTag("TrfTp")]
    public required TransferType2Choice_ TransferType { get; init; }

    /// <summary>
    /// Units Details.
    /// </summary>
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit11> UnitsDetails { get; init; } = [];
}
