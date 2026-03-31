// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType18Choice.Code))]
    [KnownType(typeof(ExposureType18Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType18Choice.Code), nameof(ExposureType18Choice.Code))]
    [JsonDerivedType(
        typeof(ExposureType18Choice.Proprietary),
        nameof(ExposureType18Choice.Proprietary)
    )]
    [IsoId("_G0G8oZCCEeakHoV5BVecAQ")]
    [DisplayName("Exposure Type 18 Choice")]
    public abstract record ExposureType18Choice_ { }
}
