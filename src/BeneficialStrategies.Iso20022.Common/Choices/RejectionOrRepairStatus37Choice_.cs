// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus37Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus37Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus37Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus37Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus37Choice.Reason),nameof(RejectionOrRepairStatus37Choice.Reason))]
    [IsoId("_8RtbMZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Or Repair Status 37 Choice")]
    public abstract partial record RejectionOrRepairStatus37Choice_
    {
    }
}
