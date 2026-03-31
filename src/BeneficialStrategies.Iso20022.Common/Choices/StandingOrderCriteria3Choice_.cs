// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(StandingOrderCriteria3Choice.QueryName))]
    [KnownType(typeof(StandingOrderCriteria3Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(StandingOrderCriteria3Choice.QueryName),
        nameof(StandingOrderCriteria3Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(StandingOrderCriteria3Choice.NewCriteria),
        nameof(StandingOrderCriteria3Choice.NewCriteria)
    )]
    [IsoId("_GBYcFW4-EeiU9cctagi5ow")]
    [DisplayName("Standing Order Criteria 3 Choice")]
    public abstract record StandingOrderCriteria3Choice_ { }
}
