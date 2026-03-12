// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the index used to define the rate and the basis point spread.
/// </summary>
[IsoId("_hFv8Fax2Eem81-uIvTF5rQ")]
[DisplayName("Floating Interest Rate")]
public partial record FloatingInterestRate19
{
    #nullable enable
    
    /// <summary>
    /// Identifies the reference index for the debt instrument.
    /// </summary>
    [IsoId("_hJxgcax2Eem81-uIvTF5rQ")]
    [DisplayName("Reference Rate")]
    [IsoXmlTag("RefRate")]
    public BenchmarkCurveName10Choice_? ReferenceRate { get; init; } 
    
    /// <summary>
    /// Term of the reference rate of the floating rate bond. The term shall be expressed in days, weeks, months or years.
    /// </summary>
    [IsoId("_hJxgc6x2Eem81-uIvTF5rQ")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public InterestRateContractTerm2? Term { get; init; } 
    
    /// <summary>
    /// Information related to payment frequency.
    /// </summary>
    [IsoId("_hJxgdax2Eem81-uIvTF5rQ")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public InterestRateContractTerm2? PaymentFrequency { get; init; } 
    
    /// <summary>
    /// Information related to reset of payment frequency.
    /// </summary>
    [IsoId("_hJxgd6x2Eem81-uIvTF5rQ")]
    [DisplayName("Reset Frequency")]
    [IsoXmlTag("RstFrqcy")]
    public InterestRateContractTerm2? ResetFrequency { get; init; } 
    
    /// <summary>
    /// Provides the number of basis points added to (if positive) or deducted from (if negative) the underlying reference rate to calculate the actual interest rate applicable for a given period at issuance of the floating rate instrument.
    /// </summary>
    [IsoId("_hJxgeax2Eem81-uIvTF5rQ")]
    [DisplayName("Basis Point Spread")]
    [IsoXmlTag("BsisPtSprd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? BasisPointSpread { get; init; } 
    
    /// <summary>
    /// Specifies the rate adjustments as determined by the rate schedule.
    /// </summary>
    [IsoId("_wWAosctEEemlLfTG-WCXxw")]
    [DisplayName("Rate Adjustment")]
    [IsoXmlTag("RateAdjstmnt")]
    public RateAdjustment1? RateAdjustment { get; init; } 
    
    /// <summary>
    /// Method for calculating the accrued interest on the principal amount for a fixed rate.
    /// </summary>
    [IsoId("_hJxge6x2Eem81-uIvTF5rQ")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat6Choice_? DayCountBasis { get; init; } 
    
    
    #nullable disable
    
}
