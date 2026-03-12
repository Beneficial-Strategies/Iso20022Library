// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between rate and amount.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat39Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat39Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat39Choice.Rate),nameof(RateAndAmountFormat39Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat39Choice.Amount),nameof(RateAndAmountFormat39Choice.Amount))]
    [IsoId("_7YUqLUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Rate And Amount Format 39 Choice")]
    public abstract partial record RateAndAmountFormat39Choice_
    {
    }
}
