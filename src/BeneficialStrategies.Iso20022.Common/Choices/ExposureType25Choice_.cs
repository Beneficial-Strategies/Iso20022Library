// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Exposure Type25Choice.
    /// </summary>
    [KnownType(typeof(ExposureType25Choice.Code))]
    [KnownType(typeof(ExposureType25Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType25Choice.Code),nameof(ExposureType25Choice.Code))]
    [JsonDerivedType(typeof(ExposureType25Choice.Proprietary),nameof(ExposureType25Choice.Proprietary))]
    [IsoId("_Vobk0YS2Ee-Pv9KR9bv9IA")]
    [DisplayName("Exposure Type25Choice")]
    public abstract partial record ExposureType25Choice_
    {
    }
}
