// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade transaction condition.
    /// </summary>
    [KnownType(typeof(TradeTransactionCondition1Choice.Code))]
    [KnownType(typeof(TradeTransactionCondition1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TradeTransactionCondition1Choice.Code),
        nameof(TradeTransactionCondition1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionCondition1Choice.Proprietary),
        nameof(TradeTransactionCondition1Choice.Proprietary)
    )]
    [IsoId("_QtCDINp-Ed-ak6NoX_4Aeg_-1725642447")]
    [DisplayName("Trade Transaction Condition 1 Choice")]
    public abstract record TradeTransactionCondition1Choice_ { }
}
