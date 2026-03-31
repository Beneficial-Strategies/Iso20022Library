// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType17Choice.Code))]
    [KnownType(typeof(ExposureType17Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType17Choice.Code), nameof(ExposureType17Choice.Code))]
    [JsonDerivedType(
        typeof(ExposureType17Choice.Proprietary),
        nameof(ExposureType17Choice.Proprietary)
    )]
    [IsoId("_yLaMcZj-EeWn2ur3BXxtdg")]
    [DisplayName("Exposure Type 17 Choice")]
    public abstract record ExposureType17Choice_ { }
}
