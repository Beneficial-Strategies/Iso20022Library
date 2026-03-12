// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for trade transaction condition.
    /// </summary>
    [KnownType(typeof(TradeTransactionCondition7Choice.Code))]
    [KnownType(typeof(TradeTransactionCondition7Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeTransactionCondition7Choice.Code),nameof(TradeTransactionCondition7Choice.Code))]
    [JsonDerivedType(typeof(TradeTransactionCondition7Choice.Proprietary),nameof(TradeTransactionCondition7Choice.Proprietary))]
    [IsoId("_XFNQYeLaEeWFtOV72FbX9w")]
    [DisplayName("Trade Transaction Condition 7 Choice")]
    public abstract partial record TradeTransactionCondition7Choice_
    {
    }
}
