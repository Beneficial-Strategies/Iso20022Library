// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Linkages77.
/// </summary>
[IsoId("_QmO5QYcGEe-6cOl7zMpJaA")]
[DisplayName("Linkages77")]
public record Linkages77
{
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
}
