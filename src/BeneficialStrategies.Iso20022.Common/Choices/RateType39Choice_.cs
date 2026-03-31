// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType39Choice.Code))]
    [KnownType(typeof(RateType39Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType39Choice.Code), nameof(RateType39Choice.Code))]
    [JsonDerivedType(typeof(RateType39Choice.Proprietary), nameof(RateType39Choice.Proprietary))]
    [IsoId("_gru8cUENEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type 39 Choice")]
    public abstract record RateType39Choice_ { }
}
