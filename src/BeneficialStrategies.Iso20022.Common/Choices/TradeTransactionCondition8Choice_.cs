// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade transaction conditions.
    /// </summary>
    [KnownType(typeof(TradeTransactionCondition8Choice.Code))]
    [KnownType(typeof(TradeTransactionCondition8Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TradeTransactionCondition8Choice.Code),
        nameof(TradeTransactionCondition8Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionCondition8Choice.Proprietary),
        nameof(TradeTransactionCondition8Choice.Proprietary)
    )]
    [IsoId("_PczU8Uc9EeaBWtcfqEyXyw")]
    [DisplayName("Trade Transaction Condition 8 Choice")]
    public abstract record TradeTransactionCondition8Choice_ { }
}
