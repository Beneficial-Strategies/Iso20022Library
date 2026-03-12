// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType76Choice.Code))]
    [KnownType(typeof(RateType76Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType76Choice.Code),nameof(RateType76Choice.Code))]
    [JsonDerivedType(typeof(RateType76Choice.Proprietary),nameof(RateType76Choice.Proprietary))]
    [IsoId("_CS5CreXsEemEj48jhmlA0Q")]
    [DisplayName("Rate Type 76 Choice")]
    public abstract partial record RateType76Choice_
    {
    }
}
