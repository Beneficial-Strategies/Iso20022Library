// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice number format.
    /// </summary>
    [KnownType(typeof(Number24Choice.NumberIdentification))]
    [KnownType(typeof(Number24Choice.Proprietary))]
    [JsonDerivedType(typeof(Number24Choice.NumberIdentification),nameof(Number24Choice.NumberIdentification))]
    [JsonDerivedType(typeof(Number24Choice.Proprietary),nameof(Number24Choice.Proprietary))]
    [IsoId("_6OTyMZBfEeakHoV5BVecAQ")]
    [DisplayName("Number 24 Choice")]
    public abstract partial record Number24Choice_
    {
    }
}
