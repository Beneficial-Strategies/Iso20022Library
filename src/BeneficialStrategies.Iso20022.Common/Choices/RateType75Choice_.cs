// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType75Choice.Code))]
    [KnownType(typeof(RateType75Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType75Choice.Code), nameof(RateType75Choice.Code))]
    [JsonDerivedType(typeof(RateType75Choice.Proprietary), nameof(RateType75Choice.Proprietary))]
    [IsoId("_sk2Hoc3wEee5nJBZsW8MFQ")]
    [DisplayName("Rate Type 75 Choice")]
    public abstract record RateType75Choice_ { }
}
