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
[IsoId("_TvV9ldp-Ed-ak6NoX_4Aeg_-1306183521")]
[DisplayName("Financial Instrument Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes4
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
    [IsoId("_TvV9ltp-Ed-ak6NoX_4Aeg_-1420022587")]
    [DisplayName("Place Of Listing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfListg")]
    #endif
    [IsoXmlTag("PlcOfListg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification5? PlaceOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification5? PlaceOfListing { get; init; } 
    #else
    public MarketIdentification5? PlaceOfListing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_TvV9l9p-Ed-ak6NoX_4Aeg_1877872356")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; } 
    #else
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the form, ie, ownership, of the security.
    /// </summary>
    [IsoId("_TvV9mNp-Ed-ak6NoX_4Aeg_880800003")]
    [DisplayName("Registration Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnForm")]
    #endif
    [IsoXmlTag("RegnForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity2Choice_? RegistrationForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity2Choice_? RegistrationForm { get; init; } 
    #else
    public FormOfSecurity2Choice_? RegistrationForm { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_TvV9mdp-Ed-ak6NoX_4Aeg_-116272350")]
    [DisplayName("Payment Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFrqcy")]
    #endif
    [IsoXmlTag("PmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency3Choice_? PaymentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency3Choice_? PaymentFrequency { get; init; } 
    #else
    public Frequency3Choice_? PaymentFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_TvfukNp-Ed-ak6NoX_4Aeg_-1113344703")]
    [DisplayName("Payment Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSts")]
    #endif
    [IsoXmlTag("PmtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesPaymentStatus2Choice_? PaymentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesPaymentStatus2Choice_? PaymentStatus { get; init; } 
    #else
    public SecuritiesPaymentStatus2Choice_? PaymentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the direction of payment for asset or mortgage backed securities, ie, whether the repaid capital is distributed (payment direction is down) or capitalized (payment direction is up).
    /// </summary>
    [IsoId("_Tvfukdp-Ed-ak6NoX_4Aeg_-2110417056")]
    [DisplayName("Payment Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDrctn")]
    #endif
    [IsoXmlTag("PmtDrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentDirection2Choice_? PaymentDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentDirection2Choice_? PaymentDirection { get; init; } 
    #else
    public PaymentDirection2Choice_? PaymentDirection { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    [IsoId("_Tvfuktp-Ed-ak6NoX_4Aeg_1187477887")]
    [DisplayName("Variable Rate Change Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VarblRateChngFrqcy")]
    #endif
    [IsoXmlTag("VarblRateChngFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency3Choice_? VariableRateChangeFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency3Choice_? VariableRateChangeFrequency { get; init; } 
    #else
    public Frequency3Choice_? VariableRateChangeFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the level of priority to claim on income and assets of the company in case of the payment of dividends and in the event of a bankruptcy, for example, ordinary/common stocks, preferred stocks, subordinated debt, etc.
    /// </summary>
    [IsoId("_Tvfuk9p-Ed-ak6NoX_4Aeg_190405534")]
    [DisplayName("Preference To Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrefToIncm")]
    #endif
    [IsoXmlTag("PrefToIncm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreferenceToIncome2Choice_? PreferenceToIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreferenceToIncome2Choice_? PreferenceToIncome { get; init; } 
    #else
    public PreferenceToIncome2Choice_? PreferenceToIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_TvfulNp-Ed-ak6NoX_4Aeg_-806666819")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClassificationType2Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType2Choice_? ClassificationType { get; init; } 
    #else
    public ClassificationType2Choice_? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_Tvfuldp-Ed-ak6NoX_4Aeg_-1803739172")]
    [DisplayName("Option Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnStyle")]
    #endif
    [IsoXmlTag("OptnStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionStyle4Choice_? OptionStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionStyle4Choice_? OptionStyle { get; init; } 
    #else
    public OptionStyle4Choice_? OptionStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_Tvfultp-Ed-ak6NoX_4Aeg_-228163183")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType2Choice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType2Choice_? OptionType { get; init; } 
    #else
    public OptionType2Choice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_Tvful9p-Ed-ak6NoX_4Aeg_-1225235536")]
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
    [IsoId("_TvfumNp-Ed-ak6NoX_4Aeg_2072659407")]
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
    [IsoId("_Tvfumdp-Ed-ak6NoX_4Aeg_1075587054")]
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
    [IsoId("_TvpfkNp-Ed-ak6NoX_4Aeg_78514701")]
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
    [IsoId("_Tvpfkdp-Ed-ak6NoX_4Aeg_-918557652")]
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
    [IsoId("_Tvpfktp-Ed-ak6NoX_4Aeg_-1915630005")]
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
    [IsoId("_Tvpfk9p-Ed-ak6NoX_4Aeg_1382264938")]
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
    [IsoId("_TvpflNp-Ed-ak6NoX_4Aeg_385192585")]
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
    [IsoId("_Tvpfldp-Ed-ak6NoX_4Aeg_-611879768")]
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
    [IsoId("_Tvpfltp-Ed-ak6NoX_4Aeg_-1608952121")]
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
    [IsoId("_Tvpfl9p-Ed-ak6NoX_4Aeg_1688942822")]
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
    [IsoId("_TvpfmNp-Ed-ak6NoX_4Aeg_691870469")]
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
    [IsoId("_Tvpfmdp-Ed-ak6NoX_4Aeg_-305201884")]
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
    [IsoId("_TvypgNp-Ed-ak6NoX_4Aeg_-1302274237")]
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
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_Tvypgdp-Ed-ak6NoX_4Aeg_1995620706")]
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
    [IsoId("_Tvypgtp-Ed-ak6NoX_4Aeg_998548353")]
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
    [IsoId("_Tvypg9p-Ed-ak6NoX_4Aeg_1476000")]
    [DisplayName("Coupon Attached Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnAttchdNb")]
    #endif
    [IsoXmlTag("CpnAttchdNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number2Choice_? CouponAttachedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number2Choice_? CouponAttachedNumber { get; init; } 
    #else
    public Number2Choice_? CouponAttachedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_TvyphNp-Ed-ak6NoX_4Aeg_-995596353")]
    [DisplayName("Pool Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolNb")]
    #endif
    [IsoXmlTag("PoolNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number2Choice_? PoolNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number2Choice_? PoolNumber { get; init; } 
    #else
    public Number2Choice_? PoolNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series, etc.
    /// </summary>
    [IsoId("_Tvyphdp-Ed-ak6NoX_4Aeg_1007213800")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown5? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown5? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown5? QuantityBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_Tvyphtp-Ed-ak6NoX_4Aeg_-1992668706")]
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
    [IsoId("_Tvyph9p-Ed-ak6NoX_4Aeg_1305226237")]
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
    [IsoId("_TvypiNp-Ed-ak6NoX_4Aeg_308153884")]
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
    [IsoId("_Tv8agNp-Ed-ak6NoX_4Aeg_-688918469")]
    [DisplayName("Market Or Indicative Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktOrIndctvPric")]
    #endif
    [IsoXmlTag("MktOrIndctvPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceType1Choice_? MarketOrIndicativePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceType1Choice_? MarketOrIndicativePrice { get; init; } 
    #else
    public PriceType1Choice_? MarketOrIndicativePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_Tv8agdp-Ed-ak6NoX_4Aeg_-1685990822")]
    [DisplayName("Exercise Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExrcPric")]
    #endif
    [IsoXmlTag("ExrcPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price2? ExercisePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price2? ExercisePrice { get; init; } 
    #else
    public Price2? ExercisePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Pre-determined price at which the holder of a right is entitled to buy the underlying instrument.
    /// </summary>
    [IsoId("_Tv8agtp-Ed-ak6NoX_4Aeg_1611904121")]
    [DisplayName("Subscription Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptPric")]
    #endif
    [IsoXmlTag("SbcptPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price2? SubscriptionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price2? SubscriptionPrice { get; init; } 
    #else
    public Price2? SubscriptionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Price of one target security in the conversion.
    /// </summary>
    [IsoId("_Tv8ag9p-Ed-ak6NoX_4Aeg_614831768")]
    [DisplayName("Conversion Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsPric")]
    #endif
    [IsoXmlTag("ConvsPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price2? ConversionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price2? ConversionPrice { get; init; } 
    #else
    public Price2? ConversionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_Tv8ahNp-Ed-ak6NoX_4Aeg_-2069707407")]
    [DisplayName("Strike Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPric")]
    #endif
    [IsoXmlTag("StrkPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price2? StrikePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price2? StrikePrice { get; init; } 
    #else
    public Price2? StrikePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_Tv8ahdp-Ed-ak6NoX_4Aeg_1228187536")]
    [DisplayName("Minimum Nominal Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinNmnlQty")]
    #endif
    [IsoXmlTag("MinNmnlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_Tv8ahtp-Ed-ak6NoX_4Aeg_231115183")]
    [DisplayName("Contract Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctSz")]
    #endif
    [IsoXmlTag("CtrctSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the underlying security by an ISIN.
    /// </summary>
    [IsoId("_Tv8ah9p-Ed-ak6NoX_4Aeg_-765957170")]
    [DisplayName("Underlying Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygFinInstrmId")]
    #endif
    [IsoXmlTag("UndrlygFinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification11? UnderlyingFinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11? UnderlyingFinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification11? UnderlyingFinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    [IsoId("_Tv8aiNp-Ed-ak6NoX_4Aeg_-1763029523")]
    [DisplayName("Financial Instrument Attribute Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrAddtlDtls")]
    #endif
    [IsoXmlTag("FinInstrmAttrAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FinancialInstrumentAttributeAdditionalDetails { get; init; } 
    #else
    public System.String? FinancialInstrumentAttributeAdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
