// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType74Choice.Code))]
    [KnownType(typeof(RateType74Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType74Choice.Code), nameof(RateType74Choice.Code))]
    [JsonDerivedType(typeof(RateType74Choice.Proprietary), nameof(RateType74Choice.Proprietary))]
    [IsoId("_sk1g183wEee5nJBZsW8MFQ")]
    [DisplayName("Rate Type 74 Choice")]
    public abstract record RateType74Choice_ { }
}
