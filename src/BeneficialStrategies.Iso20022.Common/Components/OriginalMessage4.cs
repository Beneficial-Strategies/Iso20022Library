// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identification of the original message references.
/// </summary>
[IsoId("_LdpF-W49EeiU9cctagi5ow")]
[DisplayName("Original Message")]
public record OriginalMessage4
{
    /// <summary>
    /// Original message sender used to identify the message.
    /// </summary>
    [IsoId("_LnLcYW49EeiU9cctagi5ow")]
    [DisplayName("Original Sender")]
    [IsoXmlTag("OrgnlSndr")]
    public Party40Choice_? OriginalSender { get; init; }

    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original group of individual transactions.
    /// </summary>
    [IsoId("_LnLcY249EeiU9cctagi5ow")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers, such as pacs.003.001.01 or MT103.
    /// </summary>
    [IsoId("_LnLcZW49EeiU9cctagi5ow")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Original date and time at which the message was created.
    /// </summary>
    [IsoId("_LnLcZ249EeiU9cctagi5ow")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Specifies the identification of original package of instructions, entries or records.
    /// </summary>
    [IsoId("_LnLcaW49EeiU9cctagi5ow")]
    [DisplayName("Original Package Identification")]
    [IsoXmlTag("OrgnlPackgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalPackageIdentification { get; init; }

    /// <summary>
    /// Specifies the identification of original entry, instruction or record within the package.
    /// </summary>
    [IsoId("_LnLca249EeiU9cctagi5ow")]
    [DisplayName("Original Record Identification")]
    [IsoXmlTag("OrgnlRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalRecordIdentification { get; init; }
}
