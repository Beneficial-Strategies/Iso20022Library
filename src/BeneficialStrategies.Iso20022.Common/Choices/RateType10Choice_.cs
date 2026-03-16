// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType10Choice.Code))]
    [KnownType(typeof(RateType10Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType10Choice.Code), nameof(RateType10Choice.Code))]
    [JsonDerivedType(typeof(RateType10Choice.Proprietary), nameof(RateType10Choice.Proprietary))]
    [IsoId("_Q2bPt9p-Ed-ak6NoX_4Aeg_1022387938")]
    [DisplayName("Rate Type 10 Choice")]
    public abstract record RateType10Choice_ { }
}
