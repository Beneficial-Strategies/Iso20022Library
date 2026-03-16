// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Standing Order Or All4Choice.
    /// </summary>
    [KnownType(typeof(StandingOrderOrAll4Choice.AllStandingOrders))]
    [KnownType(typeof(StandingOrderOrAll4Choice.StandingOrder))]
    [JsonDerivedType(typeof(StandingOrderOrAll4Choice.AllStandingOrders),nameof(StandingOrderOrAll4Choice.AllStandingOrders))]
    [JsonDerivedType(typeof(StandingOrderOrAll4Choice.StandingOrder),nameof(StandingOrderOrAll4Choice.StandingOrder))]
    [IsoId("_6jk-kTEyEe6g-ffJsqGiSA")]
    [DisplayName("Standing Order Or All4Choice")]
    public abstract partial record StandingOrderOrAll4Choice_
    {
    }
}
