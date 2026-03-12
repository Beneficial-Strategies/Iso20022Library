// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate, an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat12Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat12Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat12Choice.Rate),nameof(RateAndAmountFormat12Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat12Choice.Amount),nameof(RateAndAmountFormat12Choice.Amount))]
    [IsoId("_UOCrxtp-Ed-ak6NoX_4Aeg_1164166315")]
    [DisplayName("Rate And Amount Format 12 Choice")]
    public abstract partial record RateAndAmountFormat12Choice_
    {
    }
}
