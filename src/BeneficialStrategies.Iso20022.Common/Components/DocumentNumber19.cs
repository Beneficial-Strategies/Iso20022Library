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
[IsoId("_gBH0Fzi8Eeydid5dcNPKvg")]
[DisplayName("Document Number")]
public partial record DocumentNumber19
{
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_gBH0HTi8Eeydid5dcNPKvg")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required DocumentNumber6Choice_ Number { get; init; } 
    
    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    [IsoId("_gBH0JTi8Eeydid5dcNPKvg")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<Identification29> References { get; init; } = new ValueList<Identification29>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _gBH0JTi8Eeydid5dcNPKvg
    
    
    #nullable disable
    
}
