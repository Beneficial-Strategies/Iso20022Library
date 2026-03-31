// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a previous notification.
/// </summary>
[IsoId("_zbdbofM6EeqRfth943bvEA")]
[DisplayName("Notification Update")]
public record NotificationUpdate2
{
    /// <summary>
    /// Identification of a previously sent meeting notification message.
    /// </summary>
    [IsoId("_zxUW4_M6EeqRfth943bvEA")]
    [DisplayName("Previous Notification Identification")]
    [IsoXmlTag("PrvsNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PreviousNotificationIdentification { get; init; }

    /// <summary>
    /// Indicates whether a meeting instruction must be resent in case the parameters of the meeting are changed and the meeting instruction has already been sent.
    /// </summary>
    [IsoId("_zxUW5fM6EeqRfth943bvEA")]
    [DisplayName("Reconfirm Instructions")]
    [IsoXmlTag("RcnfrmInstrs")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReconfirmInstructions { get; init; }
}
