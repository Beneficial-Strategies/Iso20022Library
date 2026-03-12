// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice11Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice11Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice11Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice11Choice.BasisPoints))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice11Choice.MonetaryValue),nameof(SecuritiesTransactionPrice11Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice11Choice.Percentage),nameof(SecuritiesTransactionPrice11Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice11Choice.Yield),nameof(SecuritiesTransactionPrice11Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice11Choice.BasisPoints),nameof(SecuritiesTransactionPrice11Choice.BasisPoints))]
    [IsoId("_MR5i6c1VEem4K5qLxnWwMA")]
    [DisplayName("Securities Transaction Price 11 Choice")]
    public abstract partial record SecuritiesTransactionPrice11Choice_
    {
    }
}
