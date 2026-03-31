// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between rate, amount and not specified.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat1Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat1Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat1Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat1Choice.Rate),
        nameof(RateAndAmountFormat1Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat1Choice.Amount),
        nameof(RateAndAmountFormat1Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat1Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat1Choice.NotSpecifiedRate)
    )]
    [IsoId("_UPrqg9p-Ed-ak6NoX_4Aeg_238520249")]
    [DisplayName("Rate And Amount Format 1 Choice")]
    public abstract record RateAndAmountFormat1Choice_ { }
}
