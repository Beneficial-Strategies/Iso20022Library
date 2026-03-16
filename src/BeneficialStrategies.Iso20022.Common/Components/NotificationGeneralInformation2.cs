// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Event notification type and status.
/// </summary>
[IsoId("_IW78ATkrEequeo9XmZe9AQ")]
[DisplayName("Notification General Information")]
public record NotificationGeneralInformation2
{
    /// <summary>
    /// Type of notification.
    /// </summary>
    [IsoId("_IvMD8TkrEequeo9XmZe9AQ")]
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required NotificationType3Code NotificationType { get; init; }

    /// <summary>
    /// Status of the details of the event.
    /// </summary>
    [IsoId("_IvMD-TkrEequeo9XmZe9AQ")]
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public required EventStatus1 NotificationStatus { get; init; }

    /// <summary>
    /// Indicates whether the announcement was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_2uookTkqEequeo9XmZe9AQ")]
    [DisplayName("Shareholder Rights Directive Indicator")]
    [IsoXmlTag("ShrhldrRghtsDrctvInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; }
}
