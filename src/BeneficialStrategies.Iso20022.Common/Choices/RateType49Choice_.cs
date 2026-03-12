// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType49Choice.Code))]
    [KnownType(typeof(RateType49Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType49Choice.Code),nameof(RateType49Choice.Code))]
    [JsonDerivedType(typeof(RateType49Choice.Proprietary),nameof(RateType49Choice.Proprietary))]
    [IsoId("_ckMxC5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type 49 Choice")]
    public abstract partial record RateType49Choice_
    {
    }
}
