// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason30Choice.Code))]
    [KnownType(typeof(PendingReason30Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason30Choice.Code),nameof(PendingReason30Choice.Code))]
    [JsonDerivedType(typeof(PendingReason30Choice.Proprietary),nameof(PendingReason30Choice.Proprietary))]
    [IsoId("_kFQGETq3EeWyoP0PbocV1Q")]
    [DisplayName("Pending Reason 30 Choice")]
    public abstract partial record PendingReason30Choice_
    {
    }
}
