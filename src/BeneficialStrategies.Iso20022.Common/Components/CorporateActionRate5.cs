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
[IsoId("_TYZdOtp-Ed-ak6NoX_4Aeg_-1791515077")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate5
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
    [IsoId("_TYjOMNp-Ed-ak6NoX_4Aeg_-1791514956")]
    [DisplayName("Additional Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTax")]
    #endif
    [IsoXmlTag("AddtlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat3Choice_? AdditionalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat3Choice_? AdditionalTax { get; init; } 
    #else
    public RateAndAmountFormat3Choice_? AdditionalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_TYjOMdp-Ed-ak6NoX_4Aeg_-1791514914")]
    [DisplayName("Charges Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsFees")]
    #endif
    [IsoXmlTag("ChrgsFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat3Choice_? ChargesFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat3Choice_? ChargesFees { get; init; } 
    #else
    public RateAndAmountFormat3Choice_? ChargesFees { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend is final.
    /// </summary>
    [IsoId("_TYjOMtp-Ed-ak6NoX_4Aeg_-1791514631")]
    [DisplayName("Final Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlDvddRate")]
    #endif
    [IsoXmlTag("FnlDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat4Choice_? FinalDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat4Choice_? FinalDividendRate { get; init; } 
    #else
    public RateAndAmountFormat4Choice_? FinalDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_TYjOM9p-Ed-ak6NoX_4Aeg_-1791514553")]
    [DisplayName("Fiscal Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclStmp")]
    #endif
    [IsoXmlTag("FsclStmp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat2Choice_? FiscalStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat2Choice_? FiscalStamp { get; init; } 
    #else
    public RateFormat2Choice_? FiscalStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; rate includes tax credit for companies that have made sufficient tax payments during fiscal period.
    /// </summary>
    [IsoId("_TYjONNp-Ed-ak6NoX_4Aeg_-1791514493")]
    [DisplayName("Fully Franked Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullyFrnkdRate")]
    #endif
    [IsoXmlTag("FullyFrnkdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat3Choice_? FullyFrankedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat3Choice_? FullyFrankedRate { get; init; } 
    #else
    public RateAndAmountFormat3Choice_? FullyFrankedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_TYjONdp-Ed-ak6NoX_4Aeg_-1791514458")]
    [DisplayName("Gross Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssDvddRate")]
    #endif
    [IsoXmlTag("GrssDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GrossDividendRateFormat1Choice_? GrossDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GrossDividendRateFormat1Choice_? GrossDividendRate { get; init; } 
    #else
    public GrossDividendRateFormat1Choice_? GrossDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.
    /// </summary>
    [IsoId("_TYjONtp-Ed-ak6NoX_4Aeg_-1791514433")]
    [DisplayName("Cash Incentive Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshIncntivRate")]
    #endif
    [IsoXmlTag("CshIncntivRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat2Choice_? CashIncentiveRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat2Choice_? CashIncentiveRate { get; init; } 
    #else
    public RateFormat2Choice_? CashIncentiveRate { get; set; } 
    #endif
    
    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_TYjON9p-Ed-ak6NoX_4Aeg_-1791514061")]
    [DisplayName("Index Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndxFctr")]
    #endif
    [IsoXmlTag("IndxFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat3Choice_? IndexFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat3Choice_? IndexFactor { get; init; } 
    #else
    public RateAndAmountFormat3Choice_? IndexFactor { get; set; } 
    #endif
    
    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_TYjOONp-Ed-ak6NoX_4Aeg_-1791514044")]
    [DisplayName("Interest Rate Used For Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRateUsdForPmt")]
    #endif
    [IsoXmlTag("IntrstRateUsdForPmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateUsedForPaymentFormat1Choice_? InterestRateUsedForPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateUsedForPaymentFormat1Choice_? InterestRateUsedForPayment { get; init; } 
    #else
    public InterestRateUsedForPaymentFormat1Choice_? InterestRateUsedForPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_TYjOOdp-Ed-ak6NoX_4Aeg_-1791513598")]
    [DisplayName("Net Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetDvddRate")]
    #endif
    [IsoXmlTag("NetDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetDividendRateFormat1Choice_? NetDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetDividendRateFormat1Choice_? NetDividendRate { get; init; } 
    #else
    public NetDividendRateFormat1Choice_? NetDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_TYsYINp-Ed-ak6NoX_4Aeg_-1791513546")]
    [DisplayName("Non Resident Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonResdtRate")]
    #endif
    [IsoXmlTag("NonResdtRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat3Choice_? NonResidentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat3Choice_? NonResidentRate { get; init; } 
    #else
    public RateAndAmountFormat3Choice_? NonResidentRate { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_TYsYIdp-Ed-ak6NoX_4Aeg_-1791513468")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAllwdOvrsbcptRate")]
    #endif
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat2Choice_? MaximumAllowedOversubscriptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat2Choice_? MaximumAllowedOversubscriptionRate { get; init; } 
    #else
    public RateFormat2Choice_? MaximumAllowedOversubscriptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend is provisional.
    /// </summary>
    [IsoId("_TYsYItp-Ed-ak6NoX_4Aeg_-1791513408")]
    [DisplayName("Provisional Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsnlDvddRate")]
    #endif
    [IsoXmlTag("PrvsnlDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat4Choice_? ProvisionalDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat4Choice_? ProvisionalDividendRate { get; init; } 
    #else
    public RateAndAmountFormat4Choice_? ProvisionalDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_TYsYI9p-Ed-ak6NoX_4Aeg_781413201")]
    [DisplayName("Tax Credit Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCdtRate")]
    #endif
    [IsoXmlTag("TaxCdtRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCreditRateFormat1Choice_? TaxCreditRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCreditRateFormat1Choice_? TaxCreditRate { get; init; } 
    #else
    public TaxCreditRateFormat1Choice_? TaxCreditRate { get; set; } 
    #endif
    
    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    [IsoId("_TYsYJNp-Ed-ak6NoX_4Aeg_-1791513156")]
    [DisplayName("Proration Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrratnRate")]
    #endif
    [IsoXmlTag("PrratnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat2Choice_? ProrationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat2Choice_? ProrationRate { get; init; } 
    #else
    public RateFormat2Choice_? ProrationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// </summary>
    [IsoId("_TYsYJdp-Ed-ak6NoX_4Aeg_-1791513096")]
    [DisplayName("Solicitation Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnFeeRate")]
    #endif
    [IsoXmlTag("SlctnFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SolicitationFeeRateFormat1Choice_? SolicitationFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SolicitationFeeRateFormat1Choice_? SolicitationFeeRate { get; init; } 
    #else
    public SolicitationFeeRateFormat1Choice_? SolicitationFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_TYsYJtp-Ed-ak6NoX_4Aeg_-1471152522")]
    [DisplayName("Early Solicitation Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlySlctnFeeRate")]
    #endif
    [IsoXmlTag("EarlySlctnFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SolicitationFeeRateFormat1Choice_? EarlySolicitationFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SolicitationFeeRateFormat1Choice_? EarlySolicitationFeeRate { get; init; } 
    #else
    public SolicitationFeeRateFormat1Choice_? EarlySolicitationFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_TYsYJ9p-Ed-ak6NoX_4Aeg_-1791513036")]
    [DisplayName("Withholding Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxRate")]
    #endif
    [IsoXmlTag("WhldgTaxRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat2Choice_? WithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat2Choice_? WithholdingTaxRate { get; init; } 
    #else
    public RateFormat2Choice_? WithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_TYsYKNp-Ed-ak6NoX_4Aeg_-1783204879")]
    [DisplayName("Tax On Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnIncm")]
    #endif
    [IsoXmlTag("TaxOnIncm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat2Choice_? TaxOnIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat2Choice_? TaxOnIncome { get; init; } 
    #else
    public RateFormat2Choice_? TaxOnIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_TYsYKdp-Ed-ak6NoX_4Aeg_-1783204854")]
    [DisplayName("Tax On Profits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnPrfts")]
    #endif
    [IsoXmlTag("TaxOnPrfts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat2Choice_? TaxOnProfits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat2Choice_? TaxOnProfits { get; init; } 
    #else
    public RateFormat2Choice_? TaxOnProfits { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_TY2JINp-Ed-ak6NoX_4Aeg_-1783204699")]
    [DisplayName("Tax Reclaim Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRclmRate")]
    #endif
    [IsoXmlTag("TaxRclmRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat2Choice_? TaxReclaimRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat2Choice_? TaxReclaimRate { get; init; } 
    #else
    public RateFormat2Choice_? TaxReclaimRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_TY2JIdp-Ed-ak6NoX_4Aeg_-1783204682")]
    [DisplayName("Withholding Of Foreign Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfFrgnTax")]
    #endif
    [IsoXmlTag("WhldgOfFrgnTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat3Choice_? WithholdingOfForeignTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat3Choice_? WithholdingOfForeignTax { get; init; } 
    #else
    public RateAndAmountFormat3Choice_? WithholdingOfForeignTax { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_TY2JItp-Ed-ak6NoX_4Aeg_-1783204647")]
    [DisplayName("Withholding Of Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfLclTax")]
    #endif
    [IsoXmlTag("WhldgOfLclTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat3Choice_? WithholdingOfLocalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat3Choice_? WithholdingOfLocalTax { get; init; } 
    #else
    public RateAndAmountFormat3Choice_? WithholdingOfLocalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_TY2JI9p-Ed-ak6NoX_4Aeg_-1783204586")]
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
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_TY2JJNp-Ed-ak6NoX_4Aeg_-1783204309")]
    [DisplayName("Applicable Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblRate")]
    #endif
    [IsoXmlTag("AplblRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat2Choice_? ApplicableRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat2Choice_? ApplicableRate { get; init; } 
    #else
    public RateFormat2Choice_? ApplicableRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
