// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of liquidity transfer standing order.
    /// </summary>
    [KnownType(typeof(StandingOrderType1Choice.Code))]
    [KnownType(typeof(StandingOrderType1Choice.Proprietary))]
    [JsonDerivedType(typeof(StandingOrderType1Choice.Code),nameof(StandingOrderType1Choice.Code))]
    [JsonDerivedType(typeof(StandingOrderType1Choice.Proprietary),nameof(StandingOrderType1Choice.Proprietary))]
    [IsoId("_73bb4KMgEeCJ6YNENx4h-w_-1191465666")]
    [DisplayName("Standing Order Type 1 Choice")]
    public abstract partial record StandingOrderType1Choice_
    {
    }
}
