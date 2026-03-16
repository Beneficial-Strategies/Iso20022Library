// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Linkages74.
/// </summary>
[IsoId("_NgieEYYeEe-Pv9KR9bv9IA")]
[DisplayName("Linkages74")]
public record Linkages74
{
    /// <summary>
    /// Message Number.
    /// </summary>
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Processing Position.
    /// </summary>
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition8Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References81Choice_ Reference { get; init; }

    /// <summary>
    /// Reference Owner.
    /// </summary>
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification127Choice_? ReferenceOwner { get; init; }
}
