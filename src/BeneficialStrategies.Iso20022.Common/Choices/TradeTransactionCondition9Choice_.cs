// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade transaction condition.
    /// </summary>
    [KnownType(typeof(TradeTransactionCondition9Choice.Code))]
    [KnownType(typeof(TradeTransactionCondition9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TradeTransactionCondition9Choice.Code),
        nameof(TradeTransactionCondition9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionCondition9Choice.Proprietary),
        nameof(TradeTransactionCondition9Choice.Proprietary)
    )]
    [IsoId("_9Roj0ZBgEeakHoV5BVecAQ")]
    [DisplayName("Trade Transaction Condition 9 Choice")]
    public abstract record TradeTransactionCondition9Choice_ { }
}
