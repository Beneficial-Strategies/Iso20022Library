// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage rate or a rate name.
    /// </summary>
    [KnownType(typeof(RateOrName1Choice.Rate))]
    [KnownType(typeof(RateOrName1Choice.RateName))]
    [JsonDerivedType(typeof(RateOrName1Choice.Rate), nameof(RateOrName1Choice.Rate))]
    [JsonDerivedType(typeof(RateOrName1Choice.RateName), nameof(RateOrName1Choice.RateName))]
    [IsoId("_Q-xTaNp-Ed-ak6NoX_4Aeg_-1686411263")]
    [DisplayName("Rate Or Name 1 Choice")]
    public abstract record RateOrName1Choice_ { }
}
