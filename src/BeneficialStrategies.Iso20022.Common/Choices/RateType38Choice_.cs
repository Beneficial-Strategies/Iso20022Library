// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType38Choice.Code))]
    [KnownType(typeof(RateType38Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType38Choice.Code), nameof(RateType38Choice.Code))]
    [JsonDerivedType(typeof(RateType38Choice.Proprietary), nameof(RateType38Choice.Proprietary))]
    [IsoId("_nGufYUEMEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type 38 Choice")]
    public abstract record RateType38Choice_ { }
}
