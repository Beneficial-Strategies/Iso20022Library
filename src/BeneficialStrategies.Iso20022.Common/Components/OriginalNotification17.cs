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
[IsoId("553b9e8f-6f17-4a30-a9cb-6df31d0a49c3")]
[DisplayName("Original Notification17")]
public record OriginalNotification17
{
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    [IsoId("02e21d9f-8d10-4e09-9752-c520d355e01e")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("a253d2ff-106c-4f46-81d1-be35746531fd")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Identification of the original notification.
    /// </summary>
    [IsoId("23745e67-5c4e-4112-869d-cc8407dd8cf5")]
    [DisplayName("Original Notification Identification")]
    [IsoXmlTag("OrgnlNtfctnId")]
    public required IsoMax35Text OriginalNotificationIdentification { get; init; }

    /// <summary>
    /// Specifies the status of the notification in a coded form.
    /// </summary>
    [IsoId("5ee5d63a-e9d6-4bc1-8dc6-c98b04d62271")]
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public NotificationStatus3Code? NotificationStatus { get; init; }

    /// <summary>
    /// Further details of the notification status.
    /// </summary>
    [IsoId("3dcde869-39e5-4132-99ff-12da6662fb7d")]
    [DisplayName("Additional Status Information")]
    [IsoXmlTag("AddtlStsInf")]
    public IsoMax140Text? AdditionalStatusInformation { get; init; }

    /// <summary>
    /// Identifies the original notification item and provides the status.
    /// </summary>
    [IsoId("e9d84013-024d-47f9-98c5-752f78134880")]
    [DisplayName("Original Notification Reference")]
    [IsoXmlTag("OrgnlNtfctnRef")]
    public ValueList<OriginalNotificationReference15> OriginalNotificationReference { get; init; } = [];
}
