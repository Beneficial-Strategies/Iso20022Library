// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the original notification and to provide the status.
/// </summary>
[IsoId("_GPQVhW49EeiU9cctagi5ow")]
[DisplayName("Original Notification")]
public record OriginalNotification11
{
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    [IsoId("_GYfxA249EeiU9cctagi5ow")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_GYfxBW49EeiU9cctagi5ow")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Identification of the original notification.
    /// </summary>
    [IsoId("_GYfxB249EeiU9cctagi5ow")]
    [DisplayName("Original Notification Identification")]
    [IsoXmlTag("OrgnlNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalNotificationIdentification { get; init; }

    /// <summary>
    /// Specifies the status of the notification in a coded form.
    /// </summary>
    [IsoId("_GYfxCW49EeiU9cctagi5ow")]
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public NotificationStatus3Code? NotificationStatus { get; init; }

    /// <summary>
    /// Further details of the notification status.
    /// </summary>
    [IsoId("_GYfxC249EeiU9cctagi5ow")]
    [DisplayName("Additional Status Information")]
    [IsoXmlTag("AddtlStsInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalStatusInformation { get; init; }

    /// <summary>
    /// Identifies the original notification item and provides the status.
    /// </summary>
    [IsoId("_GYfxDW49EeiU9cctagi5ow")]
    [DisplayName("Original Notification Reference")]
    [IsoXmlTag("OrgnlNtfctnRef")]
    public OriginalNotificationReference9? OriginalNotificationReference { get; init; }
}
