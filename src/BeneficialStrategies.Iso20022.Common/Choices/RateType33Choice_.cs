// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType33Choice.Code))]
    [KnownType(typeof(RateType33Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType33Choice.Code), nameof(RateType33Choice.Code))]
    [JsonDerivedType(typeof(RateType33Choice.Proprietary), nameof(RateType33Choice.Proprietary))]
    [IsoId("_0ESe0UEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type 33 Choice")]
    public abstract record RateType33Choice_ { }
}
