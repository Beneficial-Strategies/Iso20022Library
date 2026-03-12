// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction or instruction cancellation cancelled/cancellation completed status.
    /// </summary>
    [KnownType(typeof(CancelledStatus12Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus12Choice.Reason))]
    [JsonDerivedType(typeof(CancelledStatus12Choice.NoSpecifiedReason),nameof(CancelledStatus12Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancelledStatus12Choice.Reason),nameof(CancelledStatus12Choice.Reason))]
    [IsoId("_wxM4C0GUEeWqy4niLuXETA")]
    [DisplayName("Cancelled Status 12 Choice")]
    public abstract partial record CancelledStatus12Choice_
    {
    }
}
