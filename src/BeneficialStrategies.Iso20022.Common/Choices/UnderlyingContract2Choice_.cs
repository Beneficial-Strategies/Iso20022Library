// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of the type of underlying contract.
    /// </summary>
    [KnownType(typeof(UnderlyingContract2Choice.Loan))]
    [KnownType(typeof(UnderlyingContract2Choice.Trade))]
    [JsonDerivedType(typeof(UnderlyingContract2Choice.Loan),nameof(UnderlyingContract2Choice.Loan))]
    [JsonDerivedType(typeof(UnderlyingContract2Choice.Trade),nameof(UnderlyingContract2Choice.Trade))]
    [IsoId("_JXX9CW49EeiU9cctagi5ow")]
    [DisplayName("Underlying Contract 2 Choice")]
    public abstract partial record UnderlyingContract2Choice_
    {
    }
}
