// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the place of safekeeping expressed as a code and a narrative description.
/// </summary>
[IsoId("_cdSQE5KQEeWHWpTQn1FFVg")]
[DisplayName("Safekeeping Place Type And Text")]
public record SafekeepingPlaceTypeAndText9
{
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_cdSQFZKQEeWHWpTQn1FFVg")]
    [DisplayName("Safekeeping Place Type")]
    [IsoXmlTag("SfkpgPlcTp")]
    public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; }

    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    [IsoId("_cdSQHZKQEeWHWpTQn1FFVg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
    [StringLength(maximumLength: 30, MinimumLength = 1)]
    public IsoRestrictedFINXMax30Text? Identification { get; init; }
}
