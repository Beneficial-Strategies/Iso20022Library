// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a fixed rate and a floating rate.
    /// </summary>
    [KnownType(typeof(InterestRate2Choice.Fixed))]
    [KnownType(typeof(InterestRate2Choice.Floating))]
    [JsonDerivedType(typeof(InterestRate2Choice.Fixed), nameof(InterestRate2Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate2Choice.Floating), nameof(InterestRate2Choice.Floating))]
    [IsoId("_lIYtcepnEeSsk6KxwbYJ9w")]
    [DisplayName("Interest Rate 2 Choice")]
    public abstract record InterestRate2Choice_ { }
}
