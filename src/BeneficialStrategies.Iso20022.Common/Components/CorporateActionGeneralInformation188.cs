// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action General Information188.
/// </summary>
[IsoId("_kLozKpt3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action General Information188")]
public record CorporateActionGeneralInformation188
{
    /// <summary>
    /// Class Action Number.
    /// </summary>
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    public IsoRestrictedFINXMax16Text? ClassActionNumber { get; init; }

    /// <summary>
    /// Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Event Type.
    /// </summary>
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType118Choice_ EventType { get; init; }

    /// <summary>
    /// Official Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; }
}
