// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason29Choice.Code))]
    [KnownType(typeof(PendingReason29Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason29Choice.Code),nameof(PendingReason29Choice.Code))]
    [JsonDerivedType(typeof(PendingReason29Choice.Proprietary),nameof(PendingReason29Choice.Proprietary))]
    [IsoId("_6FsGETqxEeWyoP0PbocV1Q")]
    [DisplayName("Pending Reason 29 Choice")]
    public abstract partial record PendingReason29Choice_
    {
    }
}
