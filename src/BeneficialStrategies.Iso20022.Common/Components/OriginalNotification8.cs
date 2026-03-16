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
[IsoId("_cUu40R77EeSxevWRRWxNAg")]
[DisplayName("Original Notification")]
public record OriginalNotification8
{
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    [IsoId("_cltUEx77EeSxevWRRWxNAg")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_cltUFR77EeSxevWRRWxNAg")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Identification of the original notification.
    /// </summary>
    [IsoId("_cltUFx77EeSxevWRRWxNAg")]
    [DisplayName("Original Notification Identification")]
    [IsoXmlTag("OrgnlNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalNotificationIdentification { get; init; }

    /// <summary>
    /// Indicates whether the cancellation applies to the complete original notification or to individual items within the original notification.
    /// </summary>
    [IsoId("_cltUGR77EeSxevWRRWxNAg")]
    [DisplayName("Notification Cancellation")]
    [IsoXmlTag("NtfctnCxl")]
    [IsoSimpleType(IsoSimpleType.GroupCancellationIndicator)]
    public IsoGroupCancellationIndicator? NotificationCancellation { get; init; }

    /// <summary>
    /// Identifies the original notification item, to which the cancellation advice refers.
    /// </summary>
    [IsoId("_cltUGx77EeSxevWRRWxNAg")]
    [DisplayName("Original Notification Reference")]
    [IsoXmlTag("OrgnlNtfctnRef")]
    public OriginalNotificationReference6? OriginalNotificationReference { get; init; }
}
