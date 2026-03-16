// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType2Choice.Code))]
    [KnownType(typeof(MarketType2Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType2Choice.Code), nameof(MarketType2Choice.Code))]
    [JsonDerivedType(typeof(MarketType2Choice.Proprietary), nameof(MarketType2Choice.Proprietary))]
    [IsoId("_Qwwskdp-Ed-ak6NoX_4Aeg_-2098859574")]
    [DisplayName("Market Type 2 Choice")]
    public abstract record MarketType2Choice_ { }
}
