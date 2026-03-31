// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express a price.
    /// </summary>
    [KnownType(typeof(PriceFormat3Choice.Amount))]
    [KnownType(typeof(PriceFormat3Choice.Rate))]
    [JsonDerivedType(typeof(PriceFormat3Choice.Amount), nameof(PriceFormat3Choice.Amount))]
    [JsonDerivedType(typeof(PriceFormat3Choice.Rate), nameof(PriceFormat3Choice.Rate))]
    [IsoId("_Qa2uAtp-Ed-ak6NoX_4Aeg_-1480216475")]
    [DisplayName("Price Format 3 Choice")]
    public abstract record PriceFormat3Choice_ { }
}
