// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Characteristics of one or all standing orders set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(StandingOrderOrAll3Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrAll3Choice.AllStandingOrders))]
    [JsonDerivedType(
        typeof(StandingOrderOrAll3Choice.StandingOrder),
        nameof(StandingOrderOrAll3Choice.StandingOrder)
    )]
    [JsonDerivedType(
        typeof(StandingOrderOrAll3Choice.AllStandingOrders),
        nameof(StandingOrderOrAll3Choice.AllStandingOrders)
    )]
    [IsoId("_ewVxkdcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order Or All 3 Choice")]
    public abstract record StandingOrderOrAll3Choice_ { }
}
