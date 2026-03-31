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
[IsoId("_c47qaZKQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action General Information")]
public record CorporateActionGeneralInformation103
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_c47qb5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_c47qd5KQEeWHWpTQn1FFVg")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_c47qf5KQEeWHWpTQn1FFVg")]
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ClassActionNumber { get; init; }

    /// <summary>
    /// Type of processing involved by a corporate action.
    /// </summary>
    [IsoId("_c47qh5KQEeWHWpTQn1FFVg")]
    [DisplayName("Event Processing Type")]
    [IsoXmlTag("EvtPrcgTp")]
    public CorporateActionEventProcessingType3Choice_? EventProcessingType { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_c47qj5KQEeWHWpTQn1FFVg")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType35Choice_ EventType { get; init; }

    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_c47ql5KQEeWHWpTQn1FFVg")]
    [DisplayName("Mandatory Voluntary Event Type")]
    [IsoXmlTag("MndtryVlntryEvtTp")]
    public required CorporateActionMandatoryVoluntary4Choice_ MandatoryVoluntaryEventType { get; init; }

    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_c47qn5KQEeWHWpTQn1FFVg")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required FinancialInstrumentAttributes70 UnderlyingSecurity { get; init; }
}
