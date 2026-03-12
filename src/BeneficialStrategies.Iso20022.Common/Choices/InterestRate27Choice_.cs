// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a fixed rate and a floating rate.
    /// </summary>
    [KnownType(typeof(InterestRate27Choice.Fixed))]
    [KnownType(typeof(InterestRate27Choice.Floating))]
    [JsonDerivedType(typeof(InterestRate27Choice.Fixed),nameof(InterestRate27Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate27Choice.Floating),nameof(InterestRate27Choice.Floating))]
    [IsoId("_Z8mDEcg6Eeu4ecZgAYuz5w")]
    [DisplayName("Interest Rate 27 Choice")]
    public abstract partial record InterestRate27Choice_
    {
    }
}
