// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the placement agent identification for a hedge fund if the investor was referred by one.
/// </summary>
[IsoId("_hyxAAZRBEemqYPWMBuVawg")]
[DisplayName("Referred Agent")]
public partial record ReferredAgent3
{
    #nullable enable
    
    /// <summary>
    /// Indicates if the investor was referred by a placement agent.
    /// </summary>
    [IsoId("_iGjes5RBEemqYPWMBuVawg")]
    [DisplayName("Referred")]
    [IsoXmlTag("Rfrd")]
    public required Referred1Code Referred { get; init; } 
    
    /// <summary>
    /// Placement agent that referred the investor.
    /// </summary>
    [IsoId("_iGjetZRBEemqYPWMBuVawg")]
    [DisplayName("Referred Placement Agent")]
    [IsoXmlTag("RfrdPlcmntAgt")]
    public PartyIdentification125Choice_? ReferredPlacementAgent { get; init; } 
    
    
    #nullable disable
    
}
