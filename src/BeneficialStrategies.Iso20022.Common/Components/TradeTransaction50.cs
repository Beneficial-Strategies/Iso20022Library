// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Transaction50.
/// </summary>
[IsoId("_8t-JsY-REe6Ojt1b3tfu9Q")]
[DisplayName("Trade Transaction50")]
public partial record TradeTransaction50
{
    #nullable enable

    /// <summary>
    /// Block Trade Election.
    /// </summary>
    [DisplayName("Block Trade Election")]
    [IsoXmlTag("BlckTradElctn")]
    public IsoTrueFalseIndicator? BlockTradeElection { get; init; } 

    /// <summary>
    /// Collateral Portfolio Code.
    /// </summary>
    [DisplayName("Collateral Portfolio Code")]
    [IsoXmlTag("CollPrtflCd")]
    public CollateralPortfolioCode6Choice_? CollateralPortfolioCode { get; init; } 

    /// <summary>
    /// Commodity.
    /// </summary>
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public AssetClassCommodity7Choice_? Commodity { get; init; } 

    /// <summary>
    /// Compression.
    /// </summary>
    [DisplayName("Compression")]
    [IsoXmlTag("Cmprssn")]
    public IsoTrueFalseIndicator? Compression { get; init; } 

    /// <summary>
    /// Credit.
    /// </summary>
    [DisplayName("Credit")]
    [IsoXmlTag("Cdt")]
    public CreditDerivative4? Credit { get; init; } 

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyExchange22? Currency { get; init; } 

    /// <summary>
    /// Delivery Type.
    /// </summary>
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public PhysicalTransferType4Code? DeliveryType { get; init; } 

    /// <summary>
    /// Derivative Event.
    /// </summary>
    [DisplayName("Derivative Event")]
    [IsoXmlTag("DerivEvt")]
    public DerivativeEvent6? DerivativeEvent { get; init; } 

    /// <summary>
    /// Early Termination Date.
    /// </summary>
    [DisplayName("Early Termination Date")]
    [IsoXmlTag("EarlyTermntnDt")]
    public IsoISODate? EarlyTerminationDate { get; init; } 

    /// <summary>
    /// Effective Date.
    /// </summary>
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public IsoISODate? EffectiveDate { get; init; } 

    /// <summary>
    /// Energy Specific Attributes.
    /// </summary>
    [DisplayName("Energy Specific Attributes")]
    [IsoXmlTag("NrgySpcfcAttrbts")]
    public EnergySpecificAttribute9? EnergySpecificAttributes { get; init; } 

    /// <summary>
    /// Execution Time Stamp.
    /// </summary>
    [DisplayName("Execution Time Stamp")]
    [IsoXmlTag("ExctnTmStmp")]
    public IsoISODateTime? ExecutionTimeStamp { get; init; } 

    /// <summary>
    /// Expiration Date.
    /// </summary>
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    public IsoISODate? ExpirationDate { get; init; } 

    /// <summary>
    /// Interest Rate.
    /// </summary>
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRateLegs14? InterestRate { get; init; } 

    /// <summary>
    /// Large Notional Off Facility Election.
    /// </summary>
    [DisplayName("Large Notional Off Facility Election")]
    [IsoXmlTag("LrgNtnlOffFcltyElctn")]
    public IsoTrueFalseIndicator? LargeNotionalOffFacilityElection { get; init; } 

    /// <summary>
    /// Master Agreement.
    /// </summary>
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement8? MasterAgreement { get; init; } 

    /// <summary>
    /// Mirror Or Trigger Transaction.
    /// </summary>
    [DisplayName("Mirror Or Trigger Transaction")]
    [IsoXmlTag("MrrrOrTrggrTx")]
    public IsoTrueFalseIndicator? MirrorOrTriggerTransaction { get; init; } 

    /// <summary>
    /// Non Standardised Term.
    /// </summary>
    [DisplayName("Non Standardised Term")]
    [IsoXmlTag("NonStdsdTerm")]
    public IsoTrueFalseIndicator? NonStandardisedTerm { get; init; } 

    /// <summary>
    /// Notional Amount.
    /// </summary>
    [DisplayName("Notional Amount")]
    [IsoXmlTag("NtnlAmt")]
    public NotionalAmountLegs5? NotionalAmount { get; init; } 

    /// <summary>
    /// Notional Quantity.
    /// </summary>
    [DisplayName("Notional Quantity")]
    [IsoXmlTag("NtnlQty")]
    public NotionalQuantityLegs5? NotionalQuantity { get; init; } 

    /// <summary>
    /// Option.
    /// </summary>
    [DisplayName("Option")]
    [IsoXmlTag("Optn")]
    public OptionOrSwaption11? Option { get; init; } 

    /// <summary>
    /// Other Payment.
    /// </summary>
    [DisplayName("Other Payment")]
    [IsoXmlTag("OthrPmt")]
    public ValueList<OtherPayment5> OtherPayment { get; init; } = [];

    /// <summary>
    /// Package.
    /// </summary>
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public Package4? Package { get; init; } 

    /// <summary>
    /// Platform Identifier.
    /// </summary>
    [DisplayName("Platform Identifier")]
    [IsoXmlTag("PltfmIdr")]
    public IsoMICIdentifier? PlatformIdentifier { get; init; } 

    /// <summary>
    /// Post Trade Risk Reduction Event.
    /// </summary>
    [DisplayName("Post Trade Risk Reduction Event")]
    [IsoXmlTag("PstTradRskRdctnEvt")]
    public PTRREvent2? PostTradeRiskReductionEvent { get; init; } 

    /// <summary>
    /// Post Trade Risk Reduction Flag.
    /// </summary>
    [DisplayName("Post Trade Risk Reduction Flag")]
    [IsoXmlTag("PstTradRskRdctnFlg")]
    public IsoTrueFalseIndicator? PostTradeRiskReductionFlag { get; init; } 

    /// <summary>
    /// Prior Transaction Identification.
    /// </summary>
    [DisplayName("Prior Transaction Identification")]
    [IsoXmlTag("PrrTxId")]
    public UniqueTransactionIdentifier3Choice_? PriorTransactionIdentification { get; init; } 

    /// <summary>
    /// Quantity.
    /// </summary>
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity32Choice_? Quantity { get; init; } 

    /// <summary>
    /// Report Tracking Number.
    /// </summary>
    [DisplayName("Report Tracking Number")]
    [IsoXmlTag("RptTrckgNb")]
    public IsoMax52Text? ReportTrackingNumber { get; init; } 

    /// <summary>
    /// Secondary Transaction Identification.
    /// </summary>
    [DisplayName("Secondary Transaction Identification")]
    [IsoXmlTag("ScndryTxId")]
    public IsoMax72Text? SecondaryTransactionIdentification { get; init; } 

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public ValueList<IsoISODate> SettlementDate { get; init; } = [];

    /// <summary>
    /// Subsequent Transaction Identification.
    /// </summary>
    [DisplayName("Subsequent Transaction Identification")]
    [IsoXmlTag("SbsqntTxId")]
    public UniqueTransactionIdentifier3Choice_? SubsequentTransactionIdentification { get; init; } 

    /// <summary>
    /// Trade Allocation Status.
    /// </summary>
    [DisplayName("Trade Allocation Status")]
    [IsoXmlTag("TradAllcnSts")]
    public AllocationIndicator1Code? TradeAllocationStatus { get; init; } 

    /// <summary>
    /// Trade Clearing.
    /// </summary>
    [DisplayName("Trade Clearing")]
    [IsoXmlTag("TradClr")]
    public TradeClearing11? TradeClearing { get; init; } 

    /// <summary>
    /// Trade Confirmation.
    /// </summary>
    [DisplayName("Trade Confirmation")]
    [IsoXmlTag("TradConf")]
    public TradeConfirmation4Choice_? TradeConfirmation { get; init; } 

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; } 

    /// <summary>
    /// Transaction Price.
    /// </summary>
    [DisplayName("Transaction Price")]
    [IsoXmlTag("TxPric")]
    public PriceData2? TransactionPrice { get; init; } 

    
    #nullable disable
    
}
