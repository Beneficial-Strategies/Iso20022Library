// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Safekeeping Place Type And Any BIC Identifier3.
/// </summary>
[IsoId("_Rmb7gRwREe6O0NdiBuX__w")]
[DisplayName("Safekeeping Place Type And Any BIC Identifier3")]
public record SafekeepingPlaceTypeAndAnyBICIdentifier3
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoAnyBICDec2014Identifier Identification { get; init; }

    /// <summary>
    /// Safekeeping Place Type.
    /// </summary>
    [DisplayName("Safekeeping Place Type")]
    [IsoXmlTag("SfkpgPlcTp")]
    public required SafekeepingPlace1Code SafekeepingPlaceType { get; init; }
}
