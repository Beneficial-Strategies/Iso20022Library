// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType12Choice.Code))]
    [KnownType(typeof(ExposureType12Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType12Choice.Code), nameof(ExposureType12Choice.Code))]
    [JsonDerivedType(
        typeof(ExposureType12Choice.Proprietary),
        nameof(ExposureType12Choice.Proprietary)
    )]
    [IsoId("_iHJX4V27EeS_LPIA7qJ58w")]
    [DisplayName("Exposure Type 12 Choice")]
    public abstract record ExposureType12Choice_ { }
}
