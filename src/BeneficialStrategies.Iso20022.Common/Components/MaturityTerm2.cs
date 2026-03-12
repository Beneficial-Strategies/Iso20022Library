// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes how time to maturity is reported.
/// </summary>
[IsoId("_USvwUMVbEeiYpLQka876sg")]
[DisplayName("Maturity Term")]
public partial record MaturityTerm2
{
    #nullable enable
    
    /// <summary>
    /// Unit for the rate basis.
    /// </summary>
    [IsoId("_USvwUsVbEeiYpLQka876sg")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public required RateBasis1Code Unit { get; init; } 
    
    /// <summary>
    /// Value of the maturity term in number of units.
    /// </summary>
    [IsoId("_USvwUcVbEeiYpLQka876sg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public required IsoMax3Number Value { get; init; } 
    
    
    #nullable disable
    
}
