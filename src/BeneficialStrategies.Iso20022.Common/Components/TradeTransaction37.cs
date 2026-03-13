// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the trade transaction.
/// </summary>
[IsoId("_DRVSMXhQEeu3kecHd7QKUQ")]
[DisplayName("Trade Transaction")]
public partial record TradeTransaction37
{
    #nullable enable
    
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty.
    /// </summary>
    [IsoId("_Df6gwXhQEeu3kecHd7QKUQ")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public required UniqueTransactionIdentifier1Choice_ UniqueTransactionIdentifier { get; init; } 
    
    /// <summary>
    /// Identifies the UTI assigned to the predecessor transaction that has given rise to the reported transaction due to a lifecycle event.
    /// |
    /// Usage: This data element is not applicable when reporting many-to-one and many-to-many relations between transactions (for example, in the case of a compression).
    /// This data element may be applicable when reporting one-to-one and one-to-many relations between transactions (for example, in the case of a clearing).|
    /// </summary>
    [IsoId("_Df6gw3hQEeu3kecHd7QKUQ")]
    [DisplayName("Prior Unique Transaction Identifier")]
    [IsoXmlTag("PrrUnqTxIdr")]
    public UniqueTransactionIdentifier1Choice_? PriorUniqueTransactionIdentifier { get; init; } 
    
    /// <summary>
    /// Unique number to indicate a group of reports which relate to the same execution.
    /// </summary>
    [IsoId("_Df6gxXhQEeu3kecHd7QKUQ")]
    [DisplayName("Report Tracking Number")]
    [IsoXmlTag("RptTrckgNb")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? ReportTrackingNumber { get; init; } 
    
    /// <summary>
    /// Identifies the trading platform on which the derivative transaction was executed (e.g. exchange, multilateral trading facility, swap execution facility). ||
    /// Usage: |For transactions where no trading facility was involved, specific predefined codes have to be used.
    /// </summary>
    [IsoId("_Df6gx3hQEeu3kecHd7QKUQ")]
    [DisplayName("Platform Identifier")]
    [IsoXmlTag("PltfmIdr")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? PlatformIdentifier { get; init; } 
    
    /// <summary>
    /// Identifies whether the contract results from a compression operation or not.
    /// </summary>
    [IsoId("_Df6gyXhQEeu3kecHd7QKUQ")]
    [DisplayName("Compression")]
    [IsoXmlTag("Cmprssn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Compression { get; init; } 
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_Df6gy3hQEeu3kecHd7QKUQ")]
    [DisplayName("Transaction Price")]
    [IsoXmlTag("TxPric")]
    public PriceData1? TransactionPrice { get; init; } 
    
    /// <summary>
    /// Indicates monetary or converted amount for the derivatives transaction.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_Df6gzXhQEeu3kecHd7QKUQ")]
    [DisplayName("Notional Amount")]
    [IsoXmlTag("NtnlAmt")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<NotionalAmount1> NotionalAmount { get; init; } = [];
    
    /// <summary>
    /// Indicates for each leg of the transaction the total notional quantity of the underlying asset for the term of the transaction.|
    /// </summary>
    [IsoId("_Df6gz3hQEeu3kecHd7QKUQ")]
    [DisplayName("Notional Quantity")]
    [IsoXmlTag("NtnlQty")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<NotionalQuantity1> NotionalQuantity { get; init; } = [];
    
    /// <summary>
    /// Specifies the ratio of the absolute change in price of a derivative transaction to the change in price of the underlier, at the time a new transaction is reported or when a change in the notional amount is reported.
    /// </summary>
    [IsoId("_Df6g0XhQEeu3kecHd7QKUQ")]
    [DisplayName("Delta")]
    [IsoXmlTag("Dlta")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public IsoLongFraction19DecimalNumber? Delta { get; init; } 
    
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("_Df6g03hQEeu3kecHd7QKUQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity32Choice_? Quantity { get; init; } 
    
    /// <summary>
    /// Indicates whether the financial instrument is settled physically or in cash or decided at expiration time by counterparty.
    /// </summary>
    [IsoId("_Df6g1XhQEeu3kecHd7QKUQ")]
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public PhysicalTransferType4Code? DeliveryType { get; init; } 
    
    /// <summary>
    /// Indicates the date and time of the execution of the derivative transaction.
    /// </summary>
    [IsoId("_Df6g13hQEeu3kecHd7QKUQ")]
    [DisplayName("Execution Time Stamp")]
    [IsoXmlTag("ExctnTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExecutionTimeStamp { get; init; } 
    
    /// <summary>
    /// Indicates the date when obligations under the contract come into effect.
    /// </summary>
    [IsoId("_Df6g2XhQEeu3kecHd7QKUQ")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the derivative transaction stop being effective, as included in the confirmation.|
    /// For European style options, date on which the holder can exercise the right or let it lapse.
    /// For American style options, the holder can exercise the right up to the expiry date.||
    /// Usage: |An early termination shall not be reported in this field.
    /// </summary>
    [IsoId("_Df6g23hQEeu3kecHd7QKUQ")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpirationDate { get; init; } 
    
    /// <summary>
    /// Indicates the effective date of the early termination of the reported derivative transaction.
    /// </summary>
    [IsoId("_Df6g3XhQEeu3kecHd7QKUQ")]
    [DisplayName("Early Termination Date")]
    [IsoXmlTag("EarlyTermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EarlyTerminationDate { get; init; } 
    
    /// <summary>
    /// Indicates the unadjusted date, as per the contract, by which all transfer of cash or assets should take place and the counterparties should no longer have any outstanding obligations to each other.||
    /// For products that may not have a final contractual settlement date (eg American options), this data element reflects the date by which the transfer of cash or asset would take place if termination were to occur on the expiration date.
    /// </summary>
    [IsoId("_Df6g33hQEeu3kecHd7QKUQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; } 
    
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_Df6g43hQEeu3kecHd7QKUQ")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement7? MasterAgreement { get; init; } 
    
    /// <summary>
    /// Specifies whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.
    /// </summary>
    [IsoId("_Df6g5XhQEeu3kecHd7QKUQ")]
    [DisplayName("Trade Confirmation")]
    [IsoXmlTag("TradConf")]
    public TradeConfirmation1Choice_? TradeConfirmation { get; init; } 
    
    /// <summary>
    /// Information related to clearing of the reported contract.
    /// </summary>
    [IsoId("_Df6g53hQEeu3kecHd7QKUQ")]
    [DisplayName("Trade Clearing")]
    [IsoXmlTag("TradClr")]
    public TradeClearing5? TradeClearing { get; init; } 
    
    /// <summary>
    /// Information related to interest rate asset class type.
    /// </summary>
    [IsoId("_Df6g6XhQEeu3kecHd7QKUQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRateLegs9? InterestRate { get; init; } 
    
    /// <summary>
    /// Information related to currency asset class type.
    /// </summary>
    [IsoId("_Df6g63hQEeu3kecHd7QKUQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyExchange17? Currency { get; init; } 
    
    /// <summary>
    /// Information related to commodity asset class type.
    /// </summary>
    [IsoId("_Df6g7XhQEeu3kecHd7QKUQ")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public AssetClassCommodity2Choice_? Commodity { get; init; } 
    
    /// <summary>
    /// Attributes specific for derivative contracts related to natural gas and electricity delivered in the European Union.
    /// </summary>
    [IsoId("_Df6g73hQEeu3kecHd7QKUQ")]
    [DisplayName("Energy Specific Attributes")]
    [IsoXmlTag("NrgySpcfcAttrbts")]
    public EnergySpecificAttribute6? EnergySpecificAttributes { get; init; } 
    
    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_Df6g8XhQEeu3kecHd7QKUQ")]
    [DisplayName("Option")]
    [IsoXmlTag("Optn")]
    public OptionOrSwaption7? Option { get; init; } 
    
    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_Df6g83hQEeu3kecHd7QKUQ")]
    [DisplayName("Credit")]
    [IsoXmlTag("Cdt")]
    public CreditDerivative4? Credit { get; init; } 
    
    /// <summary>
    /// Payment related to elements not reported in dedicated fields.
    /// </summary>
    [IsoId("_Df6g9XhQEeu3kecHd7QKUQ")]
    [DisplayName("Other Payment")]
    [IsoXmlTag("OthrPmt")]
    public OtherPayment3? OtherPayment { get; init; } 
    
    /// <summary>
    /// A combination of two or more transactions that are reported separately but that are negotiated together as the product of a single economic agreement.
    /// </summary>
    [IsoId("_Df6g93hQEeu3kecHd7QKUQ")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public Package1? Package { get; init; } 
    
    
    #nullable disable
    
}
