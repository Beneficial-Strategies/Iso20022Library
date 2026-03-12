// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType83Choice.Code))]
    [KnownType(typeof(RateType83Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType83Choice.Code),nameof(RateType83Choice.Code))]
    [JsonDerivedType(typeof(RateType83Choice.Proprietary),nameof(RateType83Choice.Proprietary))]
    [IsoId("_-lxHTQVSEeqjd8n6wD9JVw")]
    [DisplayName("Rate Type 83 Choice")]
    public abstract partial record RateType83Choice_
    {
    }
}
