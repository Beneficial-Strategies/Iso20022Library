// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(StandingOrderCriteria4Choice.QueryName))]
    [KnownType(typeof(StandingOrderCriteria4Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(StandingOrderCriteria4Choice.QueryName),
        nameof(StandingOrderCriteria4Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(StandingOrderCriteria4Choice.NewCriteria),
        nameof(StandingOrderCriteria4Choice.NewCriteria)
    )]
    [IsoId("_gcLoVdcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order Criteria 4 Choice")]
    public abstract record StandingOrderCriteria4Choice_ { }
}
