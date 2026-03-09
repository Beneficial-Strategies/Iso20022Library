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
/// Specifies rates.
/// </summary>
[IsoId("_TXEAddp-Ed-ak6NoX_4Aeg_-525646890")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_TXEAdtp-Ed-ak6NoX_4Aeg_-525646490")]
    [DisplayName("Charges Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsFees")]
    #endif
    [IsoXmlTag("ChrgsFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? ChargesFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? ChargesFees { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? ChargesFees { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend is final.
    /// </summary>
    [IsoId("_TXNKYNp-Ed-ak6NoX_4Aeg_-525646459")]
    [DisplayName("Final Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlDvddRate")]
    #endif
    [IsoXmlTag("FnlDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? FinalDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? FinalDividendRate { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? FinalDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_TXNKYdp-Ed-ak6NoX_4Aeg_-525646398")]
    [DisplayName("Fiscal Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclStmp")]
    #endif
    [IsoXmlTag("FsclStmp")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? FiscalStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FiscalStamp { get; init; } 
    #else
    public System.Decimal? FiscalStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; rate includes tax credit for companies that have made sufficient tax payments during fiscal period.
    /// </summary>
    [IsoId("_TXNKYtp-Ed-ak6NoX_4Aeg_-524726403")]
    [DisplayName("Fully Franked Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullyFrnkdRate")]
    #endif
    [IsoXmlTag("FullyFrnkdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? FullyFrankedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? FullyFrankedRate { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? FullyFrankedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_TXNKY9p-Ed-ak6NoX_4Aeg_-524726373")]
    [DisplayName("Gross Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssDvddRate")]
    #endif
    [IsoXmlTag("GrssDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GrossDividendRateFormat2Choice_? GrossDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GrossDividendRateFormat2Choice_? GrossDividendRate { get; init; } 
    #else
    public GrossDividendRateFormat2Choice_? GrossDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.
    /// </summary>
    [IsoId("_TXNKZNp-Ed-ak6NoX_4Aeg_-524726342")]
    [DisplayName("Cash Incentive Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshIncntivRate")]
    #endif
    [IsoXmlTag("CshIncntivRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? CashIncentiveRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CashIncentiveRate { get; init; } 
    #else
    public System.Decimal? CashIncentiveRate { get; set; } 
    #endif
    
    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_TXNKZdp-Ed-ak6NoX_4Aeg_-524726341")]
    [DisplayName("Index Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndxFctr")]
    #endif
    [IsoXmlTag("IndxFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? IndexFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? IndexFactor { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? IndexFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_TXNKZtp-Ed-ak6NoX_4Aeg_-524726311")]
    [DisplayName("Interest Rate Used For Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRateUsdForPmt")]
    #endif
    [IsoXmlTag("IntrstRateUsdForPmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateUsedForPaymentFormat2Choice_? InterestRateUsedForPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateUsedForPaymentFormat2Choice_? InterestRateUsedForPayment { get; init; } 
    #else
    public InterestRateUsedForPaymentFormat2Choice_? InterestRateUsedForPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_TXNKZ9p-Ed-ak6NoX_4Aeg_-524726158")]
    [DisplayName("Net Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetDvddRate")]
    #endif
    [IsoXmlTag("NetDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetDividendRateFormat2Choice_? NetDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetDividendRateFormat2Choice_? NetDividendRate { get; init; } 
    #else
    public NetDividendRateFormat2Choice_? NetDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_TXNKaNp-Ed-ak6NoX_4Aeg_-524726128")]
    [DisplayName("Non Resident Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonResdtRate")]
    #endif
    [IsoXmlTag("NonResdtRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? NonResidentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? NonResidentRate { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? NonResidentRate { get; set; } 
    #endif
    
    /// <summary>
    /// A maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_TXNKadp-Ed-ak6NoX_4Aeg_-524725849")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAllwdOvrsbcptRate")]
    #endif
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? MaximumAllowedOversubscriptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MaximumAllowedOversubscriptionRate { get; init; } 
    #else
    public System.Decimal? MaximumAllowedOversubscriptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend is provisional.
    /// </summary>
    [IsoId("_TXW7YNp-Ed-ak6NoX_4Aeg_-524725819")]
    [DisplayName("Provisional Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsnlDvddRate")]
    #endif
    [IsoXmlTag("PrvsnlDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? ProvisionalDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? ProvisionalDividendRate { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? ProvisionalDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    [IsoId("_TXW7Ydp-Ed-ak6NoX_4Aeg_-524725788")]
    [DisplayName("Proration Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrratnRate")]
    #endif
    [IsoXmlTag("PrratnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ProrationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ProrationRate { get; init; } 
    #else
    public System.Decimal? ProrationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// </summary>
    [IsoId("_TXW7Ytp-Ed-ak6NoX_4Aeg_-524725787")]
    [DisplayName("Solicitation Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnFeeRate")]
    #endif
    [IsoXmlTag("SlctnFeeRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? SolicitationFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SolicitationFeeRate { get; init; } 
    #else
    public System.Decimal? SolicitationFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_TXW7Y9p-Ed-ak6NoX_4Aeg_361018486")]
    [DisplayName("Tax Credit Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCdtRate")]
    #endif
    [IsoXmlTag("TaxCdtRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCreditRateFormat2Choice_? TaxCreditRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCreditRateFormat2Choice_? TaxCreditRate { get; init; } 
    #else
    public TaxCreditRateFormat2Choice_? TaxCreditRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_TXW7ZNp-Ed-ak6NoX_4Aeg_-524725326")]
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
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_TXW7Zdp-Ed-ak6NoX_4Aeg_-524725757")]
    [DisplayName("Withholding Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxRate")]
    #endif
    [IsoXmlTag("WhldgTaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? WithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? WithholdingTaxRate { get; init; } 
    #else
    public System.Decimal? WithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_TXW7Ztp-Ed-ak6NoX_4Aeg_-524725727")]
    [DisplayName("Tax On Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnIncm")]
    #endif
    [IsoXmlTag("TaxOnIncm")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxOnIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxOnIncome { get; init; } 
    #else
    public System.Decimal? TaxOnIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_TXW7Z9p-Ed-ak6NoX_4Aeg_-524725448")]
    [DisplayName("Tax On Profits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnPrfts")]
    #endif
    [IsoXmlTag("TaxOnPrfts")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxOnProfits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxOnProfits { get; init; } 
    #else
    public System.Decimal? TaxOnProfits { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_TXW7aNp-Ed-ak6NoX_4Aeg_-524725418")]
    [DisplayName("Tax Reclaim Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRclmRate")]
    #endif
    [IsoXmlTag("TaxRclmRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxReclaimRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxReclaimRate { get; init; } 
    #else
    public System.Decimal? TaxReclaimRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_TXW7adp-Ed-ak6NoX_4Aeg_-524725387")]
    [DisplayName("Withholding Of Foreign Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfFrgnTax")]
    #endif
    [IsoXmlTag("WhldgOfFrgnTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? WithholdingOfForeignTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? WithholdingOfForeignTax { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? WithholdingOfForeignTax { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_TXgFUNp-Ed-ak6NoX_4Aeg_-524725356")]
    [DisplayName("Withholding Of Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfLclTax")]
    #endif
    [IsoXmlTag("WhldgOfLclTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? WithholdingOfLocalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? WithholdingOfLocalTax { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? WithholdingOfLocalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_TXgFUdp-Ed-ak6NoX_4Aeg_-525646768")]
    [DisplayName("Additional Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTax")]
    #endif
    [IsoXmlTag("AddtlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? AdditionalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? AdditionalTax { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? AdditionalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_TXgFUtp-Ed-ak6NoX_4Aeg_-524725295")]
    [DisplayName("Applicable Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblRate")]
    #endif
    [IsoXmlTag("AplblRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ApplicableRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ApplicableRate { get; init; } 
    #else
    public System.Decimal? ApplicableRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
