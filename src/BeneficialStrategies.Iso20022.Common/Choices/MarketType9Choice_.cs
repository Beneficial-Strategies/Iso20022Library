// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType9Choice.Code))]
    [KnownType(typeof(MarketType9Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType9Choice.Code), nameof(MarketType9Choice.Code))]
    [JsonDerivedType(typeof(MarketType9Choice.Proprietary), nameof(MarketType9Choice.Proprietary))]
    [IsoId("_QlIraNp-Ed-ak6NoX_4Aeg_1978624696")]
    [DisplayName("Market Type 9 Choice")]
    public abstract record MarketType9Choice_ { }
}
