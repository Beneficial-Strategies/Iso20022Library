// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Notification15.
/// </summary>
[IsoId("_8UWAUTEsEe6GxLzpkVnWYg")]
[DisplayName("Original Notification15")]
public record OriginalNotification15
{
    /// <summary>
    /// Additional Status Information.
    /// </summary>
    [DisplayName("Additional Status Information")]
    [IsoXmlTag("AddtlStsInf")]
    public IsoMax140Text? AdditionalStatusInformation { get; init; }

    /// <summary>
    /// Notification Status.
    /// </summary>
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public NotificationStatus3Code? NotificationStatus { get; init; }

    /// <summary>
    /// Original Creation Date Time.
    /// </summary>
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Original Message Identification.
    /// </summary>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Original Notification Identification.
    /// </summary>
    [DisplayName("Original Notification Identification")]
    [IsoXmlTag("OrgnlNtfctnId")]
    public required IsoMax35Text OriginalNotificationIdentification { get; init; }

    /// <summary>
    /// Original Notification Reference.
    /// </summary>
    [DisplayName("Original Notification Reference")]
    [IsoXmlTag("OrgnlNtfctnRef")]
    public ValueList<OriginalNotificationReference13> OriginalNotificationReference { get; init; } =
        [];
}
