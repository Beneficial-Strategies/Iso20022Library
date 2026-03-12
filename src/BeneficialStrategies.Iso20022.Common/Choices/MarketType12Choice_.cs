// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType12Choice.Code))]
    [KnownType(typeof(MarketType12Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType12Choice.Code),nameof(MarketType12Choice.Code))]
    [JsonDerivedType(typeof(MarketType12Choice.Proprietary),nameof(MarketType12Choice.Proprietary))]
    [IsoId("_Ac1ictokEeC60axPepSq7g_-1309729515")]
    [DisplayName("Market Type 12 Choice")]
    public abstract partial record MarketType12Choice_
    {
    }
}
