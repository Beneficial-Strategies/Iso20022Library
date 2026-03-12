// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus15Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus15Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus15Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus15Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus15Choice.Reason),nameof(RejectionOrRepairStatus15Choice.Reason))]
    [IsoId("_ifpDe_4wEeClUvPNHKL9Zw")]
    [DisplayName("Rejection Or Repair Status 15 Choice")]
    public abstract partial record RejectionOrRepairStatus15Choice_
    {
    }
}
