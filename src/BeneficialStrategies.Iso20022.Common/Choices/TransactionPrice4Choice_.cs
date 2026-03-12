// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the price information related to the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionPrice4Choice.DealPrice))]
    [KnownType(typeof(TransactionPrice4Choice.Proprietary))]
    [JsonDerivedType(typeof(TransactionPrice4Choice.DealPrice),nameof(TransactionPrice4Choice.DealPrice))]
    [JsonDerivedType(typeof(TransactionPrice4Choice.Proprietary),nameof(TransactionPrice4Choice.Proprietary))]
    [IsoId("_-KxXQbTUEee_k7HqaUKERA")]
    [DisplayName("Transaction Price 4 Choice")]
    public abstract partial record TransactionPrice4Choice_
    {
    }
}
