// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(StandingOrderCriteria2Choice.QueryName))]
    [KnownType(typeof(StandingOrderCriteria2Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(StandingOrderCriteria2Choice.QueryName),
        nameof(StandingOrderCriteria2Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(StandingOrderCriteria2Choice.NewCriteria),
        nameof(StandingOrderCriteria2Choice.NewCriteria)
    )]
    [IsoId("_i0T9sZlPEee-Zps0fZQaFQ")]
    [DisplayName("Standing Order Criteria 2 Choice")]
    public abstract record StandingOrderCriteria2Choice_ { }
}
