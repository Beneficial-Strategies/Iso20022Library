// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade transaction condition.
    /// </summary>
    [KnownType(typeof(TradeTransactionCondition5Choice.Code))]
    [KnownType(typeof(TradeTransactionCondition5Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeTransactionCondition5Choice.Code),nameof(TradeTransactionCondition5Choice.Code))]
    [JsonDerivedType(typeof(TradeTransactionCondition5Choice.Proprietary),nameof(TradeTransactionCondition5Choice.Proprietary))]
    [IsoId("_2O8mYTqjEeWyoP0PbocV1Q")]
    [DisplayName("Trade Transaction Condition 5 Choice")]
    public abstract partial record TradeTransactionCondition5Choice_
    {
    }
}
