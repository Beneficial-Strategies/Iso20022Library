// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Position/transaction reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(TradeReport15Choice.New))]
    [KnownType(typeof(TradeReport15Choice.Modification))]
    [KnownType(typeof(TradeReport15Choice.Correction))]
    [KnownType(typeof(TradeReport15Choice.Termination))]
    [KnownType(typeof(TradeReport15Choice.PositionComponent))]
    [KnownType(typeof(TradeReport15Choice.ValuationUpdate))]
    [KnownType(typeof(TradeReport15Choice.Compression))]
    [KnownType(typeof(TradeReport15Choice.Error))]
    [KnownType(typeof(TradeReport15Choice.Other))]
    [JsonDerivedType(typeof(TradeReport15Choice.New), nameof(TradeReport15Choice.New))]
    [JsonDerivedType(
        typeof(TradeReport15Choice.Modification),
        nameof(TradeReport15Choice.Modification)
    )]
    [JsonDerivedType(
        typeof(TradeReport15Choice.Correction),
        nameof(TradeReport15Choice.Correction)
    )]
    [JsonDerivedType(
        typeof(TradeReport15Choice.Termination),
        nameof(TradeReport15Choice.Termination)
    )]
    [JsonDerivedType(
        typeof(TradeReport15Choice.PositionComponent),
        nameof(TradeReport15Choice.PositionComponent)
    )]
    [JsonDerivedType(
        typeof(TradeReport15Choice.ValuationUpdate),
        nameof(TradeReport15Choice.ValuationUpdate)
    )]
    [JsonDerivedType(
        typeof(TradeReport15Choice.Compression),
        nameof(TradeReport15Choice.Compression)
    )]
    [JsonDerivedType(typeof(TradeReport15Choice.Error), nameof(TradeReport15Choice.Error))]
    [JsonDerivedType(typeof(TradeReport15Choice.Other), nameof(TradeReport15Choice.Other))]
    [IsoId("_oKFn1Xg-Eeu3kecHd7QKUQ")]
    [DisplayName("Trade Report 15 Choice")]
    public abstract record TradeReport15Choice_ { }
}
