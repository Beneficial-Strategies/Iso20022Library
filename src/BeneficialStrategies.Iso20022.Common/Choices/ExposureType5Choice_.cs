// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType5Choice.Code))]
    [KnownType(typeof(ExposureType5Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType5Choice.Code),nameof(ExposureType5Choice.Code))]
    [JsonDerivedType(typeof(ExposureType5Choice.Proprietary),nameof(ExposureType5Choice.Proprietary))]
    [IsoId("_gBPhMfIxEd-dOvqmSLSz5g")]
    [DisplayName("Exposure Type 5 Choice")]
    public abstract partial record ExposureType5Choice_
    {
    }
}
