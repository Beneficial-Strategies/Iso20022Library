// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat58Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat58Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat58Choice.AmountPrice),nameof(PriceFormat58Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat58Choice.NotSpecifiedPrice),nameof(PriceFormat58Choice.NotSpecifiedPrice))]
    [IsoId("_ctku05KQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 58 Choice")]
    public abstract partial record PriceFormat58Choice_
    {
    }
}
