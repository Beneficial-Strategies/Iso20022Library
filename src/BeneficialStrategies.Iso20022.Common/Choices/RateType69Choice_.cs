// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType69Choice.Code))]
    [KnownType(typeof(RateType69Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType69Choice.Code),nameof(RateType69Choice.Code))]
    [JsonDerivedType(typeof(RateType69Choice.Proprietary),nameof(RateType69Choice.Proprietary))]
    [IsoId("_AFujLZb8Eee8S7xwGG7Veg")]
    [DisplayName("Rate Type 69 Choice")]
    public abstract partial record RateType69Choice_
    {
    }
}
