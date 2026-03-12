// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between rate and amount.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat5Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat5Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat5Choice.Rate),nameof(RateAndAmountFormat5Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat5Choice.Amount),nameof(RateAndAmountFormat5Choice.Amount))]
    [IsoId("_UOCrwNp-Ed-ak6NoX_4Aeg_722186259")]
    [DisplayName("Rate And Amount Format 5 Choice")]
    public abstract partial record RateAndAmountFormat5Choice_
    {
    }
}
