// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade type.
    /// </summary>
    [KnownType(typeof(TradeType3Choice.Code))]
    [KnownType(typeof(TradeType3Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeType3Choice.Code), nameof(TradeType3Choice.Code))]
    [JsonDerivedType(typeof(TradeType3Choice.Proprietary), nameof(TradeType3Choice.Proprietary))]
    [IsoId("_AXK_VNokEeC60axPepSq7g_1036683849")]
    [DisplayName("Trade Type 3 Choice")]
    public abstract record TradeType3Choice_ { }
}
