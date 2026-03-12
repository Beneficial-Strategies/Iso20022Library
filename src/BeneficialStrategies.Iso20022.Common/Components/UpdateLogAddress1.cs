// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the old and new values for an address.
/// </summary>
[IsoId("_NQ5xgGjSEeiRg5NzP0jkQg")]
[DisplayName("Update Log Address")]
public partial record UpdateLogAddress1
{
    #nullable enable
    
    /// <summary>
    /// Old value before change
    /// </summary>
    [IsoId("_U5BZcGjSEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    public required PostalAddress25 Old { get; init; } 
    
    /// <summary>
    /// New value after change
    /// </summary>
    [IsoId("_SjDnoGjSEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public required PostalAddress25 New { get; init; } 
    
    
    #nullable disable
    
}
