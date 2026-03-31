// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(LimitCriteria5Choice.QueryName))]
    [KnownType(typeof(LimitCriteria5Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(LimitCriteria5Choice.QueryName),
        nameof(LimitCriteria5Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(LimitCriteria5Choice.NewCriteria),
        nameof(LimitCriteria5Choice.NewCriteria)
    )]
    [IsoId("_PgIEV5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit Criteria 5 Choice")]
    public abstract record LimitCriteria5Choice_ { }
}
