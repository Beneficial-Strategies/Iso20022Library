// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType24Choice.Code))]
    [KnownType(typeof(ExposureType24Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType24Choice.Code), nameof(ExposureType24Choice.Code))]
    [JsonDerivedType(
        typeof(ExposureType24Choice.Proprietary),
        nameof(ExposureType24Choice.Proprietary)
    )]
    [IsoId("_ciETATi8Eeydid5dcNPKvg")]
    [DisplayName("Exposure Type 24 Choice")]
    public abstract record ExposureType24Choice_ { }
}
