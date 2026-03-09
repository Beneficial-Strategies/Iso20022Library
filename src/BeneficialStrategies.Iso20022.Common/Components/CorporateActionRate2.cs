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
[IsoId("_Tf_6BNp-Ed-ak6NoX_4Aeg_-532082484")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_Tf_6Bdp-Ed-ak6NoX_4Aeg_826416270")]
    [DisplayName("Withholding Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTax")]
    #endif
    [IsoXmlTag("WhldgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? WithholdingTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? WithholdingTax { get; init; } 
    #else
    public RateFormat1Choice_? WithholdingTax { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_Tf_6Btp-Ed-ak6NoX_4Aeg_826415385")]
    [DisplayName("Withholding Of Foreign Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfFrgnTax")]
    #endif
    [IsoXmlTag("WhldgOfFrgnTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? WithholdingOfForeignTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? WithholdingOfForeignTax { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? WithholdingOfForeignTax { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_Tf_6B9p-Ed-ak6NoX_4Aeg_826415755")]
    [DisplayName("Withholding Of Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfLclTax")]
    #endif
    [IsoXmlTag("WhldgOfLclTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? WithholdingOfLocalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? WithholdingOfLocalTax { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? WithholdingOfLocalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (ZAS Anrechnungsbetrag) subject to interest down payment tax (proportion of interest liable for interest down payment tax/interim profit that is not covered by the tax exempt amount).
    /// </summary>
    [IsoId("_Tf_6CNp-Ed-ak6NoX_4Aeg_826415786")]
    [DisplayName("German Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrmnLclTax1")]
    #endif
    [IsoXmlTag("GrmnLclTax1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? GermanLocalTax1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? GermanLocalTax1 { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? GermanLocalTax1 { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (ZAS Pflichtige Zinsen) interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// </summary>
    [IsoId("_TgJrANp-Ed-ak6NoX_4Aeg_826415839")]
    [DisplayName("German Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrmnLclTax2")]
    #endif
    [IsoXmlTag("GrmnLclTax2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? GermanLocalTax2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? GermanLocalTax2 { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? GermanLocalTax2 { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).
    /// </summary>
    [IsoId("_TgJrAdp-Ed-ak6NoX_4Aeg_826415900")]
    [DisplayName("German Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrmnLclTax3")]
    #endif
    [IsoXmlTag("GrmnLclTax3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? GermanLocalTax3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? GermanLocalTax3 { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? GermanLocalTax3 { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.
    /// </summary>
    [IsoId("_TgJrAtp-Ed-ak6NoX_4Aeg_826415961")]
    [DisplayName("German Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrmnLclTax4")]
    #endif
    [IsoXmlTag("GrmnLclTax4")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? GermanLocalTax4 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? GermanLocalTax4 { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? GermanLocalTax4 { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_TgJrA9p-Ed-ak6NoX_4Aeg_826416332")]
    [DisplayName("Tax On Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnIncm")]
    #endif
    [IsoXmlTag("TaxOnIncm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? TaxOnIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? TaxOnIncome { get; init; } 
    #else
    public RateFormat1Choice_? TaxOnIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_TgJrBNp-Ed-ak6NoX_4Aeg_826416393")]
    [DisplayName("Tax On Profit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnPrft")]
    #endif
    [IsoXmlTag("TaxOnPrft")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? TaxOnProfit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? TaxOnProfit { get; init; } 
    #else
    public RateFormat1Choice_? TaxOnProfit { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_TgJrBdp-Ed-ak6NoX_4Aeg_826416733")]
    [DisplayName("Tax Reclaim")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRclm")]
    #endif
    [IsoXmlTag("TaxRclm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? TaxReclaim { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? TaxReclaim { get; init; } 
    #else
    public RateFormat1Choice_? TaxReclaim { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_TgJrBtp-Ed-ak6NoX_4Aeg_826416787")]
    [DisplayName("Fiscal Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclStmp")]
    #endif
    [IsoXmlTag("FsclStmp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? FiscalStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? FiscalStamp { get; init; } 
    #else
    public RateFormat1Choice_? FiscalStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    [IsoId("_TgJrB9p-Ed-ak6NoX_4Aeg_1075572437")]
    [DisplayName("Proration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prratn")]
    #endif
    [IsoXmlTag("Prratn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? Proration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? Proration { get; init; } 
    #else
    public RateFormat1Choice_? Proration { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, eg, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_TgJrCNp-Ed-ak6NoX_4Aeg_1603231836")]
    [DisplayName("New To Old")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewToOd")]
    #endif
    [IsoXmlTag("NewToOd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat2Choice_? NewToOld { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat2Choice_? NewToOld { get; init; } 
    #else
    public RatioFormat2Choice_? NewToOld { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of new equities that will be derived by the exercise of a given quantity of intermediate securities.
    /// </summary>
    [IsoId("_TgJrCdp-Ed-ak6NoX_4Aeg_1603231845")]
    [DisplayName("New Securities To Underlying Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewSctiesToUndrlygScties")]
    #endif
    [IsoXmlTag("NewSctiesToUndrlygScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat2Choice_? NewSecuritiesToUnderlyingSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat2Choice_? NewSecuritiesToUnderlyingSecurities { get; init; } 
    #else
    public RatioFormat2Choice_? NewSecuritiesToUnderlyingSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, eg, 1 for 1: 1 new|equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_TgS08Np-Ed-ak6NoX_4Aeg_1603231867")]
    [DisplayName("Additional Quantity For Existing Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlQtyForExstgScties")]
    #endif
    [IsoXmlTag("AddtlQtyForExstgScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat1Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat1Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    #else
    public RatioFormat1Choice_? AdditionalQuantityForExistingSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_TgS08dp-Ed-ak6NoX_4Aeg_1603231897")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlQtyForSbcbdRsltntScties")]
    #endif
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat1Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat1Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    #else
    public RatioFormat1Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_TgS08tp-Ed-ak6NoX_4Aeg_1114601396")]
    [DisplayName("Related Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdTax")]
    #endif
    [IsoXmlTag("RltdTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RelatedTaxType1? RelatedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RelatedTaxType1? RelatedTax { get; init; } 
    #else
    public RelatedTaxType1? RelatedTax { get; set; } 
    #endif
    
    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_TgS089p-Ed-ak6NoX_4Aeg_-1218810199")]
    [DisplayName("Non Resident Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonResdtRate")]
    #endif
    [IsoXmlTag("NonResdtRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? NonResidentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? NonResidentRate { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? NonResidentRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_TgS09Np-Ed-ak6NoX_4Aeg_-1017726643")]
    [DisplayName("Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrgs")]
    #endif
    [IsoXmlTag("Chrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? Charges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? Charges { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? Charges { get; set; } 
    #endif
    
    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_TgS09dp-Ed-ak6NoX_4Aeg_32788550")]
    [DisplayName("Interest For Used Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstForUsdPmt")]
    #endif
    [IsoXmlTag("IntrstForUsdPmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? InterestForUsedPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? InterestForUsedPayment { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? InterestForUsedPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_TgS09tp-Ed-ak6NoX_4Aeg_192556704")]
    [DisplayName("Index Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndxFctr")]
    #endif
    [IsoXmlTag("IndxFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? IndexFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? IndexFactor { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? IndexFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; rate includes tax credit for companies that have made sufficient tax payments during fiscal period.
    /// </summary>
    [IsoId("_TgS099p-Ed-ak6NoX_4Aeg_1674113782")]
    [DisplayName("Fully Franked")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullyFrnkd")]
    #endif
    [IsoXmlTag("FullyFrnkd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? FullyFranked { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? FullyFranked { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? FullyFranked { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_TgS0-Np-Ed-ak6NoX_4Aeg_1674114207")]
    [DisplayName("Gross Dividend")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssDvdd")]
    #endif
    [IsoXmlTag("GrssDvdd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GrossDividendRate1Choice_? GrossDividend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GrossDividendRate1Choice_? GrossDividend { get; init; } 
    #else
    public GrossDividendRate1Choice_? GrossDividend { get; set; } 
    #endif
    
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_TgS0-dp-Ed-ak6NoX_4Aeg_-852869139")]
    [DisplayName("Net Dividend")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetDvdd")]
    #endif
    [IsoXmlTag("NetDvdd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetDividendRate1Choice_? NetDividend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetDividendRate1Choice_? NetDividend { get; init; } 
    #else
    public NetDividendRate1Choice_? NetDividend { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend is final.
    /// </summary>
    [IsoId("_Tgcl8Np-Ed-ak6NoX_4Aeg_1093913528")]
    [DisplayName("Final Dividend")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlDvdd")]
    #endif
    [IsoXmlTag("FnlDvdd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndRateFormat2Choice_? FinalDividend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndRateFormat2Choice_? FinalDividend { get; init; } 
    #else
    public AmountAndRateFormat2Choice_? FinalDividend { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend is provisional.
    /// </summary>
    [IsoId("_Tgcl8dp-Ed-ak6NoX_4Aeg_1507650520")]
    [DisplayName("Provisional Dividend")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsnlDvdd")]
    #endif
    [IsoXmlTag("PrvsnlDvdd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndRateFormat2Choice_? ProvisionalDividend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndRateFormat2Choice_? ProvisionalDividend { get; init; } 
    #else
    public AmountAndRateFormat2Choice_? ProvisionalDividend { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, e.g. consent fees.
    /// </summary>
    [IsoId("_Tgcl8tp-Ed-ak6NoX_4Aeg_2061068045")]
    [DisplayName("Cash Incentive")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshIncntiv")]
    #endif
    [IsoXmlTag("CshIncntiv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? CashIncentive { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? CashIncentive { get; init; } 
    #else
    public RateFormat1Choice_? CashIncentive { get; set; } 
    #endif
    
    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// </summary>
    [IsoId("_Tgcl89p-Ed-ak6NoX_4Aeg_1708651176")]
    [DisplayName("Solicitation Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnFee")]
    #endif
    [IsoXmlTag("SlctnFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? SolicitationFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? SolicitationFee { get; init; } 
    #else
    public RateFormat1Choice_? SolicitationFee { get; set; } 
    #endif
    
    /// <summary>
    /// A maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, eg, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50%.
    /// </summary>
    [IsoId("_Tgcl9Np-Ed-ak6NoX_4Aeg_-1566749496")]
    [DisplayName("Maximum Allowed Oversubscription")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAllwdOvrsbcpt")]
    #endif
    [IsoXmlTag("MaxAllwdOvrsbcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? MaximumAllowedOversubscription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? MaximumAllowedOversubscription { get; init; } 
    #else
    public RateFormat1Choice_? MaximumAllowedOversubscription { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_Tgcl9dp-Ed-ak6NoX_4Aeg_826416240")]
    [DisplayName("Additional Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTax")]
    #endif
    [IsoXmlTag("AddtlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? AdditionalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? AdditionalTax { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? AdditionalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_Tgcl9tp-Ed-ak6NoX_4Aeg_970763826")]
    [DisplayName("Original Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAmt")]
    #endif
    [IsoXmlTag("OrgnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? OriginalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about a foreign exchange.
    /// </summary>
    [IsoId("_Tgcl99p-Ed-ak6NoX_4Aeg_250066085")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms8? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms8? ExchangeRate { get; init; } 
    #else
    public ForeignExchangeTerms8? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate applicable to the event announced, eg, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_Tgcl-Np-Ed-ak6NoX_4Aeg_-745146054")]
    [DisplayName("Applicable Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblRate")]
    #endif
    [IsoXmlTag("AplblRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? ApplicableRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? ApplicableRate { get; init; } 
    #else
    public RateFormat1Choice_? ApplicableRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
