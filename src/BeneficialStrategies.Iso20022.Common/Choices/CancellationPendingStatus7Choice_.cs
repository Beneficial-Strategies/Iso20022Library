// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the cancellation pending status.
    /// </summary>
    [KnownType(typeof(CancellationPendingStatus7Choice.Reason))]
    [KnownType(typeof(CancellationPendingStatus7Choice.DataSourceScheme))]
    [KnownType(typeof(CancellationPendingStatus7Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancellationPendingStatus7Choice.Reason),nameof(CancellationPendingStatus7Choice.Reason))]
    [JsonDerivedType(typeof(CancellationPendingStatus7Choice.DataSourceScheme),nameof(CancellationPendingStatus7Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(CancellationPendingStatus7Choice.NoSpecifiedReason),nameof(CancellationPendingStatus7Choice.NoSpecifiedReason))]
    [IsoId("_mp9xQSY5EeW_ZNn8gbfY7Q")]
    [DisplayName("Cancellation Pending Status 7 Choice")]
    public abstract partial record CancellationPendingStatus7Choice_
    {
    }
}
