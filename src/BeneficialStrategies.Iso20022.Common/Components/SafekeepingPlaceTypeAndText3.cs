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
[IsoId("_SfeRI9p-Ed-ak6NoX_4Aeg_-587624791")]
[DisplayName("Safekeeping Place Type And Text")]
public record SafekeepingPlaceTypeAndText3
{
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_SfeRJNp-Ed-ak6NoX_4Aeg_-587624774")]
    [DisplayName("Safekeeping Place Type")]
    [IsoXmlTag("SfkpgPlcTp")]
    public required SafekeepingPlace3Code SafekeepingPlaceType { get; init; }

    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    [IsoId("_SfeRJdp-Ed-ak6NoX_4Aeg_-587624508")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }
}
