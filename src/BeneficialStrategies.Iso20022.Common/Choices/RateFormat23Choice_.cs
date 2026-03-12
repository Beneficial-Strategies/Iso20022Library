// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat23Choice.Rate))]
    [KnownType(typeof(RateFormat23Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat23Choice.Rate),nameof(RateFormat23Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat23Choice.Amount),nameof(RateFormat23Choice.Amount))]
    [IsoId("_skvaG83wEee5nJBZsW8MFQ")]
    [DisplayName("Rate Format 23 Choice")]
    public abstract partial record RateFormat23Choice_
    {
    }
}
