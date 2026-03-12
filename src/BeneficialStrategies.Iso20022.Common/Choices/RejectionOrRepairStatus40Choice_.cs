// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus40Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus40Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus40Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus40Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus40Choice.Reason),nameof(RejectionOrRepairStatus40Choice.Reason))]
    [IsoId("_mk9BveGKEeWCAvUNsZ5u6g")]
    [DisplayName("Rejection Or Repair Status 40 Choice")]
    public abstract partial record RejectionOrRepairStatus40Choice_
    {
    }
}
