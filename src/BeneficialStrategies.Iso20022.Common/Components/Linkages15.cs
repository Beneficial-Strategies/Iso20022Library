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
[IsoId("_Ab8KlNokEeC60axPepSq7g_1109963606")]
[DisplayName("Linkages")]
public record Linkages15
{
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_Ab8KldokEeC60axPepSq7g_996124540")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber4Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_AcF7kNokEeC60axPepSq7g_-947813")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required IdentificationReference8Choice_ Reference { get; init; }
}
