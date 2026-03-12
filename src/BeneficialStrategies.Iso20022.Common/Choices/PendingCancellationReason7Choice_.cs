// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingCancellationReason7Choice.Code))]
    [KnownType(typeof(PendingCancellationReason7Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingCancellationReason7Choice.Code),nameof(PendingCancellationReason7Choice.Code))]
    [JsonDerivedType(typeof(PendingCancellationReason7Choice.Proprietary),nameof(PendingCancellationReason7Choice.Proprietary))]
    [IsoId("_cHKO1bKjEemux5trsZcCpw")]
    [DisplayName("Pending Cancellation Reason 7 Choice")]
    public abstract partial record PendingCancellationReason7Choice_
    {
    }
}
