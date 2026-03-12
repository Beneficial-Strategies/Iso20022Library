// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason37Choice.Code))]
    [KnownType(typeof(PendingReason37Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason37Choice.Code),nameof(PendingReason37Choice.Code))]
    [JsonDerivedType(typeof(PendingReason37Choice.Proprietary),nameof(PendingReason37Choice.Proprietary))]
    [IsoId("_6BE0p5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Reason 37 Choice")]
    public abstract partial record PendingReason37Choice_
    {
    }
}
