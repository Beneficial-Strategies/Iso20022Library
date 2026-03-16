// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the general meeting instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus36Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus36Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus36Choice.NoSpecifiedReason),
        nameof(RejectedStatus36Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus36Choice.Reason), nameof(RejectedStatus36Choice.Reason))]
    [IsoId("_cBRCSfNfEeqRfth943bvEA")]
    [DisplayName("Rejected Status 36 Choice")]
    public abstract record RejectedStatus36Choice_ { }
}
