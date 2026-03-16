// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on the reported trade transactions.
    /// </summary>
    [KnownType(typeof(TradeReport6Choice.New))]
    [KnownType(typeof(TradeReport6Choice.Error))]
    [KnownType(typeof(TradeReport6Choice.Correction))]
    [KnownType(typeof(TradeReport6Choice.TradeUpdate))]
    [JsonDerivedType(typeof(TradeReport6Choice.New), nameof(TradeReport6Choice.New))]
    [JsonDerivedType(typeof(TradeReport6Choice.Error), nameof(TradeReport6Choice.Error))]
    [JsonDerivedType(typeof(TradeReport6Choice.Correction), nameof(TradeReport6Choice.Correction))]
    [JsonDerivedType(
        typeof(TradeReport6Choice.TradeUpdate),
        nameof(TradeReport6Choice.TradeUpdate)
    )]
    [IsoId("_QNfwAa07EemojPqsRBB5Lg")]
    [DisplayName("Trade Report 6 Choice")]
    public abstract record TradeReport6Choice_ { }
}
