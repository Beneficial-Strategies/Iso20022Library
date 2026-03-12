// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat12Choice.Rate))]
    [KnownType(typeof(RateFormat12Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat12Choice.Rate),nameof(RateFormat12Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat12Choice.NotSpecifiedRate),nameof(RateFormat12Choice.NotSpecifiedRate))]
    [IsoId("_t7-PYSqiEeObprHJy8Zrxg")]
    [DisplayName("Rate Format 12 Choice")]
    public abstract partial record RateFormat12Choice_
    {
    }
}
