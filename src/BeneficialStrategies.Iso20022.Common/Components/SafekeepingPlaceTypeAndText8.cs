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
[IsoId("_5V6N6znTEeWV5sr121Fc8A")]
[DisplayName("Safekeeping Place Type And Text")]
public record SafekeepingPlaceTypeAndText8
{
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_51magznTEeWV5sr121Fc8A")]
    [DisplayName("Safekeeping Place Type")]
    [IsoXmlTag("SfkpgPlcTp")]
    public required SafekeepingPlace3Code SafekeepingPlaceType { get; init; }

    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    [IsoId("_51maiznTEeWV5sr121Fc8A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }
}
