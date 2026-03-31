// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on the reported trade transactions.
    /// </summary>
    [KnownType(typeof(TradeReport31Choice.New))]
    [KnownType(typeof(TradeReport31Choice.MarginUpdate))]
    [KnownType(typeof(TradeReport31Choice.Error))]
    [KnownType(typeof(TradeReport31Choice.Correction))]
    [JsonDerivedType(typeof(TradeReport31Choice.New), nameof(TradeReport31Choice.New))]
    [JsonDerivedType(
        typeof(TradeReport31Choice.MarginUpdate),
        nameof(TradeReport31Choice.MarginUpdate)
    )]
    [JsonDerivedType(typeof(TradeReport31Choice.Error), nameof(TradeReport31Choice.Error))]
    [JsonDerivedType(
        typeof(TradeReport31Choice.Correction),
        nameof(TradeReport31Choice.Correction)
    )]
    [IsoId("_oyOyxVosEe23K4GXSpBSeg")]
    [DisplayName("Trade Report 31 Choice")]
    public abstract record TradeReport31Choice_ { }
}
