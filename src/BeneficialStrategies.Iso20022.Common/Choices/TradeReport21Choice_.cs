// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on the reported trade transactions.
    /// </summary>
    [KnownType(typeof(TradeReport21Choice.New))]
    [KnownType(typeof(TradeReport21Choice.Error))]
    [KnownType(typeof(TradeReport21Choice.Correction))]
    [KnownType(typeof(TradeReport21Choice.TradeUpdate))]
    [JsonDerivedType(typeof(TradeReport21Choice.New),nameof(TradeReport21Choice.New))]
    [JsonDerivedType(typeof(TradeReport21Choice.Error),nameof(TradeReport21Choice.Error))]
    [JsonDerivedType(typeof(TradeReport21Choice.Correction),nameof(TradeReport21Choice.Correction))]
    [JsonDerivedType(typeof(TradeReport21Choice.TradeUpdate),nameof(TradeReport21Choice.TradeUpdate))]
    [IsoId("_SJHcgcg2EeuGrNSsxk3B0A")]
    [DisplayName("Trade Report 21 Choice")]
    public abstract partial record TradeReport21Choice_
    {
    }
}
