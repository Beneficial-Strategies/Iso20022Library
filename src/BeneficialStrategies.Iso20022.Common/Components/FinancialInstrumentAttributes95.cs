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
/// Elements characterising a financial instrument.
/// </summary>
[IsoId("_SKLU183yEee5nJBZsW8MFQ")]
[DisplayName("Financial Instrument Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes95
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_SKLU383yEee5nJBZsW8MFQ")]
    [DisplayName("Place Of Listing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfListg")]
    #endif
    [IsoXmlTag("PlcOfListg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification4Choice_? PlaceOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification4Choice_? PlaceOfListing { get; init; } 
    #else
    public MarketIdentification4Choice_? PlaceOfListing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_SKLU583yEee5nJBZsW8MFQ")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; init; } 
    #else
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the form, this is, ownership, of the security.
    /// </summary>
    [IsoId("_SKLU783yEee5nJBZsW8MFQ")]
    [DisplayName("Registration Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnForm")]
    #endif
    [IsoXmlTag("RegnForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity7Choice_? RegistrationForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity7Choice_? RegistrationForm { get; init; } 
    #else
    public FormOfSecurity7Choice_? RegistrationForm { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_SKLU983yEee5nJBZsW8MFQ")]
    [DisplayName("Payment Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFrqcy")]
    #endif
    [IsoXmlTag("PmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency27Choice_? PaymentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency27Choice_? PaymentFrequency { get; init; } 
    #else
    public Frequency27Choice_? PaymentFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_SKLU_83yEee5nJBZsW8MFQ")]
    [DisplayName("Payment Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSts")]
    #endif
    [IsoXmlTag("PmtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesPaymentStatus6Choice_? PaymentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesPaymentStatus6Choice_? PaymentStatus { get; init; } 
    #else
    public SecuritiesPaymentStatus6Choice_? PaymentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    [IsoId("_SKLVB83yEee5nJBZsW8MFQ")]
    [DisplayName("Variable Rate Change Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VarblRateChngFrqcy")]
    #endif
    [IsoXmlTag("VarblRateChngFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency27Choice_? VariableRateChangeFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency27Choice_? VariableRateChangeFrequency { get; init; } 
    #else
    public Frequency27Choice_? VariableRateChangeFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_SKLVD83yEee5nJBZsW8MFQ")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClassificationType33Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType33Choice_? ClassificationType { get; init; } 
    #else
    public ClassificationType33Choice_? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_SKLVF83yEee5nJBZsW8MFQ")]
    [DisplayName("Option Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnStyle")]
    #endif
    [IsoXmlTag("OptnStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionStyle9Choice_? OptionStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionStyle9Choice_? OptionStyle { get; init; } 
    #else
    public OptionStyle9Choice_? OptionStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_SKLVH83yEee5nJBZsW8MFQ")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType7Choice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType7Choice_? OptionType { get; init; } 
    #else
    public OptionType7Choice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_SKLVJ83yEee5nJBZsW8MFQ")]
    [DisplayName("Denomination Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DnmtnCcy")]
    #endif
    [IsoXmlTag("DnmtnCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DenominationCurrency { get; init; } 
    #else
    public string? DenominationCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_SKLVL83yEee5nJBZsW8MFQ")]
    [DisplayName("Coupon Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnDt")]
    #endif
    [IsoXmlTag("CpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CouponDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CouponDate { get; init; } 
    #else
    public System.DateOnly? CouponDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_SKLVN83yEee5nJBZsW8MFQ")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpiryDate { get; init; } 
    #else
    public System.DateOnly? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the interest rate of an interest bearing security will be calculated and reset, according to the terms of the issue.
    /// </summary>
    [IsoId("_SKLVP83yEee5nJBZsW8MFQ")]
    [DisplayName("Floating Rate Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRateFxgDt")]
    #endif
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FloatingRateFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FloatingRateFixingDate { get; init; } 
    #else
    public System.DateOnly? FloatingRateFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_SKLVR83yEee5nJBZsW8MFQ")]
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
    /// Date at which the security was made available.
    /// </summary>
    [IsoId("_SKLVT83yEee5nJBZsW8MFQ")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? IssueDate { get; init; } 
    #else
    public System.DateOnly? IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Next date at which the issuer has the right to pay the security prior to maturity.
    /// </summary>
    [IsoId("_SKLVV83yEee5nJBZsW8MFQ")]
    [DisplayName("Next Callable Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtCllblDt")]
    #endif
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NextCallableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NextCallableDate { get; init; } 
    #else
    public System.DateOnly? NextCallableDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_SKLVX83yEee5nJBZsW8MFQ")]
    [DisplayName("Putable Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PutblDt")]
    #endif
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PutableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PutableDate { get; init; } 
    #else
    public System.DateOnly? PutableDate { get; set; } 
    #endif
    
    /// <summary>
    /// First date at which a security begins to accrue interest.
    /// </summary>
    [IsoId("_SKLVZ83yEee5nJBZsW8MFQ")]
    [DisplayName("Dated Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtdDt")]
    #endif
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DatedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DatedDate { get; init; } 
    #else
    public System.DateOnly? DatedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the first interest payment is due to holders of the security.
    /// </summary>
    [IsoId("_SKLVb83yEee5nJBZsW8MFQ")]
    [DisplayName("First Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstPmtDt")]
    #endif
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FirstPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FirstPaymentDate { get; init; } 
    #else
    public System.DateOnly? FirstPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_SKLVd83yEee5nJBZsW8MFQ")]
    [DisplayName("Previous Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsFctr")]
    #endif
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? PreviousFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PreviousFactor { get; init; } 
    #else
    public System.Decimal? PreviousFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 defining the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_SKLVf83yEee5nJBZsW8MFQ")]
    [DisplayName("Current Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurFctr")]
    #endif
    [IsoXmlTag("CurFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? CurrentFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CurrentFactor { get; init; } 
    #else
    public System.Decimal? CurrentFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that will be applicable as of the next factor date and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_SKLVh83yEee5nJBZsW8MFQ")]
    [DisplayName("Next Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtFctr")]
    #endif
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? NextFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NextFactor { get; init; } 
    #else
    public System.Decimal? NextFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_SKLVj83yEee5nJBZsW8MFQ")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InterestRate { get; init; } 
    #else
    public System.Decimal? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of return anticipated on a bond when held until maturity date.
    /// </summary>
    [IsoId("_SKLVl83yEee5nJBZsW8MFQ")]
    [DisplayName("Yield To Maturity Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="YldToMtrtyRate")]
    #endif
    [IsoXmlTag("YldToMtrtyRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? YieldToMaturityRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? YieldToMaturityRate { get; init; } 
    #else
    public System.Decimal? YieldToMaturityRate { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_SKLVmc3yEee5nJBZsW8MFQ")]
    [DisplayName("Next Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtIntrstRate")]
    #endif
    [IsoXmlTag("NxtIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? NextInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NextInterestRate { get; init; } 
    #else
    public System.Decimal? NextInterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reference rate for fixed income instruments where the |price of the instrument is indexed to the price of an underlying benchmark.
    /// </summary>
    [IsoId("_SKLVoc3yEee5nJBZsW8MFQ")]
    [DisplayName("Index Rate Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndxRateBsis")]
    #endif
    [IsoXmlTag("IndxRateBsis")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? IndexRateBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? IndexRateBasis { get; init; } 
    #else
    public System.Decimal? IndexRateBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_SKLVqc3yEee5nJBZsW8MFQ")]
    [DisplayName("Coupon Attached Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnAttchdNb")]
    #endif
    [IsoXmlTag("CpnAttchdNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number23Choice_? CouponAttachedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number23Choice_? CouponAttachedNumber { get; init; } 
    #else
    public Number23Choice_? CouponAttachedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_SKLVsc3yEee5nJBZsW8MFQ")]
    [DisplayName("Pool Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolNb")]
    #endif
    [IsoXmlTag("PoolNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification39? PoolNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification39? PoolNumber { get; init; } 
    #else
    public GenericIdentification39? PoolNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_SKLVuc3yEee5nJBZsW8MFQ")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown33? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown33? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown33? QuantityBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_SKLVu83yEee5nJBZsW8MFQ")]
    [DisplayName("Variable Rate Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VarblRateInd")]
    #endif
    [IsoXmlTag("VarblRateInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? VariableRateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VariableRateIndicator { get; init; } 
    #else
    public System.String? VariableRateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_SKLVw83yEee5nJBZsW8MFQ")]
    [DisplayName("Callable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CllblInd")]
    #endif
    [IsoXmlTag("CllblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CallableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CallableIndicator { get; init; } 
    #else
    public System.String? CallableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_SKLVy83yEee5nJBZsW8MFQ")]
    [DisplayName("Putable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PutblInd")]
    #endif
    [IsoXmlTag("PutblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PutableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PutableIndicator { get; init; } 
    #else
    public System.String? PutableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, for example, as a currency and value per unit or as a percentage.
    /// </summary>
    [IsoId("_SKLV083yEee5nJBZsW8MFQ")]
    [DisplayName("Market Or Indicative Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktOrIndctvPric")]
    #endif
    [IsoXmlTag("MktOrIndctvPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceType5Choice_? MarketOrIndicativePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceType5Choice_? MarketOrIndicativePrice { get; init; } 
    #else
    public PriceType5Choice_? MarketOrIndicativePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_SKLV283yEee5nJBZsW8MFQ")]
    [DisplayName("Exercise Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExrcPric")]
    #endif
    [IsoXmlTag("ExrcPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price3? ExercisePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price3? ExercisePrice { get; init; } 
    #else
    public Price3? ExercisePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Pre-determined price at which the holder of a right is entitled to buy the underlying instrument.
    /// </summary>
    [IsoId("_SKLV483yEee5nJBZsW8MFQ")]
    [DisplayName("Subscription Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptPric")]
    #endif
    [IsoXmlTag("SbcptPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price3? SubscriptionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price3? SubscriptionPrice { get; init; } 
    #else
    public Price3? SubscriptionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Price of one target security in the conversion.
    /// </summary>
    [IsoId("_SKLV683yEee5nJBZsW8MFQ")]
    [DisplayName("Conversion Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsPric")]
    #endif
    [IsoXmlTag("ConvsPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price3? ConversionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price3? ConversionPrice { get; init; } 
    #else
    public Price3? ConversionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_SKLV883yEee5nJBZsW8MFQ")]
    [DisplayName("Strike Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPric")]
    #endif
    [IsoXmlTag("StrkPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price3? StrikePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price3? StrikePrice { get; init; } 
    #else
    public Price3? StrikePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum nominal quantity of financial instrument.
    /// </summary>
    [IsoId("_SKLV-83yEee5nJBZsW8MFQ")]
    [DisplayName("Minimum Nominal Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinNmnlQty")]
    #endif
    [IsoXmlTag("MinNmnlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? MinimumNominalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? MinimumNominalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? MinimumNominalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_SKLWA83yEee5nJBZsW8MFQ")]
    [DisplayName("Contract Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctSz")]
    #endif
    [IsoXmlTag("CtrctSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? ContractSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? ContractSize { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? ContractSize { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the underlying security.
    /// </summary>
    [IsoId("_SKLWC83yEee5nJBZsW8MFQ")]
    [DisplayName("Underlying Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygFinInstrmId")]
    #endif
    [IsoXmlTag("UndrlygFinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification32? UnderlyingFinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification32? UnderlyingFinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification32? UnderlyingFinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    [IsoId("_SKLWE83yEee5nJBZsW8MFQ")]
    [DisplayName("Financial Instrument Attribute Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrAddtlDtls")]
    #endif
    [IsoXmlTag("FinInstrmAttrAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FinancialInstrumentAttributeAdditionalDetails { get; init; } 
    #else
    public System.String? FinancialInstrumentAttributeAdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
