// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the corporate action event.
/// </summary>
[IsoId("_k9drQ83xEee5nJBZsW8MFQ")]
[DisplayName("Corporate Action General Information")]
public record CorporateActionGeneralInformation132
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_k9drSc3xEee5nJBZsW8MFQ")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_k9drUc3xEee5nJBZsW8MFQ")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_k9drWc3xEee5nJBZsW8MFQ")]
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ClassActionNumber { get; init; }

    /// <summary>
    /// Type of processing involved by a corporate action.
    /// </summary>
    [IsoId("_k9drYc3xEee5nJBZsW8MFQ")]
    [DisplayName("Event Processing Type")]
    [IsoXmlTag("EvtPrcgTp")]
    public CorporateActionEventProcessingType3Choice_? EventProcessingType { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_k9drac3xEee5nJBZsW8MFQ")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType79Choice_ EventType { get; init; }

    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_k9drcc3xEee5nJBZsW8MFQ")]
    [DisplayName("Mandatory Voluntary Event Type")]
    [IsoXmlTag("MndtryVlntryEvtTp")]
    public required CorporateActionMandatoryVoluntary4Choice_ MandatoryVoluntaryEventType { get; init; }

    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_k9drec3xEee5nJBZsW8MFQ")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required FinancialInstrumentAttributes85 UnderlyingSecurity { get; init; }
}
