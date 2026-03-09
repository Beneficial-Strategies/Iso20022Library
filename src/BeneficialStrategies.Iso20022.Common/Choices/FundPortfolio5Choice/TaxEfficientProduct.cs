// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio5Choice
{
    /// <summary>
    /// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt &apos;wrappers&apos; in which equities, bonds and funds can be held to shelter them from various types of tax.
    /// In the UK, a typical tax wrapper product is known as an &apos;ISA&apos; (Individual Savings Account).
    /// </summary>
    [IsoId("_nxCyoZNMEemQB_8XA98K0Q")]
    [DisplayName("Tax Efficient Product")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TaxEfficientProduct : FundPortfolio5Choice_
    #else
    public partial class TaxEfficientProduct : FundPortfolio5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TaxEfficientProduct instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TaxEfficientProduct( TaxEfficientProductType2Choice_ reqTaxEfficientProductType )
        {
            TaxEfficientProductType = reqTaxEfficientProductType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
        /// </summary>
        [IsoId("_alOcI5NNEemQB_8XA98K0Q")]
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
        [IsoId("_mgyu4ZNQEemQB_8XA98K0Q")]
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
        [IsoId("_alOcJZNNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcJ5NNEemQB_8XA98K0Q")]
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
        [IsoId("_Z0BH4DOOEeqjy7_SkdcoGg")]
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
        [IsoId("_eKOTIDOOEeqjy7_SkdcoGg")]
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
        [IsoId("_alOcKZNNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcK5NNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcLZNNEemQB_8XA98K0Q")]
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
        /// Alternative identification for the transferor (ceding party), for example, the &apos;ISA manager Z reference&apos; in the UK. 
        /// </summary>
        [IsoId("__u1BEJzGEembF9M4GR6EAA")]
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
        [IsoId("_Jm9j0JzHEembF9M4GR6EAA")]
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
        [IsoId("_kEJ0UJzHEembF9M4GR6EAA")]
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
        [IsoId("_CtM9UDOOEeqjy7_SkdcoGg")]
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
        [IsoId("_alOcL5NNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcMZNNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcM5NNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcNZNNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcN5NNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcOZNNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcO5NNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcPZNNEemQB_8XA98K0Q")]
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
        [IsoId("_alOcP5NNEemQB_8XA98K0Q")]
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
}
