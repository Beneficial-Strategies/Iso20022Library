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
/// Specifies rates related to a corporate action option.
/// </summary>
[IsoId("_2jgRkRK-EeKJ5uSjVyVvug")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate36
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_265d_RK-EeKJ5uSjVyVvug")]
    [DisplayName("Additional Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTax")]
    #endif
    [IsoXmlTag("AddtlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat14Choice_? AdditionalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat14Choice_? AdditionalTax { get; init; } 
    #else
    public RateAndAmountFormat14Choice_? AdditionalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_265eBxK-EeKJ5uSjVyVvug")]
    [DisplayName("Gross Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssDvddRate")]
    #endif
    [IsoXmlTag("GrssDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GrossDividendRateFormat9Choice_? GrossDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GrossDividendRateFormat9Choice_? GrossDividendRate { get; init; } 
    #else
    public GrossDividendRateFormat9Choice_? GrossDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_265eERK-EeKJ5uSjVyVvug")]
    [DisplayName("Net Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetDvddRate")]
    #endif
    [IsoXmlTag("NetDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetDividendRateFormat11Choice_? NetDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetDividendRateFormat11Choice_? NetDividendRate { get; init; } 
    #else
    public NetDividendRateFormat11Choice_? NetDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_265eFRK-EeKJ5uSjVyVvug")]
    [DisplayName("Index Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndxFctr")]
    #endif
    [IsoXmlTag("IndxFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat14Choice_? IndexFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat14Choice_? IndexFactor { get; init; } 
    #else
    public RateAndAmountFormat14Choice_? IndexFactor { get; set; } 
    #endif
    
    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_265eHxK-EeKJ5uSjVyVvug")]
    [DisplayName("Interest Rate Used For Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRateUsdForPmt")]
    #endif
    [IsoXmlTag("IntrstRateUsdForPmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateUsedForPaymentFormat5Choice_? InterestRateUsedForPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateUsedForPaymentFormat5Choice_? InterestRateUsedForPayment { get; init; } 
    #else
    public InterestRateUsedForPaymentFormat5Choice_? InterestRateUsedForPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_265eKRK-EeKJ5uSjVyVvug")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAllwdOvrsbcptRate")]
    #endif
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? MaximumAllowedOversubscriptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? MaximumAllowedOversubscriptionRate { get; init; } 
    #else
    public RateFormat6Choice_? MaximumAllowedOversubscriptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    [IsoId("_265eMxK-EeKJ5uSjVyVvug")]
    [DisplayName("Proration Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrratnRate")]
    #endif
    [IsoXmlTag("PrratnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? ProrationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? ProrationRate { get; init; } 
    #else
    public RateFormat6Choice_? ProrationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_265ePRK-EeKJ5uSjVyVvug")]
    [DisplayName("Withholding Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxRate")]
    #endif
    [IsoXmlTag("WhldgTaxRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? WithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? WithholdingTaxRate { get; init; } 
    #else
    public RateFormat6Choice_? WithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction to which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_265eRxK-EeKJ5uSjVyVvug")]
    [DisplayName("Withholding Of Foreign Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfFrgnTax")]
    #endif
    [IsoXmlTag("WhldgOfFrgnTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat14Choice_? WithholdingOfForeignTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat14Choice_? WithholdingOfForeignTax { get; init; } 
    #else
    public RateAndAmountFormat14Choice_? WithholdingOfForeignTax { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_265eSxK-EeKJ5uSjVyVvug")]
    [DisplayName("Tax Related Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRltdRate")]
    #endif
    [IsoXmlTag("TaxRltdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateTypeAndAmountAndStatus6? TaxRelatedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateTypeAndAmountAndStatus6? TaxRelatedRate { get; init; } 
    #else
    public RateTypeAndAmountAndStatus6? TaxRelatedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_265eVRK-EeKJ5uSjVyVvug")]
    [DisplayName("Taxable Income Per Dividend Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerDvddShr")]
    #endif
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateTypeAndAmountAndStatus11? TaxableIncomePerDividendShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateTypeAndAmountAndStatus11? TaxableIncomePerDividendShare { get; init; } 
    #else
    public RateTypeAndAmountAndStatus11? TaxableIncomePerDividendShare { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate (provided by the issuer) between the dividend or interest rate in the paid currency and the declared dividend or interest rate.
    /// </summary>
    [IsoId("_LF1tMBK_EeKJ5uSjVyVvug")]
    [DisplayName("Issuer Declared Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrDclrdXchgRate")]
    #endif
    [IsoXmlTag("IssrDclrdXchgRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms19? IssuerDeclaredExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms19? IssuerDeclaredExchangeRate { get; init; } 
    #else
    public ForeignExchangeTerms19? IssuerDeclaredExchangeRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
