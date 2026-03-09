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
/// Provides information about the rates related to securities movement.
/// </summary>
[IsoId("_pT3jcSePEeOXAt_43VmZGw")]
[DisplayName("Rate Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RateDetails15
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
    [IsoId("_prhOfyePEeOXAt_43VmZGw")]
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
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_prhOgSePEeOXAt_43VmZGw")]
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
    [IsoId("_prhOgyePEeOXAt_43VmZGw")]
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
    [IsoId("_prhOhSePEeOXAt_43VmZGw")]
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
    [IsoId("_prhOhyePEeOXAt_43VmZGw")]
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
    [IsoId("_prhOiSePEeOXAt_43VmZGw")]
    [DisplayName("Gross Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssDvddRate")]
    #endif
    [IsoXmlTag("GrssDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GrossDividendRateFormat8Choice_? GrossDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GrossDividendRateFormat8Choice_? GrossDividendRate { get; init; } 
    #else
    public GrossDividendRateFormat8Choice_? GrossDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_prhOiyePEeOXAt_43VmZGw")]
    [DisplayName("Early Solicitation Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlySlctnFeeRate")]
    #endif
    [IsoXmlTag("EarlySlctnFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? EarlySolicitationFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? EarlySolicitationFeeRate { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? EarlySolicitationFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer. As information, Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_prhOjSePEeOXAt_43VmZGw")]
    [DisplayName("Third Party Incentive Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrdPtyIncntivRate")]
    #endif
    [IsoXmlTag("ThrdPtyIncntivRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? ThirdPartyIncentiveRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? ThirdPartyIncentiveRate { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? ThirdPartyIncentiveRate { get; set; } 
    #endif
    
    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_prhOjyePEeOXAt_43VmZGw")]
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
    [IsoId("_prhOkSePEeOXAt_43VmZGw")]
    [DisplayName("Net Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetDvddRate")]
    #endif
    [IsoXmlTag("NetDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetDividendRateFormat10Choice_? NetDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetDividendRateFormat10Choice_? NetDividendRate { get; init; } 
    #else
    public NetDividendRateFormat10Choice_? NetDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_prhOkyePEeOXAt_43VmZGw")]
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
    /// Dividend is provisional.
    /// </summary>
    [IsoId("_prhOlSePEeOXAt_43VmZGw")]
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
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_prhOlyePEeOXAt_43VmZGw")]
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
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fee.
    /// </summary>
    [IsoId("_prhOmSePEeOXAt_43VmZGw")]
    [DisplayName("Solicitation Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnFeeRate")]
    #endif
    [IsoXmlTag("SlctnFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? SolicitationFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? SolicitationFeeRate { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? SolicitationFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_prhOmyePEeOXAt_43VmZGw")]
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
    [IsoId("_prhOnSePEeOXAt_43VmZGw")]
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
    [IsoId("_prhOnyePEeOXAt_43VmZGw")]
    [DisplayName("Withholding Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxRate")]
    #endif
    [IsoXmlTag("WhldgTaxRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat11Choice_? WithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat11Choice_? WithholdingTaxRate { get; init; } 
    #else
    public RateFormat11Choice_? WithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_prhOoSePEeOXAt_43VmZGw")]
    [DisplayName("Tax On Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnIncm")]
    #endif
    [IsoXmlTag("TaxOnIncm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? TaxOnIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? TaxOnIncome { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? TaxOnIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_prhOoyePEeOXAt_43VmZGw")]
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
    [IsoId("_prhOpSePEeOXAt_43VmZGw")]
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
    [IsoId("_prhOpyePEeOXAt_43VmZGw")]
    [DisplayName("Withholding Of Foreign Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfFrgnTax")]
    #endif
    [IsoXmlTag("WhldgOfFrgnTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat21Choice_? WithholdingOfForeignTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat21Choice_? WithholdingOfForeignTax { get; init; } 
    #else
    public RateAndAmountFormat21Choice_? WithholdingOfForeignTax { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_prhOqSePEeOXAt_43VmZGw")]
    [DisplayName("Withholding Of Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfLclTax")]
    #endif
    [IsoXmlTag("WhldgOfLclTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat21Choice_? WithholdingOfLocalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat21Choice_? WithholdingOfLocalTax { get; init; } 
    #else
    public RateAndAmountFormat21Choice_? WithholdingOfLocalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_prhOqyePEeOXAt_43VmZGw")]
    [DisplayName("Equalisation Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EqulstnRate")]
    #endif
    [IsoXmlTag("EqulstnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? EqualisationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? EqualisationRate { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? EqualisationRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
