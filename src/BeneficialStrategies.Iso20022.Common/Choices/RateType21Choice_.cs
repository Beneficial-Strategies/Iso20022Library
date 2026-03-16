// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType21Choice.Code))]
    [KnownType(typeof(RateType21Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType21Choice.Code), nameof(RateType21Choice.Code))]
    [JsonDerivedType(typeof(RateType21Choice.Proprietary), nameof(RateType21Choice.Proprietary))]
    [IsoId("_OuazSRFbEeKp2ZN13DI_pA")]
    [DisplayName("Rate Type 21 Choice")]
    public abstract record RateType21Choice_ { }
}
