// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides an amount choice between currency or digital token.
    /// </summary>
    [KnownType(typeof(CurrencyOrDigitalTokenAmount1Choice.Amount))]
    [KnownType(typeof(CurrencyOrDigitalTokenAmount1Choice.DigitalTokenAmount))]
    [JsonDerivedType(
        typeof(CurrencyOrDigitalTokenAmount1Choice.Amount),
        nameof(CurrencyOrDigitalTokenAmount1Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(CurrencyOrDigitalTokenAmount1Choice.DigitalTokenAmount),
        nameof(CurrencyOrDigitalTokenAmount1Choice.DigitalTokenAmount)
    )]
    [IsoId("_mG0UsANhEe2-vqzwMUAewg")]
    [DisplayName("Currency Or Digital Token Amount 1 Choice")]
    public abstract record CurrencyOrDigitalTokenAmount1Choice_ { }
}
