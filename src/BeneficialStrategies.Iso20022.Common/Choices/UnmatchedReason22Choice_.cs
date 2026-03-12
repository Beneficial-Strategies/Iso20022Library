// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement query unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason22Choice.Code))]
    [KnownType(typeof(UnmatchedReason22Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason22Choice.Code),nameof(UnmatchedReason22Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason22Choice.Proprietary),nameof(UnmatchedReason22Choice.Proprietary))]
    [IsoId("_SN9toTqyEeWyoP0PbocV1Q")]
    [DisplayName("Unmatched Reason 22 Choice")]
    public abstract partial record UnmatchedReason22Choice_
    {
    }
}
