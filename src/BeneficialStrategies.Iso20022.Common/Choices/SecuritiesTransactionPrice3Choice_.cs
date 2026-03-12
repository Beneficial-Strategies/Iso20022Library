// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice3Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice3Choice.Unit))]
    [KnownType(typeof(SecuritiesTransactionPrice3Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice3Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice3Choice.PendingPrice))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice3Choice.MonetaryValue),nameof(SecuritiesTransactionPrice3Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice3Choice.Unit),nameof(SecuritiesTransactionPrice3Choice.Unit))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice3Choice.Percentage),nameof(SecuritiesTransactionPrice3Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice3Choice.Yield),nameof(SecuritiesTransactionPrice3Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice3Choice.PendingPrice),nameof(SecuritiesTransactionPrice3Choice.PendingPrice))]
    [IsoId("_rS83x0DWEeWOL-OsSq2h6w")]
    [DisplayName("Securities Transaction Price 3 Choice")]
    public abstract partial record SecuritiesTransactionPrice3Choice_
    {
    }
}
