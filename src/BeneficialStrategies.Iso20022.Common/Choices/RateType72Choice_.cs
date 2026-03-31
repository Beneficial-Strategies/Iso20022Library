// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType72Choice.Code))]
    [KnownType(typeof(RateType72Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType72Choice.Code), nameof(RateType72Choice.Code))]
    [JsonDerivedType(typeof(RateType72Choice.Proprietary), nameof(RateType72Choice.Proprietary))]
    [IsoId("_skrJd83wEee5nJBZsW8MFQ")]
    [DisplayName("Rate Type 72 Choice")]
    public abstract record RateType72Choice_ { }
}
