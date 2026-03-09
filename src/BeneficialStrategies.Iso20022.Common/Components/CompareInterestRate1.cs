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
/// Specifies whether the values defined as part of the Margin Loan Attribute are matching or not.
/// </summary>
[IsoId("_ufZIwM3MEeuiU4QSC_BouQ")]
[DisplayName("Compare Interest Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CompareInterestRate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_lOE7EM6gEeuUrZNOIIJRog")]
    [DisplayName("Margin Loan Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnLnAmt")]
    #endif
    [IsoXmlTag("MrgnLnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAmountAndDirection1? MarginLoanAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAmountAndDirection1? MarginLoanAmount { get; init; } 
    #else
    public CompareAmountAndDirection1? MarginLoanAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_5FJMKs6gEeuUrZNOIIJRog")]
    [DisplayName("Fixed Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxdIntrstRate")]
    #endif
    [IsoXmlTag("FxdIntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate3? FixedInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate3? FixedInterestRate { get; init; } 
    #else
    public ComparePercentageRate3? FixedInterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_5FJMK86gEeuUrZNOIIJRog")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareInterestComputationMethod3? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareInterestComputationMethod3? DayCountBasis { get; init; } 
    #else
    public CompareInterestComputationMethod3? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    [IsoId("_5FJMLM6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Reference Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRefRate")]
    #endif
    [IsoXmlTag("FltgIntrstRefRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareBenchmarkCurveName3? FloatingInterestReferenceRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareBenchmarkCurveName3? FloatingInterestReferenceRate { get; init; } 
    #else
    public CompareBenchmarkCurveName3? FloatingInterestReferenceRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_5FJMLc6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Term Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateTermUnit")]
    #endif
    [IsoXmlTag("FltgIntrstRateTermUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis3? FloatingInterestRateTermUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis3? FloatingInterestRateTermUnit { get; init; } 
    #else
    public CompareRateBasis3? FloatingInterestRateTermUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_5FJMLs6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Term Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateTermVal")]
    #endif
    [IsoXmlTag("FltgIntrstRateTermVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? FloatingInterestRateTermValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? FloatingInterestRateTermValue { get; init; } 
    #else
    public CompareNumber5? FloatingInterestRateTermValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_5FJML86gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Payment Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRatePmtFrqcyUnit")]
    #endif
    [IsoXmlTag("FltgIntrstRatePmtFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis3? FloatingInterestRatePaymentFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis3? FloatingInterestRatePaymentFrequencyUnit { get; init; } 
    #else
    public CompareRateBasis3? FloatingInterestRatePaymentFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_5FJMMM6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Payment Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRatePmtFrqcyVal")]
    #endif
    [IsoXmlTag("FltgIntrstRatePmtFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? FloatingInterestRatePaymentFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? FloatingInterestRatePaymentFrequencyValue { get; init; } 
    #else
    public CompareNumber5? FloatingInterestRatePaymentFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_5FJMMc6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Reset Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateRstFrqcyUnit")]
    #endif
    [IsoXmlTag("FltgIntrstRateRstFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis3? FloatingInterestRateResetFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis3? FloatingInterestRateResetFrequencyUnit { get; init; } 
    #else
    public CompareRateBasis3? FloatingInterestRateResetFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_5FJMMs6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Reset Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateRstFrqcyVal")]
    #endif
    [IsoXmlTag("FltgIntrstRateRstFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber6? FloatingInterestRateResetFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber6? FloatingInterestRateResetFrequencyValue { get; init; } 
    #else
    public CompareNumber6? FloatingInterestRateResetFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_5FJMM86gEeuUrZNOIIJRog")]
    [DisplayName("Basis Point Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsisPtSprd")]
    #endif
    [IsoXmlTag("BsisPtSprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDecimalNumber3? BasisPointSpread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDecimalNumber3? BasisPointSpread { get; init; } 
    #else
    public CompareDecimalNumber3? BasisPointSpread { get; set; } 
    #endif
    
    
    #nullable disable
    
}
