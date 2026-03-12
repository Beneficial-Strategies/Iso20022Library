// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType46Choice.Code))]
    [KnownType(typeof(RateType46Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType46Choice.Code),nameof(RateType46Choice.Code))]
    [JsonDerivedType(typeof(RateType46Choice.Proprietary),nameof(RateType46Choice.Proprietary))]
    [IsoId("_cj-t_ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type 46 Choice")]
    public abstract partial record RateType46Choice_
    {
    }
}
