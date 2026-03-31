// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType18Choice.Code))]
    [KnownType(typeof(MarketType18Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType18Choice.Code), nameof(MarketType18Choice.Code))]
    [JsonDerivedType(
        typeof(MarketType18Choice.Proprietary),
        nameof(MarketType18Choice.Proprietary)
    )]
    [IsoId("_AaVaOZBhEeakHoV5BVecAQ")]
    [DisplayName("Market Type 18 Choice")]
    public abstract record MarketType18Choice_ { }
}
