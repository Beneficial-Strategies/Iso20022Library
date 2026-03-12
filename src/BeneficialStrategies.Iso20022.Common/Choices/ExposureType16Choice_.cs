// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType16Choice.Code))]
    [KnownType(typeof(ExposureType16Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType16Choice.Code),nameof(ExposureType16Choice.Code))]
    [JsonDerivedType(typeof(ExposureType16Choice.Proprietary),nameof(ExposureType16Choice.Proprietary))]
    [IsoId("_UCM-ETtEEeWRTLSN0i0tng")]
    [DisplayName("Exposure Type 16 Choice")]
    public abstract partial record ExposureType16Choice_
    {
    }
}
