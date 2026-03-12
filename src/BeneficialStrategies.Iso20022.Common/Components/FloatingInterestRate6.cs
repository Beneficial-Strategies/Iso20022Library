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
[IsoId("_XYUPESc1EeaCIe3n1Gx9ug")]
[DisplayName("Floating Interest Rate")]
public partial record FloatingInterestRate6
{
    #nullable enable
    
    /// <summary>
    /// Identifies the reference index for the debt instrument.
    /// </summary>
    [IsoId("_XhGXoSc1EeaCIe3n1Gx9ug")]
    [DisplayName("Reference Rate")]
    [IsoXmlTag("RefRate")]
    public required BenchmarkCurveName6Choice_ ReferenceRate { get; init; } 
    
    /// <summary>
    /// Term of the index/benchmark of a floating rate bond. The term shall be expressed in days, weeks, months or years.
    /// </summary>
    [IsoId("_XhGXoyc1EeaCIe3n1Gx9ug")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public required InterestRateContractTerm2 Term { get; init; } 
    
    /// <summary>
    /// Number of basis points above (if positive) or below (if negative) the underlying reference rate to calculate the actual interest rate applicable for a given period at issuance of the floating rate instrument.
    /// Usage:
    /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
    /// </summary>
    [IsoId("_XhGXpSc1EeaCIe3n1Gx9ug")]
    [DisplayName("Basis Point Spread")]
    [IsoXmlTag("BsisPtSprd")]
    [IsoSimpleType(IsoSimpleType.Max5Number)]
    public required IsoMax5Number BasisPointSpread { get; init; } 
    
    
    #nullable disable
    
}
