// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType73Choice.Code))]
    [KnownType(typeof(RateType73Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType73Choice.Code),nameof(RateType73Choice.Code))]
    [JsonDerivedType(typeof(RateType73Choice.Proprietary),nameof(RateType73Choice.Proprietary))]
    [IsoId("_skrJ283wEee5nJBZsW8MFQ")]
    [DisplayName("Rate Type 73 Choice")]
    public abstract partial record RateType73Choice_
    {
    }
}
