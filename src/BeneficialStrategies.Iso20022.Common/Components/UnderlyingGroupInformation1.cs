// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by the first instructing agent, to unambiguously identify the group of transactions.
/// </summary>
[IsoId("_RrBVYtp-Ed-ak6NoX_4Aeg_884871107")]
[DisplayName("Underlying Group Information")]
public record UnderlyingGroupInformation1
{
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_RrBVY9p-Ed-ak6NoX_4Aeg_884871138")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_RrBVZNp-Ed-ak6NoX_4Aeg_884871169")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_RrBVZdp-Ed-ak6NoX_4Aeg_884871199")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Original channel used for the delivery of the message, to allow the receiver of the request to locate the payment with greater ease.
    /// </summary>
    [IsoId("_RrBVZtp-Ed-ak6NoX_4Aeg_1113343746")]
    [DisplayName("Original Message Delivery Channel")]
    [IsoXmlTag("OrgnlMsgDlvryChanl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMessageDeliveryChannel { get; init; }
}
