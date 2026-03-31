// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade type.
    /// </summary>
    [KnownType(typeof(TradeType4Choice.Code))]
    [KnownType(typeof(TradeType4Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeType4Choice.Code), nameof(TradeType4Choice.Code))]
    [JsonDerivedType(typeof(TradeType4Choice.Proprietary), nameof(TradeType4Choice.Proprietary))]
    [IsoId("_6gAJsZBgEeakHoV5BVecAQ")]
    [DisplayName("Trade Type 4 Choice")]
    public abstract record TradeType4Choice_ { }
}
