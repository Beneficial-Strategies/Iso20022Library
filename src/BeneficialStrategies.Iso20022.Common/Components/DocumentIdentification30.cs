// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the message number and the query identification.
/// </summary>
[IsoId("_RYv5yznqEeWfSKvvZlhRKg")]
[DisplayName("Document Identification")]
public record DocumentIdentification30
{
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_R5VeUTnqEeWfSKvvZlhRKg")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the query identification.
    /// </summary>
    [IsoId("_R5VeUznqEeWfSKvvZlhRKg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required Identification14 Reference { get; init; }
}
