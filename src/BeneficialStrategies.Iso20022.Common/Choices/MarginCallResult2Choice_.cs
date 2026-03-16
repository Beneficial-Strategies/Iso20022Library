// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to provide the summation of the call amounts for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(MarginCallResult2Choice.MarginCallResultDetails))]
    [KnownType(typeof(MarginCallResult2Choice.MarginCallAmount))]
    [KnownType(typeof(MarginCallResult2Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(
        typeof(MarginCallResult2Choice.MarginCallResultDetails),
        nameof(MarginCallResult2Choice.MarginCallResultDetails)
    )]
    [JsonDerivedType(
        typeof(MarginCallResult2Choice.MarginCallAmount),
        nameof(MarginCallResult2Choice.MarginCallAmount)
    )]
    [JsonDerivedType(
        typeof(MarginCallResult2Choice.SegregatedIndependentAmount),
        nameof(MarginCallResult2Choice.SegregatedIndependentAmount)
    )]
    [IsoId("_9beRS6MPEeCojJW5vEuTEQ_-1338603652")]
    [DisplayName("Margin Call Result 2 Choice")]
    public abstract record MarginCallResult2Choice_ { }
}
