// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of a rate, a fixed or a floating rate.
    /// </summary>
    [KnownType(typeof(InterestRate33Choice.Fixed))]
    [KnownType(typeof(InterestRate33Choice.Floating))]
    [JsonDerivedType(typeof(InterestRate33Choice.Fixed), nameof(InterestRate33Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate33Choice.Floating), nameof(InterestRate33Choice.Floating))]
    [IsoId("_CQQe8SJLEe2zWP9pqvmqdw")]
    [DisplayName("Interest Rate 33 Choice")]
    public abstract record InterestRate33Choice_ { }
}
