// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate status.
    /// </summary>
    [KnownType(typeof(RateStatus4Choice.Code))]
    [KnownType(typeof(RateStatus4Choice.Proprietary))]
    [JsonDerivedType(typeof(RateStatus4Choice.Code), nameof(RateStatus4Choice.Code))]
    [JsonDerivedType(typeof(RateStatus4Choice.Proprietary), nameof(RateStatus4Choice.Proprietary))]
    [IsoId("_cj9f_5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Status 4 Choice")]
    public abstract record RateStatus4Choice_ { }
}
