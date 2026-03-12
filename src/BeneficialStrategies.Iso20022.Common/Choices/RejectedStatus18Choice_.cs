// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus18Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus18Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus18Choice.NoSpecifiedReason),nameof(RejectedStatus18Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus18Choice.Reason),nameof(RejectedStatus18Choice.Reason))]
    [IsoId("_F9b6IUGXEeWqy4niLuXETA")]
    [DisplayName("Rejected Status 18 Choice")]
    public abstract partial record RejectedStatus18Choice_
    {
    }
}
