// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the trade transaction.
/// </summary>
[IsoId("_4tV9sQ1IEeqV4s5SpzR1dQ")]
[DisplayName("Trade Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeTransaction25
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeTransaction25 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeTransaction25( System.String reqUniqueTradeIdentifier )
    {
        UniqueTradeIdentifier = reqUniqueTradeIdentifier;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    [IsoId("_4uLEIQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Unique Trade Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqTradIdr")]
    #endif
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UniqueTradeIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UniqueTradeIdentifier { get; init; } 
    #else
    public System.String UniqueTradeIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number to indicate a group of reports which relate to the same execution.
    /// </summary>
    [IsoId("_4uLEIw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Report Tracking Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptTrckgNb")]
    #endif
    [IsoXmlTag("RptTrckgNb")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? ReportTrackingNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportTrackingNumber { get; init; } 
    #else
    public System.String? ReportTrackingNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification, internal to the reporting firm to identify all the reports related to the same execution of a combination of financial instruments. The code must be unique for the firm for the group of reports for the execution.
    /// Usage: Field only applies when the instrument is complex.
    /// </summary>
    [IsoId("_4uLEJQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Complex Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmplxTradId")]
    #endif
    [IsoXmlTag("CmplxTradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ComplexTradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ComplexTradeIdentification { get; init; } 
    #else
    public System.String? ComplexTradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Venue of execution identified by a unique code for this venue. 
    /// In case of a contract concluded OTC, it has to be identified using specific MIC codes designating OTC transactions.
    /// </summary>
    [IsoId("_4uLEJw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradingVenue { get; init; } 
    #else
    public System.String? TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the contract results from a compression operation or not.
    /// </summary>
    [IsoId("_4uLEKQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Compression")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmprssn")]
    #endif
    [IsoXmlTag("Cmprssn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? Compression { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Compression { get; init; } 
    #else
    public System.String? Compression { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_4uLEKw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pric")]
    #endif
    [IsoXmlTag("Pric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice10Choice_? Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice10Choice_? Price { get; init; } 
    #else
    public SecuritiesTransactionPrice10Choice_? Price { get; set; } 
    #endif
    
    /// <summary>
    /// Reference amount from which contractual payments are determined.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_4uLELQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Notional Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmt")]
    #endif
    [IsoXmlTag("NtnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection56? NotionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection56? NotionalAmount { get; init; } 
    #else
    public AmountAndDirection56? NotionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract.
    /// </summary>
    [IsoId("_4uLELw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Price Multiplier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricMltplr")]
    #endif
    [IsoXmlTag("PricMltplr")]
    [IsoSimpleType(IsoSimpleType.LongFraction21DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLongFraction21DecimalNumber? PriceMultiplier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PriceMultiplier { get; init; } 
    #else
    public System.UInt64? PriceMultiplier { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("_4uLEMQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity30Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity30Choice_? Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity30Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money of any up-front payment the reporting counterparty made or received.
    /// Usage: The negative symbol to be used to indicate that the payment was made, not received.
    /// </summary>
    [IsoId("_4uLEMw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Up Front Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpFrntPmt")]
    #endif
    [IsoXmlTag("UpFrntPmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection56? UpFrontPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection56? UpFrontPayment { get; init; } 
    #else
    public AmountAndDirection56? UpFrontPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is settled physically or in cash or decided at expiration time by counterparty.
    /// </summary>
    [IsoId("_4uLENQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Delivery Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryTp")]
    #endif
    [IsoXmlTag("DlvryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PhysicalTransferType4Code? DeliveryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PhysicalTransferType4Code? DeliveryType { get; init; } 
    #else
    public PhysicalTransferType4Code? DeliveryType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_4uLENw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Execution Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnDtTm")]
    #endif
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ExecutionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ExecutionDateTime { get; init; } 
    #else
    public System.DateTime? ExecutionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date when obligations under the contract come into effect.
    /// </summary>
    [IsoId("_4uLEOQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EffectiveDate { get; init; } 
    #else
    public System.DateOnly? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the original date of expiry of the reported contract. 
    /// Usage: 
    /// An early termination shall not be reported in this field.
    /// </summary>
    [IsoId("_4uLEOw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date in the case of an early termination of the reported contract.
    /// </summary>
    [IsoId("_4uLEPQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TerminationDate { get; init; } 
    #else
    public System.DateOnly? TerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date of settlement of the underlying.
    /// </summary>
    [IsoId("_4uLEPw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SettlementDate { get; init; } 
    #else
    public System.DateOnly? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the Master agreement.
    /// </summary>
    [IsoId("_4uLEQw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Master Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmt")]
    #endif
    [IsoXmlTag("MstrAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MasterAgreement5? MasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MasterAgreement5? MasterAgreement { get; init; } 
    #else
    public MasterAgreement5? MasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.
    /// </summary>
    [IsoId("_4uLERQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Trade Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradConf")]
    #endif
    [IsoXmlTag("TradConf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeConfirmation2Choice_? TradeConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeConfirmation2Choice_? TradeConfirmation { get; init; } 
    #else
    public TradeConfirmation2Choice_? TradeConfirmation { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to clearing of the reported contract.
    /// </summary>
    [IsoId("_4uLERw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Trade Clearing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradClr")]
    #endif
    [IsoXmlTag("TradClr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeClearing3? TradeClearing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeClearing3? TradeClearing { get; init; } 
    #else
    public TradeClearing3? TradeClearing { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to interest rate asset class type.
    /// </summary>
    [IsoId("_4uLESQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateLegs7? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateLegs7? InterestRate { get; init; } 
    #else
    public InterestRateLegs7? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to currency asset class type.
    /// </summary>
    [IsoId("_4uLESw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange10? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange10? Currency { get; init; } 
    #else
    public CurrencyExchange10? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to commodity asset class type.
    /// </summary>
    [IsoId("_4uLETQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Commodity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmmdty")]
    #endif
    [IsoXmlTag("Cmmdty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassCommodity2Choice_? Commodity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassCommodity2Choice_? Commodity { get; init; } 
    #else
    public AssetClassCommodity2Choice_? Commodity { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes specific for derivative contracts related to natural gas and electricity delivered in the European Union.
    /// </summary>
    [IsoId("_4uLETw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Energy Specific Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgySpcfcAttrbts")]
    #endif
    [IsoXmlTag("NrgySpcfcAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnergySpecificAttribute5? EnergySpecificAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnergySpecificAttribute5? EnergySpecificAttributes { get; init; } 
    #else
    public EnergySpecificAttribute5? EnergySpecificAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_4uLEUQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Optn")]
    #endif
    [IsoXmlTag("Optn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionOrSwaption4? Option { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionOrSwaption4? Option { get; init; } 
    #else
    public OptionOrSwaption4? Option { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_4uLEUw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdt")]
    #endif
    [IsoXmlTag("Cdt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDerivative2? Credit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDerivative2? Credit { get; init; } 
    #else
    public CreditDerivative2? Credit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
