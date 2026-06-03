// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of the group of transactions as assigned by the original instructing party.
/// </summary>
[IsoId("cbf73edd-b654-4c5f-88c4-856c0c41d474")]
[DisplayName("Original Group Information33")]
public record OriginalGroupInformation33
{
    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original message.
    /// </summary>
    [IsoId("8222206f-49ba-4180-aa0c-a8e82f8b6dd8")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("738f6e99-c66f-4c87-b2e4-469a21ebca6b")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Original date and time at which the message was created.
    /// </summary>
    [IsoId("79f0fece-3e2c-4843-ace6-0239f629aaed")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }
}
