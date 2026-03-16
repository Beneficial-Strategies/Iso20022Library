// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate action event notification status and contents.
/// </summary>
[IsoId("_UKK4adp-Ed-ak6NoX_4Aeg_1604589270")]
[DisplayName("Corporate Action Notification")]
public record CorporateActionNotification2
{
    /// <summary>
    /// Specifies the type of notification.
    /// </summary>
    [IsoId("_UKUpYNp-Ed-ak6NoX_4Aeg_-1432121475")]
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required CorporateActionNotificationType1Code NotificationType { get; init; }

    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [IsoId("_UKUpYdp-Ed-ak6NoX_4Aeg_-733654545")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required CorporateActionProcessingStatus1Choice_ ProcessingStatus { get; init; }

    /// <summary>
    /// Indicates whether the eligible balance is final except for a voluntary corporate action event where it can represent the current eligible balance when communicated before expiration date of that event.
    /// </summary>
    [IsoId("_UKUpYtp-Ed-ak6NoX_4Aeg_944981659")]
    [DisplayName("Eligible Balance Indicator")]
    [IsoXmlTag("ElgblBalInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleBalanceIndicator { get; init; }
}
