// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType6Choice.Code))]
    [KnownType(typeof(RateType6Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType6Choice.Code), nameof(RateType6Choice.Code))]
    [JsonDerivedType(typeof(RateType6Choice.Proprietary), nameof(RateType6Choice.Proprietary))]
    [IsoId("_Q2kZotp-Ed-ak6NoX_4Aeg_-382627334")]
    [DisplayName("Rate Type 6 Choice")]
    public abstract record RateType6Choice_ { }
}
