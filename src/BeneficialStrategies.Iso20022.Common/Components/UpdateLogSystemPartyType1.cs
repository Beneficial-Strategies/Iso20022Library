// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the old and new values for the type of a system party.
/// </summary>
[IsoId("_5Lc0Q2jTEeiRg5NzP0jkQg")]
[DisplayName("Update Log System Party Type")]
public partial record UpdateLogSystemPartyType1
{
    #nullable enable
    
    /// <summary>
    /// Old value before the update.
    /// </summary>
    [IsoId("_5Lc0RGjTEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    public required SystemPartyType1Choice_ Old { get; init; } 
    
    /// <summary>
    /// New value after the update.
    /// </summary>
    [IsoId("_5Lc0RWjTEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public required SystemPartyType1Choice_ New { get; init; } 
    
    
    #nullable disable
    
}
