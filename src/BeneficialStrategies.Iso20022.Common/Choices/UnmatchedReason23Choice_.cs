// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason23Choice.Code))]
    [KnownType(typeof(UnmatchedReason23Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason23Choice.Code),nameof(UnmatchedReason23Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason23Choice.Proprietary),nameof(UnmatchedReason23Choice.Proprietary))]
    [IsoId("_xpywgTq0EeWyoP0PbocV1Q")]
    [DisplayName("Unmatched Reason 23 Choice")]
    public abstract partial record UnmatchedReason23Choice_
    {
    }
}
