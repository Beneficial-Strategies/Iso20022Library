// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType10Choice.Code))]
    [KnownType(typeof(ExposureType10Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType10Choice.Code),nameof(ExposureType10Choice.Code))]
    [JsonDerivedType(typeof(ExposureType10Choice.Proprietary),nameof(ExposureType10Choice.Proprietary))]
    [IsoId("_5Sf5QSTwEeOSHvJr_wacAw")]
    [DisplayName("Exposure Type 10 Choice")]
    public abstract partial record ExposureType10Choice_
    {
    }
}
