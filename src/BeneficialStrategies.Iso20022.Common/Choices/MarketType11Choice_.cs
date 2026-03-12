// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType11Choice.Code))]
    [KnownType(typeof(MarketType11Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType11Choice.Code),nameof(MarketType11Choice.Code))]
    [JsonDerivedType(typeof(MarketType11Choice.Proprietary),nameof(MarketType11Choice.Proprietary))]
    [IsoId("_AcinhdokEeC60axPepSq7g_682365512")]
    [DisplayName("Market Type 11 Choice")]
    public abstract partial record MarketType11Choice_
    {
    }
}
