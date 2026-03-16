// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Characteristics of one or all standing orders set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(StandingOrderOrAll2Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrAll2Choice.AllStandingOrders))]
    [JsonDerivedType(
        typeof(StandingOrderOrAll2Choice.StandingOrder),
        nameof(StandingOrderOrAll2Choice.StandingOrder)
    )]
    [JsonDerivedType(
        typeof(StandingOrderOrAll2Choice.AllStandingOrders),
        nameof(StandingOrderOrAll2Choice.AllStandingOrders)
    )]
    [IsoId("_HmQvMW4-EeiU9cctagi5ow")]
    [DisplayName("Standing Order Or All 2 Choice")]
    public abstract record StandingOrderOrAll2Choice_ { }
}
