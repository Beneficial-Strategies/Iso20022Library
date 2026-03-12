// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a fixed rate and a variable rate.
    /// </summary>
    [KnownType(typeof(InterestRate8Choice.Fixed))]
    [KnownType(typeof(InterestRate8Choice.Floating))]
    [JsonDerivedType(typeof(InterestRate8Choice.Fixed),nameof(InterestRate8Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate8Choice.Floating),nameof(InterestRate8Choice.Floating))]
    [IsoId("_H7ydeX5aEea2k7EBUopqxw")]
    [DisplayName("Interest Rate 8 Choice")]
    public abstract partial record InterestRate8Choice_
    {
    }
}
