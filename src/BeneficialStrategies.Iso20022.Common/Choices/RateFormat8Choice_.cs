// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat8Choice.Rate))]
    [KnownType(typeof(RateFormat8Choice.Amount))]
    [KnownType(typeof(RateFormat8Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat8Choice.Rate),nameof(RateFormat8Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat8Choice.Amount),nameof(RateFormat8Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat8Choice.NotSpecifiedRate),nameof(RateFormat8Choice.NotSpecifiedRate))]
    [IsoId("_VA1AzhLtEeKJ5uSjVyVvug")]
    [DisplayName("Rate Format 8 Choice")]
    public abstract partial record RateFormat8Choice_
    {
    }
}
