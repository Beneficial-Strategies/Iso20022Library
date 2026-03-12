// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType23Choice.Code))]
    [KnownType(typeof(RateType23Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType23Choice.Code),nameof(RateType23Choice.Code))]
    [JsonDerivedType(typeof(RateType23Choice.Proprietary),nameof(RateType23Choice.Proprietary))]
    [IsoId("_3LapmRLnEeKJ5uSjVyVvug")]
    [DisplayName("Rate Type 23 Choice")]
    public abstract partial record RateType23Choice_
    {
    }
}
