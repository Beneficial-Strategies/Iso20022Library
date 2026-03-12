// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus32Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus32Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus32Choice.NoSpecifiedReason),nameof(PendingStatus32Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus32Choice.Reason),nameof(PendingStatus32Choice.Reason))]
    [IsoId("_R-pFSydxEeOXAt_43VmZGw")]
    [DisplayName("Pending Status 32 Choice")]
    public abstract partial record PendingStatus32Choice_
    {
    }
}
