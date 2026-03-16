// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market/client side information.
    /// </summary>
    [KnownType(typeof(MarketClientSide1Choice.Code))]
    [KnownType(typeof(MarketClientSide1Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketClientSide1Choice.Code), nameof(MarketClientSide1Choice.Code))]
    [JsonDerivedType(
        typeof(MarketClientSide1Choice.Proprietary),
        nameof(MarketClientSide1Choice.Proprietary)
    )]
    [IsoId("_QvuKxdp-Ed-ak6NoX_4Aeg_-2065696030")]
    [DisplayName("Market Client Side 1 Choice")]
    public abstract record MarketClientSide1Choice_ { }
}
