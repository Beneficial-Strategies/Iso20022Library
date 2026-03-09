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
/// Characteristics of a tax efficient product.
/// </summary>
[IsoId("_X-C5J-lfEeu9cf4XM82AQQ")]
[DisplayName("Tax Efficient Product")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxEfficientProduct7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxEfficientProduct7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxEfficientProduct7( TaxEfficientProductType2Choice_ reqTaxEfficientProductType )
    {
        TaxEfficientProductType = reqTaxEfficientProductType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    [IsoId("_YUPyo-lfEeu9cf4XM82AQQ")]
    [DisplayName("Tax Efficient Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxEffcntPdctTp")]
    #endif
    [IsoXmlTag("TaxEffcntPdctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
    #else
    public TaxEfficientProductType2Choice_ TaxEfficientProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that all the current fiscal year’s products are included.
    /// </summary>
    [IsoId("_YUPypelfEeu9cf4XM82AQQ")]
    [DisplayName("Current Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYr")]
    #endif
    [IsoXmlTag("CurYr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CurrentYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CurrentYear { get; init; } 
    #else
    public System.String? CurrentYear { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether, for the current year, the product contains a cash asset for transfer.
    /// </summary>
    [IsoId("_YUPyp-lfEeu9cf4XM82AQQ")]
    [DisplayName("Cash Component Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCmpntInd")]
    #endif
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CashComponentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashComponentIndicator { get; init; } 
    #else
    public System.String? CashComponentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    [IsoId("_YUPyqelfEeu9cf4XM82AQQ")]
    [DisplayName("Previous Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYrs")]
    #endif
    [IsoXmlTag("PrvsYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreviousYear4? PreviousYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreviousYear4? PreviousYears { get; init; } 
    #else
    public PreviousYear4? PreviousYears { get; set; } 
    #endif
    
    /// <summary>
    /// Subscriptions from the previous subscription year.
    /// </summary>
    [IsoId("_YUPyq-lfEeu9cf4XM82AQQ")]
    [DisplayName("Previous Year Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYrSbcptAmt")]
    #endif
    [IsoXmlTag("PrvsYrSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? PreviousYearSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? PreviousYearSubscriptionAmount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? PreviousYearSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount subscribed in all previous years.
    /// </summary>
    [IsoId("_YUPyrelfEeu9cf4XM82AQQ")]
    [DisplayName("Previous Years Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYrsSbcptAmt")]
    #endif
    [IsoXmlTag("PrvsYrsSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? PreviousYearsSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? PreviousYearsSubscriptionAmount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? PreviousYearsSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investment plan started.
    /// </summary>
    [IsoId("_YUPyr-lfEeu9cf4XM82AQQ")]
    [DisplayName("Date Of First Subscription")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfFrstSbcpt")]
    #endif
    [IsoXmlTag("DtOfFrstSbcpt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateOfFirstSubscription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateOfFirstSubscription { get; init; } 
    #else
    public System.DateOnly? DateOfFirstSubscription { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_YUPyselfEeu9cf4XM82AQQ")]
    [DisplayName("Current Year Subscription Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYrSbcptDtls")]
    #endif
    [IsoXmlTag("CurYrSbcptDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; } 
    #else
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Bonus paid out or withdrawn.
    /// </summary>
    [IsoId("_YUPys-lfEeu9cf4XM82AQQ")]
    [DisplayName("Bonus Or Withdrawal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnsOrWdrwl")]
    #endif
    [IsoXmlTag("BnsOrWdrwl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BonusWithdrawal2? BonusOrWithdrawal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BonusWithdrawal2? BonusOrWithdrawal { get; init; } 
    #else
    public BonusWithdrawal2? BonusOrWithdrawal { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if there is a related property purchase in progress at the point of transfer. May be applicable to products such as Lifetime Individual Savings Account (LISA) products.
    /// </summary>
    [IsoId("_wUjxAOlfEeu9cf4XM82AQQ")]
    [DisplayName("Withdrawal For Residential Purchase Progress")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlForResdtlPurchsPrgrs")]
    #endif
    [IsoXmlTag("WdrwlForResdtlPurchsPrgrs")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? WithdrawalForResidentialPurchaseProgress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WithdrawalForResidentialPurchaseProgress { get; init; } 
    #else
    public System.String? WithdrawalForResidentialPurchaseProgress { get; set; } 
    #endif
    
    /// <summary>
    /// Alternative identification for the transferor (ceding party), for example, the &apos;ISA manager Z reference&apos; in the UK. 
    /// </summary>
    [IsoId("_YUPytelfEeu9cf4XM82AQQ")]
    [DisplayName("Transferor Alternate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfrAltrnId")]
    #endif
    [IsoXmlTag("TrfrAltrnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransferorAlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferorAlternateIdentification { get; init; } 
    #else
    public System.String? TransferorAlternateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount subscribed over the lifetime of the product.
    /// </summary>
    [IsoId("_YUPyt-lfEeu9cf4XM82AQQ")]
    [DisplayName("Total Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSbcptAmt")]
    #endif
    [IsoXmlTag("TtlSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Another amount such as the total qualifying additions in the year of transfer, interest capitalised in the current year, total outstanding dividend and so on.
    /// </summary>
    [IsoId("_YUPyuelfEeu9cf4XM82AQQ")]
    [DisplayName("Other Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAmt")]
    #endif
    [IsoXmlTag("OthrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAmount3? OtherAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAmount3? OtherAmount { get; init; } 
    #else
    public OtherAmount3? OtherAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date the first qualifying additional amount was made to the product.  Qualifying additional amounts may be made to a Lifetime Individual Savings Account (LISA) product.
    /// </summary>
    [IsoId("_YUPyu-lfEeu9cf4XM82AQQ")]
    [DisplayName("Date First Qualifying Addition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtFrstQlfygAddtn")]
    #endif
    [IsoXmlTag("DtFrstQlfygAddtn")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateFirstQualifyingAddition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateFirstQualifyingAddition { get; init; } 
    #else
    public System.DateOnly? DateFirstQualifyingAddition { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the investor as assigned by a tax authority. 
    /// </summary>
    [IsoId("_YUPyvelfEeu9cf4XM82AQQ")]
    [DisplayName("Investor Tax Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrTaxRef")]
    #endif
    [IsoXmlTag("InvstrTaxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxReference2? InvestorTaxReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReference2? InvestorTaxReference { get; init; } 
    #else
    public TaxReference2? InvestorTaxReference { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the investments to follow.
    /// </summary>
    [IsoId("_YUPyv-lfEeu9cf4XM82AQQ")]
    [DisplayName("Investments To Follow Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtsToFllwVal")]
    #endif
    [IsoXmlTag("InvstmtsToFllwVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? InvestmentsToFollowValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? InvestmentsToFollowValue { get; init; } 
    #else
    public DateAndAmount2? InvestmentsToFollowValue { get; set; } 
    #endif
    
    /// <summary>
    /// Information about an innovative finance product.
    /// </summary>
    [IsoId("_YUPywelfEeu9cf4XM82AQQ")]
    [DisplayName("Innovative Finance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InnvtvFinc")]
    #endif
    [IsoXmlTag("InnvtvFinc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InnovativeFinance1? InnovativeFinance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InnovativeFinance1? InnovativeFinance { get; init; } 
    #else
    public InnovativeFinance1? InnovativeFinance { get; set; } 
    #endif
    
    /// <summary>
    /// Lowest investment amount in the current year, used to calculate a tax deduction amount.
    /// </summary>
    [IsoId("_YUPyw-lfEeu9cf4XM82AQQ")]
    [DisplayName("Lowest Invested Amount Current Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LwstInvstdAmtCurYr")]
    #endif
    [IsoXmlTag("LwstInvstdAmtCurYr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? LowestInvestedAmountCurrentYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? LowestInvestedAmountCurrentYear { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? LowestInvestedAmountCurrentYear { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money from which the tax deduction is calculated. 
    /// </summary>
    [IsoId("_YUPyxelfEeu9cf4XM82AQQ")]
    [DisplayName("Tax Calculation Base")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxClctnBase")]
    #endif
    [IsoXmlTag("TaxClctnBase")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? TaxCalculationBase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? TaxCalculationBase { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? TaxCalculationBase { get; set; } 
    #endif
    
    /// <summary>
    /// Unused tax deduction amount.
    /// </summary>
    [IsoId("_YUPyx-lfEeu9cf4XM82AQQ")]
    [DisplayName("Unused Tax Deduction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UusdTaxDdctn")]
    #endif
    [IsoXmlTag("UusdTaxDdctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? UnusedTaxDeduction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? UnusedTaxDeduction { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? UnusedTaxDeduction { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money invested.
    /// </summary>
    [IsoId("_YUPyyelfEeu9cf4XM82AQQ")]
    [DisplayName("Current Investment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurInvstmtAmt")]
    #endif
    [IsoXmlTag("CurInvstmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated value of the assets of the tax efficient product to be transferred.
    /// </summary>
    [IsoId("_YUPyy-lfEeu9cf4XM82AQQ")]
    [DisplayName("Estimated Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdVal")]
    #endif
    [IsoXmlTag("EstmtdVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? EstimatedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? EstimatedValue { get; init; } 
    #else
    public DateAndAmount2? EstimatedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    [IsoId("_YUPyzelfEeu9cf4XM82AQQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
