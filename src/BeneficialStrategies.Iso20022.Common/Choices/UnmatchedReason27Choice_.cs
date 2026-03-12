// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason27Choice.Code))]
    [KnownType(typeof(UnmatchedReason27Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason27Choice.Code),nameof(UnmatchedReason27Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason27Choice.Proprietary),nameof(UnmatchedReason27Choice.Proprietary))]
    [IsoId("_6d89j5NLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched Reason 27 Choice")]
    public abstract partial record UnmatchedReason27Choice_
    {
    }
}
