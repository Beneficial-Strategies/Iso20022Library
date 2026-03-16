// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// expressed as a ISO20022 code.
    /// </summary>
    [KnownType(typeof(TradeDate4Choice.Date))]
    [KnownType(typeof(TradeDate4Choice.Value))]
    [JsonDerivedType(typeof(TradeDate4Choice.Date), nameof(TradeDate4Choice.Date))]
    [JsonDerivedType(typeof(TradeDate4Choice.Value), nameof(TradeDate4Choice.Value))]
    [IsoId("_AXK_UdokEeC60axPepSq7g_-1712034418")]
    [DisplayName("Trade Date 4 Choice")]
    public abstract record TradeDate4Choice_ { }
}
