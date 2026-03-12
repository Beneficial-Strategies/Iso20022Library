// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason42Choice.Code))]
    [KnownType(typeof(PendingReason42Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason42Choice.Code),nameof(PendingReason42Choice.Code))]
    [JsonDerivedType(typeof(PendingReason42Choice.Proprietary),nameof(PendingReason42Choice.Proprietary))]
    [IsoId("_6QESa5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Reason 42 Choice")]
    public abstract partial record PendingReason42Choice_
    {
    }
}
