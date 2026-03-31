// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType9Choice.Code))]
    [KnownType(typeof(ExposureType9Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType9Choice.Code), nameof(ExposureType9Choice.Code))]
    [JsonDerivedType(
        typeof(ExposureType9Choice.Proprietary),
        nameof(ExposureType9Choice.Proprietary)
    )]
    [IsoId("_Aav3wdokEeC60axPepSq7g_944597238")]
    [DisplayName("Exposure Type 9 Choice")]
    public abstract record ExposureType9Choice_ { }
}
