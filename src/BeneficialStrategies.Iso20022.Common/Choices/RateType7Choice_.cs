// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType7Choice.Code))]
    [KnownType(typeof(RateType7Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType7Choice.Code), nameof(RateType7Choice.Code))]
    [JsonDerivedType(typeof(RateType7Choice.Proprietary), nameof(RateType7Choice.Proprietary))]
    [IsoId("_Q2bPutp-Ed-ak6NoX_4Aeg_655622014")]
    [DisplayName("Rate Type 7 Choice")]
    public abstract record RateType7Choice_ { }
}
