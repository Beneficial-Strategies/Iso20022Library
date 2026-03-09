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
[IsoId("_ORdmwOsgEd-b_I-JAnHTUQ")]
[DisplayName("Rate Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RateDetails3
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
    [IsoId("_T1lWoesgEd-b_I-JAnHTUQ")]
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
    [IsoId("_o8yZ4esgEd-b_I-JAnHTUQ")]
    [DisplayName("Gross Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssDvddRate")]
    #endif
    [IsoXmlTag("GrssDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GrossDividendRateFormat5Choice_? GrossDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GrossDividendRateFormat5Choice_? GrossDividendRate { get; init; } 
    #else
    public GrossDividendRateFormat5Choice_? GrossDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_rgGEIesgEd-b_I-JAnHTUQ")]
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
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_vShz8esgEd-b_I-JAnHTUQ")]
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
    [IsoId("_xsdfwesgEd-b_I-JAnHTUQ")]
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
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_B-T2cOtJEd-PFJLHKom6FA")]
    [DisplayName("Charges Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsFees")]
    #endif
    [IsoXmlTag("ChrgsFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat14Choice_? ChargesFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat14Choice_? ChargesFees { get; init; } 
    #else
    public RateAndAmountFormat14Choice_? ChargesFees { get; set; } 
    #endif
    
    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_LqUowOtJEd-PFJLHKom6FA")]
    [DisplayName("Early Solicitation Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlySlctnFeeRate")]
    #endif
    [IsoXmlTag("EarlySlctnFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SolicitationFeeRateFormat3Choice_? EarlySolicitationFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SolicitationFeeRateFormat3Choice_? EarlySolicitationFeeRate { get; init; } 
    #else
    public SolicitationFeeRateFormat3Choice_? EarlySolicitationFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend is final.
    /// </summary>
    [IsoId("_NcmesOtJEd-PFJLHKom6FA")]
    [DisplayName("Final Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlDvddRate")]
    #endif
    [IsoXmlTag("FnlDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat15Choice_? FinalDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat15Choice_? FinalDividendRate { get; init; } 
    #else
    public RateAndAmountFormat15Choice_? FinalDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_PJO_oOtJEd-PFJLHKom6FA")]
    [DisplayName("Fiscal Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclStmp")]
    #endif
    [IsoXmlTag("FsclStmp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? FiscalStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? FiscalStamp { get; init; } 
    #else
    public RateFormat6Choice_? FiscalStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; rate includes tax credit for companies that have made sufficient tax payments during fiscal period.
    /// </summary>
    [IsoId("_RX-vIOtJEd-PFJLHKom6FA")]
    [DisplayName("Fully Franked Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullyFrnkdRate")]
    #endif
    [IsoXmlTag("FullyFrnkdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat14Choice_? FullyFrankedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat14Choice_? FullyFrankedRate { get; init; } 
    #else
    public RateAndAmountFormat14Choice_? FullyFrankedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.
    /// </summary>
    [IsoId("_ThNsgOtJEd-PFJLHKom6FA")]
    [DisplayName("Cash Incentive Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshIncntivRate")]
    #endif
    [IsoXmlTag("CshIncntivRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? CashIncentiveRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? CashIncentiveRate { get; init; } 
    #else
    public RateFormat6Choice_? CashIncentiveRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_U8QHIOtJEd-PFJLHKom6FA")]
    [DisplayName("Net Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetDvddRate")]
    #endif
    [IsoXmlTag("NetDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetDividendRateFormat5Choice_? NetDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetDividendRateFormat5Choice_? NetDividendRate { get; init; } 
    #else
    public NetDividendRateFormat5Choice_? NetDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_WKCI4OtJEd-PFJLHKom6FA")]
    [DisplayName("Non Resident Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonResdtRate")]
    #endif
    [IsoXmlTag("NonResdtRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat14Choice_? NonResidentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat14Choice_? NonResidentRate { get; init; } 
    #else
    public RateAndAmountFormat14Choice_? NonResidentRate { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend is provisional.
    /// </summary>
    [IsoId("_YczcwOtJEd-PFJLHKom6FA")]
    [DisplayName("Provisional Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsnlDvddRate")]
    #endif
    [IsoXmlTag("PrvsnlDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat15Choice_? ProvisionalDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat15Choice_? ProvisionalDividendRate { get; init; } 
    #else
    public RateAndAmountFormat15Choice_? ProvisionalDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_ZvfzsOtJEd-PFJLHKom6FA")]
    [DisplayName("Applicable Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblRate")]
    #endif
    [IsoXmlTag("AplblRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? ApplicableRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? ApplicableRate { get; init; } 
    #else
    public RateFormat6Choice_? ApplicableRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// </summary>
    [IsoId("_bU0ywOtJEd-PFJLHKom6FA")]
    [DisplayName("Solicitation Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnFeeRate")]
    #endif
    [IsoXmlTag("SlctnFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SolicitationFeeRateFormat3Choice_? SolicitationFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SolicitationFeeRateFormat3Choice_? SolicitationFeeRate { get; init; } 
    #else
    public SolicitationFeeRateFormat3Choice_? SolicitationFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_c076oOtJEd-PFJLHKom6FA")]
    [DisplayName("Tax Credit Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCdtRate")]
    #endif
    [IsoXmlTag("TaxCdtRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCreditRateFormat5Choice_? TaxCreditRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCreditRateFormat5Choice_? TaxCreditRate { get; init; } 
    #else
    public TaxCreditRateFormat5Choice_? TaxCreditRate { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_eOVWgOtJEd-PFJLHKom6FA")]
    [DisplayName("Tax On Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnIncm")]
    #endif
    [IsoXmlTag("TaxOnIncm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? TaxOnIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? TaxOnIncome { get; init; } 
    #else
    public RateFormat6Choice_? TaxOnIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_fKF0IOtJEd-PFJLHKom6FA")]
    [DisplayName("Tax On Profits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnPrfts")]
    #endif
    [IsoXmlTag("TaxOnPrfts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? TaxOnProfits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? TaxOnProfits { get; init; } 
    #else
    public RateFormat6Choice_? TaxOnProfits { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_gNlRcOtJEd-PFJLHKom6FA")]
    [DisplayName("Tax Reclaim Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRclmRate")]
    #endif
    [IsoXmlTag("TaxRclmRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? TaxReclaimRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? TaxReclaimRate { get; init; } 
    #else
    public RateFormat6Choice_? TaxReclaimRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_hNgdYOtJEd-PFJLHKom6FA")]
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
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_iTPWYOtJEd-PFJLHKom6FA")]
    [DisplayName("Withholding Of Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfLclTax")]
    #endif
    [IsoXmlTag("WhldgOfLclTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat14Choice_? WithholdingOfLocalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat14Choice_? WithholdingOfLocalTax { get; init; } 
    #else
    public RateAndAmountFormat14Choice_? WithholdingOfLocalTax { get; set; } 
    #endif
    
    
    #nullable disable
    
}
