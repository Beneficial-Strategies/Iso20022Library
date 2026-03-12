// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the old and new values for a party log status.
/// </summary>
[IsoId("_mm5wc2jSEeiRg5NzP0jkQg")]
[DisplayName("Update Log Party Lock Status")]
public partial record UpdateLogPartyLockStatus1
{
    #nullable enable
    
    /// <summary>
    /// Old value before the update.
    /// </summary>
    [IsoId("_mm5wdGjSEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    public required PartyLockStatus1 Old { get; init; } 
    
    /// <summary>
    /// New value after the update.
    /// </summary>
    [IsoId("_mm5wdWjSEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public required PartyLockStatus1 New { get; init; } 
    
    
    #nullable disable
    
}
