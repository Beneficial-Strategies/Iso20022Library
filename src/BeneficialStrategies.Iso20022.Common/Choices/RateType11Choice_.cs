// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType11Choice.Code))]
    [KnownType(typeof(RateType11Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType11Choice.Code), nameof(RateType11Choice.Code))]
    [JsonDerivedType(typeof(RateType11Choice.Proprietary), nameof(RateType11Choice.Proprietary))]
    [IsoId("_Q2bPtNp-Ed-ak6NoX_4Aeg_-1984207687")]
    [DisplayName("Rate Type 11 Choice")]
    public abstract record RateType11Choice_ { }
}
