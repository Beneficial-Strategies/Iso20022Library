// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on the reported trade transactions.
    /// </summary>
    [KnownType(typeof(TradeTransactionReport8Choice.New))]
    [KnownType(typeof(TradeTransactionReport8Choice.Modification))]
    [KnownType(typeof(TradeTransactionReport8Choice.Correction))]
    [KnownType(typeof(TradeTransactionReport8Choice.EarlyTermination))]
    [KnownType(typeof(TradeTransactionReport8Choice.PositionComponent))]
    [KnownType(typeof(TradeTransactionReport8Choice.ValuationUpdate))]
    [KnownType(typeof(TradeTransactionReport8Choice.Compression))]
    [KnownType(typeof(TradeTransactionReport8Choice.Error))]
    [KnownType(typeof(TradeTransactionReport8Choice.Other))]
    [JsonDerivedType(
        typeof(TradeTransactionReport8Choice.New),
        nameof(TradeTransactionReport8Choice.New)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionReport8Choice.Modification),
        nameof(TradeTransactionReport8Choice.Modification)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionReport8Choice.Correction),
        nameof(TradeTransactionReport8Choice.Correction)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionReport8Choice.EarlyTermination),
        nameof(TradeTransactionReport8Choice.EarlyTermination)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionReport8Choice.PositionComponent),
        nameof(TradeTransactionReport8Choice.PositionComponent)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionReport8Choice.ValuationUpdate),
        nameof(TradeTransactionReport8Choice.ValuationUpdate)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionReport8Choice.Compression),
        nameof(TradeTransactionReport8Choice.Compression)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionReport8Choice.Error),
        nameof(TradeTransactionReport8Choice.Error)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionReport8Choice.Other),
        nameof(TradeTransactionReport8Choice.Other)
    )]
    [IsoId("_bQpIhRLBEeqctpBfTmLJnw")]
    [DisplayName("Trade Transaction Report 8 Choice")]
    public abstract record TradeTransactionReport8Choice_ { }
}
