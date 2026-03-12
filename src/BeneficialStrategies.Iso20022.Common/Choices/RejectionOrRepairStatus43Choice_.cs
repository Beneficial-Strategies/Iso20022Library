// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus43Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus43Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus43Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus43Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus43Choice.Reason),nameof(RejectionOrRepairStatus43Choice.Reason))]
    [IsoId("_Df01kStXEeyhipY4f42fZQ")]
    [DisplayName("Rejection Or Repair Status 43 Choice")]
    public abstract partial record RejectionOrRepairStatus43Choice_
    {
    }
}
