// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of a rate, a fixed or a floating rate.
    /// </summary>
    [KnownType(typeof(InterestRate21Choice.Fixed))]
    [KnownType(typeof(InterestRate21Choice.Floating))]
    [JsonDerivedType(typeof(InterestRate21Choice.Fixed),nameof(InterestRate21Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate21Choice.Floating),nameof(InterestRate21Choice.Floating))]
    [IsoId("_GO8-BQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Interest Rate 21 Choice")]
    public abstract partial record InterestRate21Choice_
    {
    }
}
