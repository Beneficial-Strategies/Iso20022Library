// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement query unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason2Choice.Code))]
    [KnownType(typeof(UnmatchedReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason2Choice.Code),nameof(UnmatchedReason2Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason2Choice.Proprietary),nameof(UnmatchedReason2Choice.Proprietary))]
    [IsoId("_UXSHU9p-Ed-ak6NoX_4Aeg_-1156614721")]
    [DisplayName("Unmatched Reason 2 Choice")]
    public abstract partial record UnmatchedReason2Choice_
    {
    }
}
