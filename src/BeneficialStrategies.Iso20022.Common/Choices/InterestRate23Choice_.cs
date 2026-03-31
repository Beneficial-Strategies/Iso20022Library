// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of a rate, a fixed or a floating rate.
    /// </summary>
    [KnownType(typeof(InterestRate23Choice.Fixed))]
    [KnownType(typeof(InterestRate23Choice.Floating))]
    [JsonDerivedType(typeof(InterestRate23Choice.Fixed), nameof(InterestRate23Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate23Choice.Floating), nameof(InterestRate23Choice.Floating))]
    [IsoId("_6Hvyx1fREeqqKf65rDYWYw")]
    [DisplayName("Interest Rate 23 Choice")]
    public abstract record InterestRate23Choice_ { }
}
