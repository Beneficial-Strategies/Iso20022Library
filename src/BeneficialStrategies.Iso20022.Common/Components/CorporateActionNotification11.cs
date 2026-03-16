// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Notification11.
/// </summary>
[IsoId("_8NBPYXTPEe6_FuzYWj2GYQ")]
[DisplayName("Corporate Action Notification11")]
public record CorporateActionNotification11
{
    /// <summary>
    /// Notification Identification.
    /// </summary>
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public IsoRestrictedFINXMax16Text? NotificationIdentification { get; init; }

    /// <summary>
    /// Notification Type.
    /// </summary>
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required CorporateActionNotificationType1Code NotificationType { get; init; }

    /// <summary>
    /// Processing Status.
    /// </summary>
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required CorporateActionProcessingStatus6Choice_ ProcessingStatus { get; init; }
}
