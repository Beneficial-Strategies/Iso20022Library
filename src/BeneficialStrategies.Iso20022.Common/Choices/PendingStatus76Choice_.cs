// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Status76Choice.
    /// </summary>
    [KnownType(typeof(PendingStatus76Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus76Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus76Choice.NoSpecifiedReason),nameof(PendingStatus76Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus76Choice.Reason),nameof(PendingStatus76Choice.Reason))]
    [IsoId("_xcgDIZzoEe-DHYbvdRjdbA")]
    [DisplayName("Pending Status76Choice")]
    public abstract partial record PendingStatus76Choice_
    {
    }
}
