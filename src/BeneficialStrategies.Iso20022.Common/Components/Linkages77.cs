// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Linkages77.
/// </summary>
[IsoId("_QmO5QYcGEe-6cOl7zMpJaA")]
[DisplayName("Linkages77")]
public partial record Linkages77
{
    #nullable enable

    /// <summary>
    /// Message Number.
    /// </summary>
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber17Choice_? MessageNumber { get; init; } 

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required IdentificationReference16Choice_ Reference { get; init; } 

    
    #nullable disable
    
}
