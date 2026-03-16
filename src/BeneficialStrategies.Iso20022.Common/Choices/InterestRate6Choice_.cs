// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a fixed rate and a floating rate.
    /// </summary>
    [KnownType(typeof(InterestRate6Choice.Fixed))]
    [KnownType(typeof(InterestRate6Choice.Floating))]
    [JsonDerivedType(typeof(InterestRate6Choice.Fixed), nameof(InterestRate6Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate6Choice.Floating), nameof(InterestRate6Choice.Floating))]
    [IsoId("_nYyCASc1EeaCIe3n1Gx9ug")]
    [DisplayName("Interest Rate 6 Choice")]
    public abstract record InterestRate6Choice_ { }
}
