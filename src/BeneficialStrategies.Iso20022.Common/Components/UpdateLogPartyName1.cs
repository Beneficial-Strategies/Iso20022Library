// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the old and new values for the name of a party.
/// </summary>
[IsoId("_zOmJYGjVEeiRg5NzP0jkQg")]
[DisplayName("Update Log Party Name")]
public partial record UpdateLogPartyName1
{
    #nullable enable
    
    /// <summary>
    /// Old value before the update.
    /// </summary>
    [IsoId("_zOmJYWjVEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    public required PartyName4 Old { get; init; } 
    
    /// <summary>
    /// New value after the update.
    /// </summary>
    [IsoId("_zOmJYmjVEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public required PartyName4 New { get; init; } 
    
    
    #nullable disable
    
}
