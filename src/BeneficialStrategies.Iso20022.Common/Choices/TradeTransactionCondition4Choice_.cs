// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade transaction condition.
    /// </summary>
    [KnownType(typeof(TradeTransactionCondition4Choice.Code))]
    [KnownType(typeof(TradeTransactionCondition4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TradeTransactionCondition4Choice.Code),
        nameof(TradeTransactionCondition4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionCondition4Choice.Proprietary),
        nameof(TradeTransactionCondition4Choice.Proprietary)
    )]
    [IsoId("_AcY2h9okEeC60axPepSq7g_-1144479083")]
    [DisplayName("Trade Transaction Condition 4 Choice")]
    public abstract record TradeTransactionCondition4Choice_ { }
}
