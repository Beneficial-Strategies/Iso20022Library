// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade market identification using a externally defined code or proprietary identification.
    /// </summary>
    [KnownType(typeof(TradeMarket1Choice.Code))]
    [KnownType(typeof(TradeMarket1Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeMarket1Choice.Code), nameof(TradeMarket1Choice.Code))]
    [JsonDerivedType(
        typeof(TradeMarket1Choice.Proprietary),
        nameof(TradeMarket1Choice.Proprietary)
    )]
    [IsoId("_OTgzMzEx-AOSNFX-8224498")]
    [DisplayName("Trade Market 1 Choice")]
    public abstract record TradeMarket1Choice_ { }
}
