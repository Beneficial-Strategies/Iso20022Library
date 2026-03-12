// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_0ff4mwlIEeGATtfOBToyew_1199294698")]
[DisplayName("Linkages")]
public partial record Linkages21
{
    #nullable enable
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_0ff4nAlIEeGATtfOBToyew_96918430")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References1Choice_ Reference { get; init; } 
    
    
    #nullable disable
    
}
