// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(BusinessDayCriteria3Choice.QueryName))]
    [KnownType(typeof(BusinessDayCriteria3Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(BusinessDayCriteria3Choice.QueryName),
        nameof(BusinessDayCriteria3Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(BusinessDayCriteria3Choice.NewCriteria),
        nameof(BusinessDayCriteria3Choice.NewCriteria)
    )]
    [IsoId("_x84MZ5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Day Criteria 3 Choice")]
    public abstract record BusinessDayCriteria3Choice_ { }
}
