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
/// Provides the elements related to the interest amount calculation.
/// </summary>
[IsoId("_Oz1hcStMEeyOa655cLd-DQ")]
[DisplayName("Interest Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestAmount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InterestAmount3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestAmount3( ActiveCurrencyAndAmount reqAccruedInterestAmount,DateAndDateTime2Choice_ reqValueDate,InterestMethod1Code reqInterestMethod,DatePeriod2 reqInterestPeriod,CollateralPurpose1Choice_ reqCollateralPurpose,CollateralBalance1 reqClosingCollateralBalance )
    {
        AccruedInterestAmount = reqAccruedInterestAmount;
        ValueDate = reqValueDate;
        InterestMethod = reqInterestMethod;
        InterestPeriod = reqInterestPeriod;
        CollateralPurpose = reqCollateralPurpose;
        ClosingCollateralBalance = reqClosingCollateralBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_PN61YStMEeyOa655cLd-DQ")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Agreed date for the interest payment.
    /// </summary>
    [IsoId("_PN61YytMEeyOa655cLd-DQ")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ ValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ ValueDate { get; init; } 
    #else
    public DateAndDateTime2Choice_ ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest will be settled in cash or rolled in the existing collateral balance.
    /// </summary>
    [IsoId("_PN61ZStMEeyOa655cLd-DQ")]
    [DisplayName("Interest Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstMtd")]
    #endif
    [IsoXmlTag("IntrstMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestMethod1Code InterestMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestMethod1Code InterestMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestMethod1Code InterestMethod { get; init; } 
    #else
    public InterestMethod1Code InterestMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Period for which the calculation has been performed.
    /// </summary>
    [IsoId("_PN61ZytMEeyOa655cLd-DQ")]
    [DisplayName("Interest Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPrd")]
    #endif
    [IsoXmlTag("IntrstPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DatePeriod2 InterestPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DatePeriod2 InterestPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod2 InterestPeriod { get; init; } 
    #else
    public DatePeriod2 InterestPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_PN61aStMEeyOa655cLd-DQ")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRate1Choice_? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate1Choice_? InterestRate { get; init; } 
    #else
    public InterestRate1Choice_? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_PN61aytMEeyOa655cLd-DQ")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethod2Code? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethod2Code? DayCountBasis { get; init; } 
    #else
    public InterestComputationMethod2Code? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Amount or percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_PN61bStMEeyOa655cLd-DQ")]
    [DisplayName("Applied Withholding Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApldWhldgTax")]
    #endif
    [IsoXmlTag("ApldWhldgTax")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AppliedWithholdingTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AppliedWithholdingTax { get; init; } 
    #else
    public System.String? AppliedWithholdingTax { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the interest is simple or compounded.
    /// </summary>
    [IsoId("_PN61bytMEeyOa655cLd-DQ")]
    [DisplayName("Calculation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnMtd")]
    #endif
    [IsoXmlTag("ClctnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CalculationMethod1Code? CalculationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CalculationMethod1Code? CalculationMethod { get; init; } 
    #else
    public CalculationMethod1Code? CalculationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the periodicity of the calculation of the interest.
    /// </summary>
    [IsoId("_PN61cStMEeyOa655cLd-DQ")]
    [DisplayName("Calculation Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnFrqcy")]
    #endif
    [IsoXmlTag("ClctnFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency1Code? CalculationFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency1Code? CalculationFrequency { get; init; } 
    #else
    public Frequency1Code? CalculationFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the collateral has been posted against the variation margin, the segregated independent amount or to cover any other risk defined with a proprietary code.
    /// </summary>
    [IsoId("_PN61cytMEeyOa655cLd-DQ")]
    [DisplayName("Collateral Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPurp")]
    #endif
    [IsoXmlTag("CollPurp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralPurpose1Choice_ CollateralPurpose { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralPurpose1Choice_ CollateralPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralPurpose1Choice_ CollateralPurpose { get; init; } 
    #else
    public CollateralPurpose1Choice_ CollateralPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the opening collateral balance.
    /// </summary>
    [IsoId("_PN61dStMEeyOa655cLd-DQ")]
    [DisplayName("Opening Collateral Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngCollBal")]
    #endif
    [IsoXmlTag("OpngCollBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralBalance1? OpeningCollateralBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralBalance1? OpeningCollateralBalance { get; init; } 
    #else
    public CollateralBalance1? OpeningCollateralBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the closing collateral balance.
    /// </summary>
    [IsoId("_PN61dytMEeyOa655cLd-DQ")]
    [DisplayName("Closing Collateral Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgCollBal")]
    #endif
    [IsoXmlTag("ClsgCollBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralBalance1 ClosingCollateralBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralBalance1 ClosingCollateralBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralBalance1 ClosingCollateralBalance { get; init; } 
    #else
    public CollateralBalance1 ClosingCollateralBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    [IsoId("_PN61eStMEeyOa655cLd-DQ")]
    [DisplayName("Standard Settlement Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StdSttlmInstrs")]
    #endif
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StandardSettlementInstructions { get; init; } 
    #else
    public System.String? StandardSettlementInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Additionnal information related to interest request.
    /// </summary>
    [IsoId("_PN61eytMEeyOa655cLd-DQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
