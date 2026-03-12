// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingCancellationReason4Choice.Code))]
    [KnownType(typeof(PendingCancellationReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingCancellationReason4Choice.Code),nameof(PendingCancellationReason4Choice.Code))]
    [JsonDerivedType(typeof(PendingCancellationReason4Choice.Proprietary),nameof(PendingCancellationReason4Choice.Proprietary))]
    [IsoId("_ce_gw5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Cancellation Reason 4 Choice")]
    public abstract partial record PendingCancellationReason4Choice_
    {
    }
}
