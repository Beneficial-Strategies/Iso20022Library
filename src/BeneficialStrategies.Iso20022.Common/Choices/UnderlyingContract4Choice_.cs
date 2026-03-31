// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Underlying Contract4Choice.
    /// </summary>
    [KnownType(typeof(UnderlyingContract4Choice.Loan))]
    [KnownType(typeof(UnderlyingContract4Choice.Trade))]
    [JsonDerivedType(
        typeof(UnderlyingContract4Choice.Loan),
        nameof(UnderlyingContract4Choice.Loan)
    )]
    [JsonDerivedType(
        typeof(UnderlyingContract4Choice.Trade),
        nameof(UnderlyingContract4Choice.Trade)
    )]
    [IsoId("_2OtQLzEyEe6g-ffJsqGiSA")]
    [DisplayName("Underlying Contract4Choice")]
    public abstract record UnderlyingContract4Choice_ { }
}
