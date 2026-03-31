// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.Unit))]
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.PendingPrice))]
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.Other))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice10Choice.MonetaryValue),
        nameof(SecuritiesTransactionPrice10Choice.MonetaryValue)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice10Choice.Unit),
        nameof(SecuritiesTransactionPrice10Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice10Choice.Percentage),
        nameof(SecuritiesTransactionPrice10Choice.Percentage)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice10Choice.Yield),
        nameof(SecuritiesTransactionPrice10Choice.Yield)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice10Choice.PendingPrice),
        nameof(SecuritiesTransactionPrice10Choice.PendingPrice)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice10Choice.Other),
        nameof(SecuritiesTransactionPrice10Choice.Other)
    )]
    [IsoId("_QhQ_wf9iEea3W_f2lS_aiw")]
    [DisplayName("Securities Transaction Price 10 Choice")]
    public abstract record SecuritiesTransactionPrice10Choice_ { }
}
