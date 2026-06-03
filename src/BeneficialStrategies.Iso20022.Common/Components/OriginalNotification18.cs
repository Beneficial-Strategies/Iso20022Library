// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the original notification, to which the cancellation advice refers.
/// </summary>
[IsoId("698216e6-8441-43df-8600-27592010f500")]
[DisplayName("Original Notification18")]
public record OriginalNotification18
{
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    [IsoId("37e06ed9-cb91-4c8b-ab25-a48bc4b35052")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("653e2643-cf73-4b9e-8ee6-3038a3c3e4bd")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Identification of the original notification.
    /// </summary>
    [IsoId("164ef1a8-86b9-49f1-a4b2-d909edf21e5e")]
    [DisplayName("Original Notification Identification")]
    [IsoXmlTag("OrgnlNtfctnId")]
    public required IsoMax35Text OriginalNotificationIdentification { get; init; }

    /// <summary>
    /// Indicates whether the cancellation applies to the complete original notification or to individual items within the original notification.
    /// </summary>
    [IsoId("9fa15f97-147d-4a88-a3a3-169f71ac7f5f")]
    [DisplayName("Notification Cancellation")]
    [IsoXmlTag("NtfctnCxl")]
    public IsoGroupCancellationIndicator? NotificationCancellation { get; init; }

    /// <summary>
    /// Identifies the original notification item, to which the cancellation advice refers.
    /// </summary>
    [IsoId("25e263e1-0651-43c1-ab70-d951f413fb63")]
    [DisplayName("Original Notification Reference")]
    [IsoXmlTag("OrgnlNtfctnRef")]
    public ValueList<OriginalNotificationReference16> OriginalNotificationReference { get; init; } = [];
}
