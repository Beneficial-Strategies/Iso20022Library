// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason47Choice.Code))]
    [KnownType(typeof(PendingReason47Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason47Choice.Code),nameof(PendingReason47Choice.Code))]
    [JsonDerivedType(typeof(PendingReason47Choice.Proprietary),nameof(PendingReason47Choice.Proprietary))]
    [IsoId("_8Qc2s5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Reason 47 Choice")]
    public abstract partial record PendingReason47Choice_
    {
    }
}
