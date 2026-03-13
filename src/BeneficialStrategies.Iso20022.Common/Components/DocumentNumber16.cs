// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the status being requested.
/// </summary>
[IsoId("_82tWodBxEeihG9bKfarOOA")]
[DisplayName("Document Number")]
public partial record DocumentNumber16
{
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_9JOC9dBxEeihG9bKfarOOA")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required DocumentNumber5Choice_ Number { get; init; } 
    
    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    [IsoId("_9JOC_dBxEeihG9bKfarOOA")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<Identification26> References { get; init; } = [];
    // ID for the above is _9JOC_dBxEeihG9bKfarOOA
    
    
    #nullable disable
    
}
