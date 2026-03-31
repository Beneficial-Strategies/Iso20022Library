// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market/client side information.
    /// </summary>
    [KnownType(typeof(MarketClientSide4Choice.Code))]
    [KnownType(typeof(MarketClientSide4Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketClientSide4Choice.Code), nameof(MarketClientSide4Choice.Code))]
    [JsonDerivedType(
        typeof(MarketClientSide4Choice.Proprietary),
        nameof(MarketClientSide4Choice.Proprietary)
    )]
    [IsoId("_rqc9oTqHEeWVrPy0StzzSg")]
    [DisplayName("Market Client Side 4 Choice")]
    public abstract record MarketClientSide4Choice_ { }
}
