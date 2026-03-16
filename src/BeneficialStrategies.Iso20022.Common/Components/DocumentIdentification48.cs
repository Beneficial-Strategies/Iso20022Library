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
[IsoId("_8RszA5NLEeWGlc8L7oPDIg")]
[DisplayName("Document Identification")]
public record DocumentIdentification48
{
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_8RszBZNLEeWGlc8L7oPDIg")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber6Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the query identification.
    /// </summary>
    [IsoId("_8RszB5NLEeWGlc8L7oPDIg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required Identification16 Reference { get; init; }
}
