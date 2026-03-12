// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType17Choice.Code))]
    [KnownType(typeof(RateType17Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType17Choice.Code),nameof(RateType17Choice.Code))]
    [JsonDerivedType(typeof(RateType17Choice.Proprietary),nameof(RateType17Choice.Proprietary))]
    [IsoId("_uR6T4finEd-0JoSb983HHw")]
    [DisplayName("Rate Type 17 Choice")]
    public abstract partial record RateType17Choice_
    {
    }
}
