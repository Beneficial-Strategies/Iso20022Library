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
[IsoId("_4yyB9ygSEeym1_Zp1BTvEw")]
[DisplayName("Document Number")]
public partial record DocumentNumber18
{
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_5I1KdSgSEeym1_Zp1BTvEw")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required DocumentNumber5Choice_ Number { get; init; } 
    
    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    [IsoId("_5I1KfSgSEeym1_Zp1BTvEw")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<Identification28> References { get; init; } = new ValueList<Identification28>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _5I1KfSgSEeym1_Zp1BTvEw
    
    
    #nullable disable
    
}
