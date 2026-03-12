// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [KnownType(typeof(ExposureType21Choice.Code))]
    [KnownType(typeof(ExposureType21Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType21Choice.Code),nameof(ExposureType21Choice.Code))]
    [JsonDerivedType(typeof(ExposureType21Choice.Proprietary),nameof(ExposureType21Choice.Proprietary))]
    [IsoId("_17rh4SW1EeyT3chuyX0PgA")]
    [DisplayName("Exposure Type 21 Choice")]
    public abstract partial record ExposureType21Choice_
    {
    }
}
