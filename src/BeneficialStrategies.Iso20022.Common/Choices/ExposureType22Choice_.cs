// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType22Choice.Code))]
    [KnownType(typeof(ExposureType22Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType22Choice.Code), nameof(ExposureType22Choice.Code))]
    [JsonDerivedType(
        typeof(ExposureType22Choice.Proprietary),
        nameof(ExposureType22Choice.Proprietary)
    )]
    [IsoId("_hD1mMyglEey2k_sfZmJz4g")]
    [DisplayName("Exposure Type 22 Choice")]
    public abstract record ExposureType22Choice_ { }
}
