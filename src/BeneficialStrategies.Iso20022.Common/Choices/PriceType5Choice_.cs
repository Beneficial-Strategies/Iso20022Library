// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of price type.
    /// </summary>
    [KnownType(typeof(PriceType5Choice.Market))]
    [KnownType(typeof(PriceType5Choice.Indicative))]
    [JsonDerivedType(typeof(PriceType5Choice.Market),nameof(PriceType5Choice.Market))]
    [JsonDerivedType(typeof(PriceType5Choice.Indicative),nameof(PriceType5Choice.Indicative))]
    [IsoId("_SKL8C83yEee5nJBZsW8MFQ")]
    [DisplayName("Price Type 5 Choice")]
    public abstract partial record PriceType5Choice_
    {
    }
}
