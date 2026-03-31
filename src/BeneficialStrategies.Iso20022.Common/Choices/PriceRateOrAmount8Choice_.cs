// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Rate Or Amount8Choice.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmount8Choice.Amount))]
    [KnownType(typeof(PriceRateOrAmount8Choice.Rate))]
    [JsonDerivedType(
        typeof(PriceRateOrAmount8Choice.Amount),
        nameof(PriceRateOrAmount8Choice.Amount)
    )]
    [JsonDerivedType(typeof(PriceRateOrAmount8Choice.Rate), nameof(PriceRateOrAmount8Choice.Rate))]
    [IsoId("_qbKxCZK5Ee-l-O3vIHRmRw")]
    [DisplayName("Price Rate Or Amount8Choice")]
    public abstract record PriceRateOrAmount8Choice_ { }
}
