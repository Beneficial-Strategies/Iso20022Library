// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a message previously sent.
/// </summary>
[IsoId("_-Cue8nltEeG7BsjMvd1mEw_1352240882")]
[DisplayName("Original Message")]
public record OriginalMessage1
{
    /// <summary>
    /// XML schema-instance namespace, for example &quot;tsin.008.001.01&quot;.
    /// </summary>
    [IsoId("_-Cue83ltEeG7BsjMvd1mEw_-699317533")]
    [DisplayName("Message Definition Identifier")]
    [IsoXmlTag("MsgDefIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageDefinitionIdentifier { get; init; }

    /// <summary>
    /// Message sender specified in the original message.|
    /// </summary>
    [IsoId("_-Cue9HltEeG7BsjMvd1mEw_-135925947")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party9Choice_ From { get; init; }

    /// <summary>
    /// Message recipient specified in the original message.
    /// </summary>
    [IsoId("_-Cue9XltEeG7BsjMvd1mEw_-844084979")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party9Choice_ To { get; init; }

    /// <summary>
    /// Message identification specified in the original message.
    /// </summary>
    [IsoId("_-Cue9nltEeG7BsjMvd1mEw_-2054731857")]
    [DisplayName("Business Message Identifier")]
    [IsoXmlTag("BizMsgIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BusinessMessageIdentifier { get; init; }

    /// <summary>
    /// Message creation date and time specified in the original message.
    /// </summary>
    [IsoId("_-C4P8HltEeG7BsjMvd1mEw_1720315394")]
    [DisplayName("Creation Date")]
    [IsoXmlTag("CreDt")]
    [IsoSimpleType(IsoSimpleType.ISONormalisedDateTime)]
    public required IsoISONormalisedDateTime CreationDate { get; init; }

    /// <summary>
    /// Indicates whether the message is a copy, a duplicate or a copy of a duplicate of a previously sent ISO 20022 message.
    /// </summary>
    [IsoId("_-C4P8XltEeG7BsjMvd1mEw_-1157358019")]
    [DisplayName("Copy Duplicate")]
    [IsoXmlTag("CpyDplct")]
    public CopyDuplicate1Code? CopyDuplicate { get; init; }
}
