// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.Unit))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.Decimal))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.PendingPrice))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.Other))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.MonetaryValue),nameof(SecuritiesTransactionPrice19Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.Unit),nameof(SecuritiesTransactionPrice19Choice.Unit))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.Percentage),nameof(SecuritiesTransactionPrice19Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.Yield),nameof(SecuritiesTransactionPrice19Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.Decimal),nameof(SecuritiesTransactionPrice19Choice.Decimal))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.PendingPrice),nameof(SecuritiesTransactionPrice19Choice.PendingPrice))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.Other),nameof(SecuritiesTransactionPrice19Choice.Other))]
    [IsoId("_P98b4MgqEeuGrNSsxk3B0A")]
    [DisplayName("Securities Transaction Price 19 Choice")]
    public abstract partial record SecuritiesTransactionPrice19Choice_
    {
    }
}
