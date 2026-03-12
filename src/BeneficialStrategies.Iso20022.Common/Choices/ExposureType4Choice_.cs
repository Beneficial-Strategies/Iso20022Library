// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType4Choice.Code))]
    [KnownType(typeof(ExposureType4Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType4Choice.Code),nameof(ExposureType4Choice.Code))]
    [JsonDerivedType(typeof(ExposureType4Choice.Proprietary),nameof(ExposureType4Choice.Proprietary))]
    [IsoId("_oKLSc9xKEd-tnM7aRm4nqg")]
    [DisplayName("Exposure Type 4 Choice")]
    public abstract partial record ExposureType4Choice_
    {
    }
}
