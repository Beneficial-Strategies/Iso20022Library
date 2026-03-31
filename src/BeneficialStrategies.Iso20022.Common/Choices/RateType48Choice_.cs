// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType48Choice.Code))]
    [KnownType(typeof(RateType48Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType48Choice.Code), nameof(RateType48Choice.Code))]
    [JsonDerivedType(typeof(RateType48Choice.Proprietary), nameof(RateType48Choice.Proprietary))]
    [IsoId("_ckCY7JKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type 48 Choice")]
    public abstract record RateType48Choice_ { }
}
