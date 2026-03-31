// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_lZL6YTt4EeW638lNyHKv7A")]
[DisplayName("Linkages")]
public record Linkages39
{
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_l5LCAzt4EeW638lNyHKv7A")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition8Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_l5LCCzt4EeW638lNyHKv7A")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_l5LCEzt4EeW638lNyHKv7A")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References46Choice_ Reference { get; init; }

    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_l5LCGzt4EeW638lNyHKv7A")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification92Choice_? ReferenceOwner { get; init; }
}
