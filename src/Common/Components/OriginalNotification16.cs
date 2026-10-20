// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Notification16.
/// </summary>
[IsoId("_-CkcsTEsEe6GxLzpkVnWYg")]
[DisplayName("Original Notification16")]
public partial record OriginalNotification16
{
    /// <summary>
    /// Original Message Identification.
    /// </summary>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required Max35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Original Creation Date Time.
    /// </summary>
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public ISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Original Notification Identification.
    /// </summary>
    [DisplayName("Original Notification Identification")]
    [IsoXmlTag("OrgnlNtfctnId")]
    public required Max35Text OriginalNotificationIdentification { get; init; }

    /// <summary>
    /// Notification Cancellation.
    /// </summary>
    [DisplayName("Notification Cancellation")]
    [IsoXmlTag("NtfctnCxl")]
    public GroupCancellationIndicator? NotificationCancellation { get; init; }

    /// <summary>
    /// Original Notification Reference.
    /// </summary>
    [DisplayName("Original Notification Reference")]
    [IsoXmlTag("OrgnlNtfctnRef")]
    public ValueList<OriginalNotificationReference14> OriginalNotificationReference { get; init; } =
        [];
}
