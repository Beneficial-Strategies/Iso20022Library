// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [KnownType(typeof(ExposureType23Choice.Code))]
    [KnownType(typeof(ExposureType23Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType23Choice.Code),nameof(ExposureType23Choice.Code))]
    [JsonDerivedType(typeof(ExposureType23Choice.Proprietary),nameof(ExposureType23Choice.Proprietary))]
    [IsoId("_LIZvcSs9EeySlt9bF77XfA")]
    [DisplayName("Exposure Type 23 Choice")]
    public abstract partial record ExposureType23Choice_
    {
    }
}
