// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the rate.
    /// </summary>
    [KnownType(typeof(RateType35Choice.Code))]
    [KnownType(typeof(RateType35Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType35Choice.Code),nameof(RateType35Choice.Code))]
    [JsonDerivedType(typeof(RateType35Choice.Proprietary),nameof(RateType35Choice.Proprietary))]
    [IsoId("_4YCkYTqkEeWyoP0PbocV1Q")]
    [DisplayName("Rate Type 35 Choice")]
    public abstract partial record RateType35Choice_
    {
    }
}
