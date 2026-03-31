// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus19Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus19Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus19Choice.NoSpecifiedReason),
        nameof(RejectedStatus19Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus19Choice.Reason), nameof(RejectedStatus19Choice.Reason))]
    [IsoId("_9NvRAUGUEeWqy4niLuXETA")]
    [DisplayName("Rejected Status 19 Choice")]
    public abstract record RejectedStatus19Choice_ { }
}
