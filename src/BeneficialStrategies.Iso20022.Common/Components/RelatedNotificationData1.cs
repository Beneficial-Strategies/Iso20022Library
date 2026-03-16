// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Related Notification Data1.
/// </summary>
[IsoId("_uZw2sLkyEe68nbz8Nl_hLQ")]
[DisplayName("Related Notification Data1")]
public record RelatedNotificationData1
{
    /// <summary>
    /// Location.
    /// </summary>
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public ValueList<NotificationLocationData1> Location { get; init; } = [];

    /// <summary>
    /// Notification Identification.
    /// </summary>
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public IsoMax35Text? NotificationIdentification { get; init; }
}
