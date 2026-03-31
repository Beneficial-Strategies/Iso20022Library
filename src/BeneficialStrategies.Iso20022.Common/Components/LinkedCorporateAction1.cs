// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies linkage information of a corporate action message.
/// </summary>
[IsoId("_RjH9pNp-Ed-ak6NoX_4Aeg_866442593")]
[DisplayName("Linked Corporate Action")]
public record LinkedCorporateAction1
{
    /// <summary>
    /// The function of the notification e.g. new notification.
    /// </summary>
    [IsoId("_RjH9pdp-Ed-ak6NoX_4Aeg_-1179382200")]
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required CorporateActionNotificationType1Code NotificationType { get; init; }

    /// <summary>
    /// The identification of the linked notification advice.
    /// </summary>
    [IsoId("_RjH9ptp-Ed-ak6NoX_4Aeg_883990379")]
    [DisplayName("Linked Agent CA Notification Advice Identification")]
    [IsoXmlTag("LkdAgtCANtfctnAdvcId")]
    public DocumentIdentification8? LinkedAgentCANotificationAdviceIdentification { get; init; }

    /// <summary>
    /// Specifies when the instruction is to be executed relative to a linked instruction.
    /// </summary>
    [IsoId("_RjRuoNp-Ed-ak6NoX_4Aeg_907077517")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition2FormatChoice_? LinkageType { get; init; }

    /// <summary>
    /// Reference given to the linked event by the CA event issuer (agent).
    /// </summary>
    [IsoId("_RjRuodp-Ed-ak6NoX_4Aeg_-1520860145")]
    [DisplayName("Linked Issuer Corporate Action Identification")]
    [IsoXmlTag("LkdIssrCorpActnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LinkedIssuerCorporateActionIdentification { get; init; }

    /// <summary>
    /// Reference assigned by the CSD to the linked coporate avent.
    /// </summary>
    [IsoId("_RjRuotp-Ed-ak6NoX_4Aeg_-1520860114")]
    [DisplayName("Linked Corporate Action Processing Identification")]
    [IsoXmlTag("LkdCorpActnPrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LinkedCorporateActionProcessingIdentification { get; init; }
}
