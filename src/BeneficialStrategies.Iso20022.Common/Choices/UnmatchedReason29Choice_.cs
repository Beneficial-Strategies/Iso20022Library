// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement query unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason29Choice.Code))]
    [KnownType(typeof(UnmatchedReason29Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason29Choice.Code),nameof(UnmatchedReason29Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason29Choice.Proprietary),nameof(UnmatchedReason29Choice.Proprietary))]
    [IsoId("_8Qddd5NLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched Reason 29 Choice")]
    public abstract partial record UnmatchedReason29Choice_
    {
    }
}
