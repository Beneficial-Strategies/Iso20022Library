// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of price type.
    /// </summary>
    [KnownType(typeof(PriceType1Choice.Market))]
    [KnownType(typeof(PriceType1Choice.Indicative))]
    [JsonDerivedType(typeof(PriceType1Choice.Market),nameof(PriceType1Choice.Market))]
    [JsonDerivedType(typeof(PriceType1Choice.Indicative),nameof(PriceType1Choice.Indicative))]
    [IsoId("_RdnLhdp-Ed-ak6NoX_4Aeg_549795611")]
    [DisplayName("Price Type 1 Choice")]
    public abstract partial record PriceType1Choice_
    {
    }
}
