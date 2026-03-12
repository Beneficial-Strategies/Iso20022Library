// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmountOrUnknown2Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown2Choice.Amount))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown2Choice.UnknownIndicator))]
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknown2Choice.Rate),nameof(PriceRateOrAmountOrUnknown2Choice.Rate))]
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknown2Choice.Amount),nameof(PriceRateOrAmountOrUnknown2Choice.Amount))]
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknown2Choice.UnknownIndicator),nameof(PriceRateOrAmountOrUnknown2Choice.UnknownIndicator))]
    [IsoId("_LWuZEbQCEee1Ke-6rZgsrA")]
    [DisplayName("Price Rate Or Amount Or Unknown 2 Choice")]
    public abstract partial record PriceRateOrAmountOrUnknown2Choice_
    {
    }
}
