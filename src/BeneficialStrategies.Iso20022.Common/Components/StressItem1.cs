// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Risk factor, financial instrument or set of financial instruments that is stressed under a hypothetical stress scenario.
/// </summary>
[IsoId("_0AzLQKszEeayv9XxdmMwKQ")]
[DisplayName("Stress Item")]
public partial record StressItem1
{
    #nullable enable
    
    /// <summary>
    /// Set of information relating to major representative product being stressed under the stress scenario.
    /// </summary>
    [IsoId("_70-SMKszEeayv9XxdmMwKQ")]
    [DisplayName("Stress Product")]
    [IsoXmlTag("StrssPdct")]
    public required StressItem1Choice_ StressProduct { get; init; } 
    
    
    #nullable disable
    
}
