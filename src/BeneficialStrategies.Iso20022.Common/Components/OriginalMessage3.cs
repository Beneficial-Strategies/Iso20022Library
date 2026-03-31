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
[IsoId("_4ciG8cQZEeWVvLI4PXU3BQ")]
[DisplayName("Original Message")]
public record OriginalMessage3
{
    /// <summary>
    /// Original message sender used to identify the message.
    /// </summary>
    [IsoId("_423SgcQZEeWVvLI4PXU3BQ")]
    [DisplayName("Original Sender")]
    [IsoXmlTag("OrgnlSndr")]
    public Party28Choice_? OriginalSender { get; init; }

    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original group of individual transactions.
    /// </summary>
    [IsoId("_423Sg8QZEeWVvLI4PXU3BQ")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers, such as pacs.003.001.01 or MT103.
    /// </summary>
    [IsoId("_423ShcQZEeWVvLI4PXU3BQ")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Original date and time at which the message was created.
    /// </summary>
    [IsoId("_423Sh8QZEeWVvLI4PXU3BQ")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }
}
