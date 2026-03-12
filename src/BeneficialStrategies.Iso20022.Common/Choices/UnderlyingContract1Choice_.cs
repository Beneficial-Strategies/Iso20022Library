// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of the type of underlying contract.
    /// </summary>
    [KnownType(typeof(UnderlyingContract1Choice.Loan))]
    [KnownType(typeof(UnderlyingContract1Choice.Trade))]
    [JsonDerivedType(typeof(UnderlyingContract1Choice.Loan),nameof(UnderlyingContract1Choice.Loan))]
    [JsonDerivedType(typeof(UnderlyingContract1Choice.Trade),nameof(UnderlyingContract1Choice.Trade))]
    [IsoId("_opBo8NLJEeSdq5yU2aaSNw")]
    [DisplayName("Underlying Contract 1 Choice")]
    public abstract partial record UnderlyingContract1Choice_
    {
    }
}
