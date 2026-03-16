// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the transaction is open term, that is. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
    /// </summary>
    [KnownType(typeof(ContractTerm3Choice.Open))]
    [KnownType(typeof(ContractTerm3Choice.Fixed))]
    [JsonDerivedType(typeof(ContractTerm3Choice.Open), nameof(ContractTerm3Choice.Open))]
    [JsonDerivedType(typeof(ContractTerm3Choice.Fixed), nameof(ContractTerm3Choice.Fixed))]
    [IsoId("_tFmdMa9_EemF0ZVFnxVu4g")]
    [DisplayName("Contract Term 3 Choice")]
    public abstract record ContractTerm3Choice_ { }
}
