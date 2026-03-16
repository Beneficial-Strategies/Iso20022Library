// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by the original requestor, to unambiguously identify the business instruction message.
/// </summary>
[IsoId("_Au3KEK0qEeijn5WVKzFWUw")]
[DisplayName("Original Business Instruction")]
public record OriginalBusinessInstruction1
{
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original instruction message.
    /// </summary>
    [IsoId("_Au3KFK0qEeijn5WVKzFWUw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Specifies the instruction message name identifier to which the message refers.
    /// </summary>
    [IsoId("_Au3KE60qEeijn5WVKzFWUw")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageNameIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_Au3KEa0qEeijn5WVKzFWUw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }
}
