// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between rate and amount.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat43Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat43Choice.Amount))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat43Choice.Rate),
        nameof(RateAndAmountFormat43Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat43Choice.Amount),
        nameof(RateAndAmountFormat43Choice.Amount)
    )]
    [IsoId("_chezk5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 43 Choice")]
    public abstract record RateAndAmountFormat43Choice_ { }
}
