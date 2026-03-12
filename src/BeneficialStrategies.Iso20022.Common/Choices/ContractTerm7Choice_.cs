// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the transaction is open term, that is. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
    /// </summary>
    [KnownType(typeof(ContractTerm7Choice.Open))]
    [KnownType(typeof(ContractTerm7Choice.Fixed))]
    [JsonDerivedType(typeof(ContractTerm7Choice.Open),nameof(ContractTerm7Choice.Open))]
    [JsonDerivedType(typeof(ContractTerm7Choice.Fixed),nameof(ContractTerm7Choice.Fixed))]
    [IsoId("_xcgx0a5qEeuo-IflVgGqiA")]
    [DisplayName("Contract Term 7 Choice")]
    public abstract partial record ContractTerm7Choice_
    {
    }
}
