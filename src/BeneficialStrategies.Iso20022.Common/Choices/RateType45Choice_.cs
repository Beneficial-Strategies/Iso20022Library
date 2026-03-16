// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType45Choice.Code))]
    [KnownType(typeof(RateType45Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType45Choice.Code), nameof(RateType45Choice.Code))]
    [JsonDerivedType(typeof(RateType45Choice.Proprietary), nameof(RateType45Choice.Proprietary))]
    [IsoId("_cj-HJ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type 45 Choice")]
    public abstract record RateType45Choice_ { }
}
