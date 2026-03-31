// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice18Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice18Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice18Choice.Decimal))]
    [KnownType(typeof(SecuritiesTransactionPrice18Choice.BasisPoints))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice18Choice.MonetaryValue),
        nameof(SecuritiesTransactionPrice18Choice.MonetaryValue)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice18Choice.Percentage),
        nameof(SecuritiesTransactionPrice18Choice.Percentage)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice18Choice.Decimal),
        nameof(SecuritiesTransactionPrice18Choice.Decimal)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice18Choice.BasisPoints),
        nameof(SecuritiesTransactionPrice18Choice.BasisPoints)
    )]
    [IsoId("_XQwXoMgpEeuGrNSsxk3B0A")]
    [DisplayName("Securities Transaction Price 18 Choice")]
    public abstract record SecuritiesTransactionPrice18Choice_ { }
}
