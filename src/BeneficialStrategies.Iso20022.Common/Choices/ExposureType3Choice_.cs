// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType3Choice.Code))]
    [KnownType(typeof(ExposureType3Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType3Choice.Code),nameof(ExposureType3Choice.Code))]
    [JsonDerivedType(typeof(ExposureType3Choice.Proprietary),nameof(ExposureType3Choice.Proprietary))]
    [IsoId("_UapPYdtlEd-RF5yaMAVhAw")]
    [DisplayName("Exposure Type 3 Choice")]
    public abstract partial record ExposureType3Choice_
    {
    }
}
