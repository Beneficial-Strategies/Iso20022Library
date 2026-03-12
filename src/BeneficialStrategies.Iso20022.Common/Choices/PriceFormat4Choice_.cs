// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express a price.
    /// </summary>
    [KnownType(typeof(PriceFormat4Choice.Amount))]
    [KnownType(typeof(PriceFormat4Choice.Rate))]
    [KnownType(typeof(PriceFormat4Choice.NotSpecified))]
    [KnownType(typeof(PriceFormat4Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat4Choice.Amount),nameof(PriceFormat4Choice.Amount))]
    [JsonDerivedType(typeof(PriceFormat4Choice.Rate),nameof(PriceFormat4Choice.Rate))]
    [JsonDerivedType(typeof(PriceFormat4Choice.NotSpecified),nameof(PriceFormat4Choice.NotSpecified))]
    [JsonDerivedType(typeof(PriceFormat4Choice.IndexPoints),nameof(PriceFormat4Choice.IndexPoints))]
    [IsoId("_QbJo8tp-Ed-ak6NoX_4Aeg_-733600915")]
    [DisplayName("Price Format 4 Choice")]
    public abstract partial record PriceFormat4Choice_
    {
    }
}
