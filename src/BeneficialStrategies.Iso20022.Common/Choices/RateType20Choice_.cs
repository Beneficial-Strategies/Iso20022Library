// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType20Choice.Code))]
    [KnownType(typeof(RateType20Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType20Choice.Code), nameof(RateType20Choice.Code))]
    [JsonDerivedType(typeof(RateType20Choice.Proprietary), nameof(RateType20Choice.Proprietary))]
    [IsoId("_mvWSKRFaEeKp2ZN13DI_pA")]
    [DisplayName("Rate Type 20 Choice")]
    public abstract record RateType20Choice_ { }
}
