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
[IsoId("_i6MT3R9PEeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action General Information")]
public record CorporateActionGeneralInformation158
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_i6MT4x9PEeuFz_FaCzCLgQ")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_i6MT6x9PEeuFz_FaCzCLgQ")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_i6MT8x9PEeuFz_FaCzCLgQ")]
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ClassActionNumber { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_i6MT-x9PEeuFz_FaCzCLgQ")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType103Choice_ EventType { get; init; }
}
