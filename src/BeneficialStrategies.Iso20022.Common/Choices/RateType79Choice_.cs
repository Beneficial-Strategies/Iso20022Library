// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType79Choice.Code))]
    [KnownType(typeof(RateType79Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType79Choice.Code),nameof(RateType79Choice.Code))]
    [JsonDerivedType(typeof(RateType79Choice.Proprietary),nameof(RateType79Choice.Proprietary))]
    [IsoId("_iftIbeXsEemEj48jhmlA0Q")]
    [DisplayName("Rate Type 79 Choice")]
    public abstract partial record RateType79Choice_
    {
    }
}
