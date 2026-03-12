// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the index used to define the rate and optionally the basis point spread.
/// </summary>
[IsoId("_HhTg5X5aEea2k7EBUopqxw")]
[DisplayName("Floating Interest Rate")]
public partial record FloatingInterestRate8
{
    #nullable enable
    
    /// <summary>
    /// Identifies the reference index for the instrument. 
    /// Usage:
    /// Index or name if the reference rate is not included in the index list.
    /// </summary>
    [IsoId("_Hq0pQX5aEea2k7EBUopqxw")]
    [DisplayName("Reference Rate")]
    [IsoXmlTag("RefRate")]
    public required BenchmarkCurveName5Choice_ ReferenceRate { get; init; } 
    
    /// <summary>
    /// Term of the reference rate.
    /// </summary>
    [IsoId("_Hq0pQ35aEea2k7EBUopqxw")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public InterestRateContractTerm2? Term { get; init; } 
    
    
    #nullable disable
    
}
