// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType37Choice.Code))]
    [KnownType(typeof(RateType37Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType37Choice.Code), nameof(RateType37Choice.Code))]
    [JsonDerivedType(typeof(RateType37Choice.Proprietary), nameof(RateType37Choice.Proprietary))]
    [IsoId("_IvM8wUELEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type 37 Choice")]
    public abstract record RateType37Choice_ { }
}
