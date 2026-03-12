// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(LimitCriteria6Choice.QueryName))]
    [KnownType(typeof(LimitCriteria6Choice.NewCriteria))]
    [JsonDerivedType(typeof(LimitCriteria6Choice.QueryName),nameof(LimitCriteria6Choice.QueryName))]
    [JsonDerivedType(typeof(LimitCriteria6Choice.NewCriteria),nameof(LimitCriteria6Choice.NewCriteria))]
    [IsoId("_FDP_524-EeiU9cctagi5ow")]
    [DisplayName("Limit Criteria 6 Choice")]
    public abstract partial record LimitCriteria6Choice_
    {
    }
}
