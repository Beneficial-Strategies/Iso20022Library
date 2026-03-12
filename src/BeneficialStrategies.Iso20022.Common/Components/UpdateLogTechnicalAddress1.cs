// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the old and new values for a technical address identification.
/// </summary>
[IsoId("_pAXiM2jSEeiRg5NzP0jkQg")]
[DisplayName("Update Log Technical Address")]
public partial record UpdateLogTechnicalAddress1
{
    #nullable enable
    
    /// <summary>
    /// Old value before the update.
    /// </summary>
    [IsoId("_pAXiNGjSEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    public required TechnicalIdentification2Choice_ Old { get; init; } 
    
    /// <summary>
    /// New value after the update.
    /// </summary>
    [IsoId("_pAXiNWjSEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public required TechnicalIdentification2Choice_ New { get; init; } 
    
    
    #nullable disable
    
}
