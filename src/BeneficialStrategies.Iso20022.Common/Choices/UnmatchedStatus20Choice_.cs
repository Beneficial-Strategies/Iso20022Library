// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus20Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus20Choice.Reason))]
    [JsonDerivedType(typeof(UnmatchedStatus20Choice.NoSpecifiedReason),nameof(UnmatchedStatus20Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus20Choice.Reason),nameof(UnmatchedStatus20Choice.Reason))]
    [IsoId("_6QAoJ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched Status 20 Choice")]
    public abstract partial record UnmatchedStatus20Choice_
    {
    }
}
