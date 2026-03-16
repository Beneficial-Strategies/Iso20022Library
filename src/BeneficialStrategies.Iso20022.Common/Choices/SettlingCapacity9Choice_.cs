// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement capacity information.
    /// </summary>
    [KnownType(typeof(SettlingCapacity9Choice.Code))]
    [KnownType(typeof(SettlingCapacity9Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlingCapacity9Choice.Code), nameof(SettlingCapacity9Choice.Code))]
    [JsonDerivedType(
        typeof(SettlingCapacity9Choice.Proprietary),
        nameof(SettlingCapacity9Choice.Proprietary)
    )]
    [IsoId("_hOSOwZEZEeakHoV5BVecAQ")]
    [DisplayName("Settling Capacity 9 Choice")]
    public abstract record SettlingCapacity9Choice_ { }
}
