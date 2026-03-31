// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market/client side information.
    /// </summary>
    [KnownType(typeof(MarketClientSide7Choice.Code))]
    [KnownType(typeof(MarketClientSide7Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketClientSide7Choice.Code), nameof(MarketClientSide7Choice.Code))]
    [JsonDerivedType(
        typeof(MarketClientSide7Choice.Proprietary),
        nameof(MarketClientSide7Choice.Proprietary)
    )]
    [IsoId("_5TtVXc3yEee5nJBZsW8MFQ")]
    [DisplayName("Market Client Side 7 Choice")]
    public abstract record MarketClientSide7Choice_ { }
}
