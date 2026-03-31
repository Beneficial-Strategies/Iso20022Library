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
[IsoId("_DRyj4RrgEeyhRdHRjakS2w")]
[DisplayName("Notification General Information")]
public record NotificationGeneralInformation3
{
    /// <summary>
    /// Type of notification.
    /// </summary>
    [IsoId("_DujYYRrgEeyhRdHRjakS2w")]
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required NotificationType3Code NotificationType { get; init; }

    /// <summary>
    /// Status of the details of the event.
    /// </summary>
    [IsoId("_DujYaRrgEeyhRdHRjakS2w")]
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public required EventStatus1 NotificationStatus { get; init; }

    /// <summary>
    /// Indicates whether the announcement was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_DujYcRrgEeyhRdHRjakS2w")]
    [DisplayName("Shareholder Rights Directive Indicator")]
    [IsoXmlTag("ShrhldrRghtsDrctvInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; }

    /// <summary>
    /// Indicates whether a specific confirmation of holding together with a participation and/or vote instruction is required by the issuer (for instance as required in the German Stock Corporation Act paragraph 67c section 3).
    /// </summary>
    [IsoId("_Pj09QBrgEeyhRdHRjakS2w")]
    [DisplayName("Confirmation Of Holding Required")]
    [IsoXmlTag("ConfOfHldgReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConfirmationOfHoldingRequired { get; init; }
}
