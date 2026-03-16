// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to purpose.
/// </summary>
[IsoId("_mUmoIA4rEeK3IMoVvcTkkg")]
[DisplayName("Purpose Modification")]
public record PurposeModification1
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_tSBGMA4rEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Purpose.
    /// </summary>
    [IsoId("_voiRoA4rEeK3IMoVvcTkkg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Purpose { get; init; }
}
