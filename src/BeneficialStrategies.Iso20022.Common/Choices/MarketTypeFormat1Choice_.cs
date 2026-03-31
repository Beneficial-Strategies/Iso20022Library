// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of market.
    /// </summary>
    [KnownType(typeof(MarketTypeFormat1Choice.Code))]
    [KnownType(typeof(MarketTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketTypeFormat1Choice.Code), nameof(MarketTypeFormat1Choice.Code))]
    [JsonDerivedType(
        typeof(MarketTypeFormat1Choice.Proprietary),
        nameof(MarketTypeFormat1Choice.Proprietary)
    )]
    [IsoId("_Q4XJYdp-Ed-ak6NoX_4Aeg_472330061")]
    [DisplayName("Market Type Format 1 Choice")]
    public abstract record MarketTypeFormat1Choice_ { }
}
