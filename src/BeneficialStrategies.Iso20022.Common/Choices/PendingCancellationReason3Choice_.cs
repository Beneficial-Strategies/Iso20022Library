// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingCancellationReason3Choice.Code))]
    [KnownType(typeof(PendingCancellationReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingCancellationReason3Choice.Code),nameof(PendingCancellationReason3Choice.Code))]
    [JsonDerivedType(typeof(PendingCancellationReason3Choice.Proprietary),nameof(PendingCancellationReason3Choice.Proprietary))]
    [IsoId("_MinedUGXEeWqy4niLuXETA")]
    [DisplayName("Pending Cancellation Reason 3 Choice")]
    public abstract partial record PendingCancellationReason3Choice_
    {
    }
}
