// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a rate.
    /// </summary>
    [KnownType(typeof(RateFormat1Choice.Rate))]
    [KnownType(typeof(RateFormat1Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat1Choice.Rate), nameof(RateFormat1Choice.Rate))]
    [JsonDerivedType(
        typeof(RateFormat1Choice.NotSpecifiedRate),
        nameof(RateFormat1Choice.NotSpecifiedRate)
    )]
    [IsoId("_UPh5htp-Ed-ak6NoX_4Aeg_-1635558299")]
    [DisplayName("Rate Format 1 Choice")]
    public abstract record RateFormat1Choice_ { }
}
