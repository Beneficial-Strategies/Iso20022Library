// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term.
    /// </summary>
    [KnownType(typeof(ContractTerm6Choice.Open))]
    [KnownType(typeof(ContractTerm6Choice.Fixed))]
    [JsonDerivedType(typeof(ContractTerm6Choice.Open), nameof(ContractTerm6Choice.Open))]
    [JsonDerivedType(typeof(ContractTerm6Choice.Fixed), nameof(ContractTerm6Choice.Fixed))]
    [IsoId("_-9nQEa5OEeuo-IflVgGqiA")]
    [DisplayName("Contract Term 6 Choice")]
    public abstract record ContractTerm6Choice_ { }
}
