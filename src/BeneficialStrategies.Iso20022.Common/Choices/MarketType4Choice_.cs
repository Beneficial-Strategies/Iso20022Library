// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType4Choice.Code))]
    [KnownType(typeof(MarketType4Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType4Choice.Code), nameof(MarketType4Choice.Code))]
    [JsonDerivedType(typeof(MarketType4Choice.Proprietary), nameof(MarketType4Choice.Proprietary))]
    [IsoId("_Qwm7l9p-Ed-ak6NoX_4Aeg_-1402096058")]
    [DisplayName("Market Type 4 Choice")]
    public abstract record MarketType4Choice_ { }
}
