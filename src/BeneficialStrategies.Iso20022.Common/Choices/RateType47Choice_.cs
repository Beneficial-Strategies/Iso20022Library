// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType47Choice.Code))]
    [KnownType(typeof(RateType47Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType47Choice.Code),nameof(RateType47Choice.Code))]
    [JsonDerivedType(typeof(RateType47Choice.Proprietary),nameof(RateType47Choice.Proprietary))]
    [IsoId("_cj-uN5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type 47 Choice")]
    public abstract partial record RateType47Choice_
    {
    }
}
