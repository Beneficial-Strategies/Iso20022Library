// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express a price.
    /// </summary>
    [KnownType(typeof(PriceFormat2Choice.Amount))]
    [KnownType(typeof(PriceFormat2Choice.Rate))]
    [KnownType(typeof(PriceFormat2Choice.NotSpecified))]
    [JsonDerivedType(typeof(PriceFormat2Choice.Amount),nameof(PriceFormat2Choice.Amount))]
    [JsonDerivedType(typeof(PriceFormat2Choice.Rate),nameof(PriceFormat2Choice.Rate))]
    [JsonDerivedType(typeof(PriceFormat2Choice.NotSpecified),nameof(PriceFormat2Choice.NotSpecified))]
    [IsoId("_QatkG9p-Ed-ak6NoX_4Aeg_-495676528")]
    [DisplayName("Price Format 2 Choice")]
    public abstract partial record PriceFormat2Choice_
    {
    }
}
