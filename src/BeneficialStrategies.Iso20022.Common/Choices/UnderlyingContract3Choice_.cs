// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of the type of underlying contract.
    /// </summary>
    [KnownType(typeof(UnderlyingContract3Choice.Loan))]
    [KnownType(typeof(UnderlyingContract3Choice.Trade))]
    [JsonDerivedType(typeof(UnderlyingContract3Choice.Loan),nameof(UnderlyingContract3Choice.Loan))]
    [JsonDerivedType(typeof(UnderlyingContract3Choice.Trade),nameof(UnderlyingContract3Choice.Trade))]
    [IsoId("_0NEsUbGIEeuSTr8k0UEM8A")]
    [DisplayName("Underlying Contract 3 Choice")]
    public abstract partial record UnderlyingContract3Choice_
    {
    }
}
