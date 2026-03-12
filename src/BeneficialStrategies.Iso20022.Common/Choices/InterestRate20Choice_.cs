// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a fixed rate and a floating rate.
    /// </summary>
    [KnownType(typeof(InterestRate20Choice.Fixed))]
    [KnownType(typeof(InterestRate20Choice.Floating))]
    [JsonDerivedType(typeof(InterestRate20Choice.Fixed),nameof(InterestRate20Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate20Choice.Floating),nameof(InterestRate20Choice.Floating))]
    [IsoId("_hBu-xax2Eem81-uIvTF5rQ")]
    [DisplayName("Interest Rate 20 Choice")]
    public abstract partial record InterestRate20Choice_
    {
    }
}
