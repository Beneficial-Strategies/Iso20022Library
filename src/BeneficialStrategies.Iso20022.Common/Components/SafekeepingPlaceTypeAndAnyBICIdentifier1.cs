// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Place identification of the place of safekeeping expressed as a code and a BIC.
/// </summary>
[IsoId("_Shax4tp-Ed-ak6NoX_4Aeg_1122224444")]
[DisplayName("Safekeeping Place Type And Any BIC Identifier")]
public record SafekeepingPlaceTypeAndAnyBICIdentifier1
{
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_Shax49p-Ed-ak6NoX_4Aeg_1122224462")]
    [DisplayName("Safekeeping Place Type")]
    [IsoXmlTag("SfkpgPlcTp")]
    public required SafekeepingPlace1Code SafekeepingPlaceType { get; init; }

    /// <summary>
    /// Place of safekeeping.
    /// </summary>
    [IsoId("_Shax5Np-Ed-ak6NoX_4Aeg_1122224574")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier Identification { get; init; }
}
