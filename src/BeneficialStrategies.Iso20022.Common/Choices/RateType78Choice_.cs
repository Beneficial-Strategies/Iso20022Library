// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType78Choice.Code))]
    [KnownType(typeof(RateType78Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType78Choice.Code),nameof(RateType78Choice.Code))]
    [JsonDerivedType(typeof(RateType78Choice.Proprietary),nameof(RateType78Choice.Proprietary))]
    [IsoId("_ZfXJTeXsEemEj48jhmlA0Q")]
    [DisplayName("Rate Type 78 Choice")]
    public abstract partial record RateType78Choice_
    {
    }
}
