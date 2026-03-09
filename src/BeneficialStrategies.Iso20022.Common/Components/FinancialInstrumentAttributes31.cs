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
[IsoId("_AvnUgNokEeC60axPepSq7g_463314075")]
[DisplayName("Financial Instrument Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes31
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
    [IsoId("_AvnUgdokEeC60axPepSq7g_349475009")]
    [DisplayName("Place Of Listing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfListg")]
    #endif
    [IsoXmlTag("PlcOfListg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 
    #else
    public MarketIdentification3Choice_? PlaceOfListing { get; set; } 
    #endif
    
    /// <summary>
    /// Assessment of securities credit and investment risk.
    /// </summary>
    [IsoId("_AvnUgtokEeC60axPepSq7g_2058565219")]
    [DisplayName("Rating")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ratg")]
    #endif
    [IsoXmlTag("Ratg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rating1? Rating { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rating1? Rating { get; init; } 
    #else
    public Rating1? Rating { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_AvnUg9okEeC60axPepSq7g_-647597344")]
    [DisplayName("Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertNb")]
    #endif
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificateNumber { get; init; } 
    #else
    public System.String? CertificateNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_AvxFgNokEeC60axPepSq7g_-1644669697")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat3Choice_? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat3Choice_? DayCountBasis { get; init; } 
    #else
    public InterestComputationMethodFormat3Choice_? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the form, ie, ownership, of the security.
    /// </summary>
    [IsoId("_AvxFgdokEeC60axPepSq7g_1653225246")]
    [DisplayName("Registration Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnForm")]
    #endif
    [IsoXmlTag("RegnForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity4Choice_? RegistrationForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity4Choice_? RegistrationForm { get; init; } 
    #else
    public FormOfSecurity4Choice_? RegistrationForm { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_AvxFgtokEeC60axPepSq7g_656152893")]
    [DisplayName("Payment Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFrqcy")]
    #endif
    [IsoXmlTag("PmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency7Choice_? PaymentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency7Choice_? PaymentFrequency { get; init; } 
    #else
    public Frequency7Choice_? PaymentFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    [IsoId("_AvxFg9okEeC60axPepSq7g_425036790")]
    [DisplayName("Variable Rate Change Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VarblRateChngFrqcy")]
    #endif
    [IsoXmlTag("VarblRateChngFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency7Choice_? VariableRateChangeFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency7Choice_? VariableRateChangeFrequency { get; init; } 
    #else
    public Frequency7Choice_? VariableRateChangeFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_AvxFhNokEeC60axPepSq7g_-1569107916")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClassificationType30Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType30Choice_? ClassificationType { get; init; } 
    #else
    public ClassificationType30Choice_? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_AvxFhdokEeC60axPepSq7g_1728787027")]
    [DisplayName("Option Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnStyle")]
    #endif
    [IsoXmlTag("OptnStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionStyle6Choice_? OptionStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionStyle6Choice_? OptionStyle { get; init; } 
    #else
    public OptionStyle6Choice_? OptionStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_AvxFhtokEeC60axPepSq7g_731714674")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType4Choice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType4Choice_? OptionType { get; init; } 
    #else
    public OptionType4Choice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_Av6PcNokEeC60axPepSq7g_-265357679")]
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
    [IsoId("_Av6PcdokEeC60axPepSq7g_-1262430032")]
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
    [IsoId("_Av6PctokEeC60axPepSq7g_2035464911")]
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
    [IsoId("_Av6Pc9okEeC60axPepSq7g_1038392558")]
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
    [IsoId("_Av6PdNokEeC60axPepSq7g_41320205")]
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
    [IsoId("_Av6PddokEeC60axPepSq7g_-955752148")]
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
    [IsoId("_AwEAcNokEeC60axPepSq7g_-1952824501")]
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
    /// Deadline by which a convertible security must be converted according to the terms of the issue.
    /// </summary>
    [IsoId("_AwEAcdokEeC60axPepSq7g_1345070442")]
    [DisplayName("Conversion Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsDt")]
    #endif
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ConversionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ConversionDate { get; init; } 
    #else
    public System.DateOnly? ConversionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_AwEActokEeC60axPepSq7g_347998089")]
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
    [IsoId("_AwEAc9okEeC60axPepSq7g_-649074264")]
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
    [IsoId("_AwEAdNokEeC60axPepSq7g_-1646146617")]
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
    /// Date on which the current factor will be changed to the next factor.
    /// </summary>
    [IsoId("_AwEAddokEeC60axPepSq7g_1651748326")]
    [DisplayName("Next Factor Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtFctrDt")]
    #endif
    [IsoXmlTag("NxtFctrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NextFactorDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NextFactorDate { get; init; } 
    #else
    public System.DateOnly? NextFactorDate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_AwEAdtokEeC60axPepSq7g_654675973")]
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
    [IsoId("_AwNxcNokEeC60axPepSq7g_-342396380")]
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
    [IsoId("_AwNxcdokEeC60axPepSq7g_-1339468733")]
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
    /// End ratio of principal outstanding to the original balance.
    /// </summary>
    [IsoId("_AwNxctokEeC60axPepSq7g_1738059996")]
    [DisplayName("End Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndFctr")]
    #endif
    [IsoXmlTag("EndFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? EndFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EndFactor { get; init; } 
    #else
    public System.Decimal? EndFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_AwNxc9okEeC60axPepSq7g_1958426210")]
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
    [IsoId("_AwNxdNokEeC60axPepSq7g_961353857")]
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
    [IsoId("_AwNxddokEeC60axPepSq7g_-35718496")]
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
    /// Percentage of the underlying assets of a fund that represents a debt and is in the scope of the EU Savings directive.
    /// </summary>
    [IsoId("_AwNxdtokEeC60axPepSq7g_598411604")]
    [DisplayName("Percentage Of Debt Claims")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgOfDebtClms")]
    #endif
    [IsoXmlTag("PctgOfDebtClms")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageOfDebtClaims { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageOfDebtClaims { get; init; } 
    #else
    public System.Decimal? PercentageOfDebtClaims { get; set; } 
    #endif
    
    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_AwW7YNokEeC60axPepSq7g_-1032790849")]
    [DisplayName("Coupon Attached Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnAttchdNb")]
    #endif
    [IsoXmlTag("CpnAttchdNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number1Choice_? CouponAttachedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number1Choice_? CouponAttachedNumber { get; init; } 
    #else
    public Number1Choice_? CouponAttachedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_AwW7YdokEeC60axPepSq7g_-2029863202")]
    [DisplayName("Pool Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolNb")]
    #endif
    [IsoXmlTag("PoolNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification37? PoolNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification37? PoolNumber { get; init; } 
    #else
    public GenericIdentification37? PoolNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number allocated by options exchanges to record that an option has undergone a change in its contract specifications (particularly adjustment of the strike price).
    /// </summary>
    [IsoId("_AwW7YtokEeC60axPepSq7g_1268031741")]
    [DisplayName("Version Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VrsnNb")]
    #endif
    [IsoXmlTag("VrsnNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number1Choice_? VersionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number1Choice_? VersionNumber { get; init; } 
    #else
    public Number1Choice_? VersionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest bearing security is convertible into another type of security.
    /// </summary>
    [IsoId("_AwW7Y9okEeC60axPepSq7g_270959388")]
    [DisplayName("Convertible Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvtblInd")]
    #endif
    [IsoXmlTag("ConvtblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConvertibleIndicator { get; init; } 
    #else
    public System.String? ConvertibleIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_AwW7ZNokEeC60axPepSq7g_1881387509")]
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
    /// Indicates whether the underlying security is owned by the writer of the entitlement.
    /// </summary>
    [IsoId("_AwW7ZdokEeC60axPepSq7g_884315156")]
    [DisplayName("Covered Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CvrdInd")]
    #endif
    [IsoXmlTag("CvrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CoveredIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CoveredIndicator { get; init; } 
    #else
    public System.String? CoveredIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_AwW7ZtokEeC60axPepSq7g_-112757197")]
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
    [IsoId("_AwgsYNokEeC60axPepSq7g_-1109829550")]
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
    /// Indicates whether the warrants on a financial instrument (which has been traded cum warrants) will be attached on delivery.
    /// </summary>
    [IsoId("_AwgsYdokEeC60axPepSq7g_-2106901903")]
    [DisplayName("Warrant Attached On Delivery")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WarrtAttchdOnDlvry")]
    #endif
    [IsoXmlTag("WarrtAttchdOnDlvry")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? WarrantAttachedOnDelivery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WarrantAttachedOnDelivery { get; init; } 
    #else
    public System.String? WarrantAttachedOnDelivery { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment of the coupon (interest) on an interest bearing instrument is off the normal schedule.
    /// </summary>
    [IsoId("_AwgsYtokEeC60axPepSq7g_1190993040")]
    [DisplayName("Odd Coupon Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OddCpnInd")]
    #endif
    [IsoXmlTag("OddCpnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OddCouponIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OddCouponIndicator { get; init; } 
    #else
    public System.String? OddCouponIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether, in the case of a debt security subject to redemption before maturity, such redemption could have an impact on the yield.
    /// </summary>
    [IsoId("_AwgsY9okEeC60axPepSq7g_2097923892")]
    [DisplayName("Redemption Yield Impact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedYldImpct")]
    #endif
    [IsoXmlTag("RedYldImpct")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RedemptionYieldImpact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RedemptionYieldImpact { get; init; } 
    #else
    public System.String? RedemptionYieldImpact { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the actual yield of an asset-backed security may vary according to the rate at which the underlying receivables or other financial assets are prepaid.
    /// </summary>
    [IsoId("_AwgsZNokEeC60axPepSq7g_-2076900783")]
    [DisplayName("Yield Variance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="YldVar")]
    #endif
    [IsoXmlTag("YldVar")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? YieldVariance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? YieldVariance { get; init; } 
    #else
    public System.String? YieldVariance { get; set; } 
    #endif
    
    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_AwgsZdokEeC60axPepSq7g_-803151666")]
    [DisplayName("Exercise Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExrcPric")]
    #endif
    [IsoXmlTag("ExrcPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price4? ExercisePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4? ExercisePrice { get; init; } 
    #else
    public Price4? ExercisePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Fixed price at which a new securities issue is being offered to the public.
    /// </summary>
    [IsoId("_Awp2UNokEeC60axPepSq7g_-1800224019")]
    [DisplayName("Subscription Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptPric")]
    #endif
    [IsoXmlTag("SbcptPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price4? SubscriptionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4? SubscriptionPrice { get; init; } 
    #else
    public Price4? SubscriptionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Price at which a given convertible security can be converted to common stock.
    /// </summary>
    [IsoId("_Awp2UdokEeC60axPepSq7g_1497670924")]
    [DisplayName("Conversion Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsPric")]
    #endif
    [IsoXmlTag("ConvsPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price4? ConversionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4? ConversionPrice { get; init; } 
    #else
    public Price4? ConversionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the Net Asset Value(NAV) that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_Awp2UtokEeC60axPepSq7g_-1089639486")]
    [DisplayName("Taxable Income Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShr")]
    #endif
    [IsoXmlTag("TaxblIncmPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price4? TaxableIncomePerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4? TaxableIncomePerShare { get; init; } 
    #else
    public Price4? TaxableIncomePerShare { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_Awp2U9okEeC60axPepSq7g_-496473782")]
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
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_Awp2VNokEeC60axPepSq7g_-1493546135")]
    [DisplayName("Minimum Exercisable Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinExrcblQty")]
    #endif
    [IsoXmlTag("MinExrcblQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_Awp2VdokEeC60axPepSq7g_1804348808")]
    [DisplayName("Minimum Exercisable Multiple Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinExrcblMltplQty")]
    #endif
    [IsoXmlTag("MinExrcblMltplQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Signed face amount and amortised value of security.
    /// </summary>
    [IsoId("_Awp2VtokEeC60axPepSq7g_807276455")]
    [DisplayName("Face Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaceAmt")]
    #endif
    [IsoXmlTag("FaceAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? FaceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? FaceAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? FaceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_AwznUNokEeC60axPepSq7g_-189795898")]
    [DisplayName("Contract Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctSz")]
    #endif
    [IsoXmlTag("CtrctSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? ContractSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? ContractSize { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? ContractSize { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    [IsoId("_AwznUdokEeC60axPepSq7g_2111026692")]
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
