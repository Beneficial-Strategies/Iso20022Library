// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the start and end time for the time to maturity.
/// </summary>
[IsoId("_vvHl4MVbEeiYpLQka876sg")]
[DisplayName("Time To Maturity Period")]
public partial record TimeToMaturityPeriod1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the start of the maturity period.
    /// </summary>
    [IsoId("_KfScwMVcEeiYpLQka876sg")]
    [DisplayName("Start")]
    [IsoXmlTag("Start")]
    public MaturityTerm2? Start { get; init; } 
    
    /// <summary>
    /// Specifies the end of the maturity period.
    /// </summary>
    [IsoId("_LNQ9EcVcEeiYpLQka876sg")]
    [DisplayName("End")]
    [IsoXmlTag("End")]
    public MaturityTerm2? End { get; init; } 
    
    
    #nullable disable
    
}
