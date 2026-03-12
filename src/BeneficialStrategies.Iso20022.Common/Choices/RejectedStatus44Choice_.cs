// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the general meeting instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus44Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus44Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus44Choice.NoSpecifiedReason),nameof(RejectedStatus44Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus44Choice.Reason),nameof(RejectedStatus44Choice.Reason))]
    [IsoId("_htjMqRrpEeyhRdHRjakS2w")]
    [DisplayName("Rejected Status 44 Choice")]
    public abstract partial record RejectedStatus44Choice_
    {
    }
}
