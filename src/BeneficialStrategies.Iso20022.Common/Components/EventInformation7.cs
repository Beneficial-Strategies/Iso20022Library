// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about event of a corporate action.
/// </summary>
[IsoId("_fi5-VzndEeWLJsP1cO-amg")]
[DisplayName("Event Information")]
public record EventInformation7
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_fvQYMzndEeWLJsP1cO-amg")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Provides the reference of the linked official corporate action event.
    /// </summary>
    [IsoId("_fvQYOzndEeWLJsP1cO-amg")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_fvQYQzndEeWLJsP1cO-amg")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType32Choice_ EventType { get; init; }

    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_fvQYSzndEeWLJsP1cO-amg")]
    [DisplayName("Mandatory Voluntary Event Type")]
    [IsoXmlTag("MndtryVlntryEvtTp")]
    public required CorporateActionMandatoryVoluntary3Choice_ MandatoryVoluntaryEventType { get; init; }

    /// <summary>
    /// Provides information about the identification of the last notification.
    /// </summary>
    [IsoId("_fvQYUzndEeWLJsP1cO-amg")]
    [DisplayName("Last Notification Identification")]
    [IsoXmlTag("LastNtfctnId")]
    public NotificationIdentification3? LastNotificationIdentification { get; init; }
}
