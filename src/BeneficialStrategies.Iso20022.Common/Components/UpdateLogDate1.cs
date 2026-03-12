// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the old and new values for a date.
/// </summary>
[IsoId("_Zi5Hk2jSEeiRg5NzP0jkQg")]
[DisplayName("Update Log Date")]
public partial record UpdateLogDate1
{
    #nullable enable
    
    /// <summary>
    /// Old value before the update.
    /// </summary>
    [IsoId("_Zi5HlGjSEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Old { get; init; } 
    
    /// <summary>
    /// New value after the update.
    /// </summary>
    [IsoId("_Zi5HlWjSEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate New { get; init; } 
    
    
    #nullable disable
    
}
