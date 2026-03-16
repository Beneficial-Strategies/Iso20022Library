// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reference information to the original message.
/// </summary>
[IsoId("_BSviu24-EeiU9cctagi5ow")]
[DisplayName("Original Transaction Reference")]
public record OriginalTransactionReference30
{
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_BcbqM24-EeiU9cctagi5ow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_BcbqNW4-EeiU9cctagi5ow")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageNameIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_BcbqN24-EeiU9cctagi5ow")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Provides reference information to the original transaction.
    /// </summary>
    [IsoId("_BcbqOW4-EeiU9cctagi5ow")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public ValueList<PaymentIdentification5> OriginalTransaction { get; init; } = [];
}
