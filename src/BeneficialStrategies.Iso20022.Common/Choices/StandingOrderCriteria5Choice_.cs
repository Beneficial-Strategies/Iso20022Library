// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Standing Order Criteria5Choice.
    /// </summary>
    [KnownType(typeof(StandingOrderCriteria5Choice.NewCriteria))]
    [KnownType(typeof(StandingOrderCriteria5Choice.QueryName))]
    [JsonDerivedType(
        typeof(StandingOrderCriteria5Choice.NewCriteria),
        nameof(StandingOrderCriteria5Choice.NewCriteria)
    )]
    [JsonDerivedType(
        typeof(StandingOrderCriteria5Choice.QueryName),
        nameof(StandingOrderCriteria5Choice.QueryName)
    )]
    [IsoId("_0ob11TEyEe6g-ffJsqGiSA")]
    [DisplayName("Standing Order Criteria5Choice")]
    public abstract record StandingOrderCriteria5Choice_ { }
}
