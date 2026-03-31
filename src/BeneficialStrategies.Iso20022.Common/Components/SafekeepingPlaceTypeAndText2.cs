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
[IsoId("_SfVHMNp-Ed-ak6NoX_4Aeg_813979411")]
[DisplayName("Safekeeping Place Type And Text")]
public record SafekeepingPlaceTypeAndText2
{
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_SfVHMdp-Ed-ak6NoX_4Aeg_813979454")]
    [DisplayName("Safekeeping Place Type")]
    [IsoXmlTag("SfkpgPlcTp")]
    public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; }

    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    [IsoId("_SfVHMtp-Ed-ak6NoX_4Aeg_813979766")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }
}
