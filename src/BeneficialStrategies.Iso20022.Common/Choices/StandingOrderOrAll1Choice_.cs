// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Characteristics of one or all standing orders set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(StandingOrderOrAll1Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrAll1Choice.AllStandingOrders))]
    [JsonDerivedType(
        typeof(StandingOrderOrAll1Choice.StandingOrder),
        nameof(StandingOrderOrAll1Choice.StandingOrder)
    )]
    [JsonDerivedType(
        typeof(StandingOrderOrAll1Choice.AllStandingOrders),
        nameof(StandingOrderOrAll1Choice.AllStandingOrders)
    )]
    [IsoId("_79r04KMgEeCJ6YNENx4h-w_1637966113")]
    [DisplayName("Standing Order Or All 1 Choice")]
    public abstract record StandingOrderOrAll1Choice_ { }
}
