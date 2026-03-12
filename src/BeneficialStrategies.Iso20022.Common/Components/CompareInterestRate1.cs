// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the values defined as part of the Margin Loan Attribute are matching or not.
/// </summary>
[IsoId("_ufZIwM3MEeuiU4QSC_BouQ")]
[DisplayName("Compare Interest Rate")]
public partial record CompareInterestRate1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_lOE7EM6gEeuUrZNOIIJRog")]
    [DisplayName("Margin Loan Amount")]
    [IsoXmlTag("MrgnLnAmt")]
    public CompareAmountAndDirection1? MarginLoanAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_5FJMKs6gEeuUrZNOIIJRog")]
    [DisplayName("Fixed Interest Rate")]
    [IsoXmlTag("FxdIntrstRate")]
    public ComparePercentageRate3? FixedInterestRate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_5FJMK86gEeuUrZNOIIJRog")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public CompareInterestComputationMethod3? DayCountBasis { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    [IsoId("_5FJMLM6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Reference Rate")]
    [IsoXmlTag("FltgIntrstRefRate")]
    public CompareBenchmarkCurveName3? FloatingInterestReferenceRate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_5FJMLc6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Term Unit")]
    [IsoXmlTag("FltgIntrstRateTermUnit")]
    public CompareRateBasis3? FloatingInterestRateTermUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_5FJMLs6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Term Value")]
    [IsoXmlTag("FltgIntrstRateTermVal")]
    public CompareNumber5? FloatingInterestRateTermValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_5FJML86gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Payment Frequency Unit")]
    [IsoXmlTag("FltgIntrstRatePmtFrqcyUnit")]
    public CompareRateBasis3? FloatingInterestRatePaymentFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_5FJMMM6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Payment Frequency Value")]
    [IsoXmlTag("FltgIntrstRatePmtFrqcyVal")]
    public CompareNumber5? FloatingInterestRatePaymentFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_5FJMMc6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Reset Frequency Unit")]
    [IsoXmlTag("FltgIntrstRateRstFrqcyUnit")]
    public CompareRateBasis3? FloatingInterestRateResetFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_5FJMMs6gEeuUrZNOIIJRog")]
    [DisplayName("Floating Interest Rate Reset Frequency Value")]
    [IsoXmlTag("FltgIntrstRateRstFrqcyVal")]
    public CompareNumber6? FloatingInterestRateResetFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_5FJMM86gEeuUrZNOIIJRog")]
    [DisplayName("Basis Point Spread")]
    [IsoXmlTag("BsisPtSprd")]
    public CompareDecimalNumber3? BasisPointSpread { get; init; } 
    
    
    #nullable disable
    
}
