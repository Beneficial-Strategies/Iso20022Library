// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies if the occurrence of the event contained in the notification is confirmed or unconfirmed. Details of the event can be complete or incomplete.
/// </summary>
[IsoId("_RW6Gk9p-Ed-ak6NoX_4Aeg_1742926968")]
[DisplayName("Notification Status")]
public record NotificationStatus1
{
    /// <summary>
    /// Status to define if the occurrence of the event contained in the notification is confirmed or unconfirmed.
    /// </summary>
    [IsoId("_RW6GlNp-Ed-ak6NoX_4Aeg_1742926970")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required NotificationStatus2Code Status { get; init; }
}
