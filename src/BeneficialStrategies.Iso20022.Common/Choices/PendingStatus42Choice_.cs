// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus42Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus42Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus42Choice.NoSpecifiedReason),nameof(PendingStatus42Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus42Choice.Reason),nameof(PendingStatus42Choice.Reason))]
    [IsoId("_Bsuk0UGVEeWqy4niLuXETA")]
    [DisplayName("Pending Status 42 Choice")]
    public abstract partial record PendingStatus42Choice_
    {
    }
}
