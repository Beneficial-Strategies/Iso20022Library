// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus6Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus6Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus6Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus6Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus6Choice.Reason),nameof(RejectionOrRepairStatus6Choice.Reason))]
    [IsoId("_UUAJ19p-Ed-ak6NoX_4Aeg_-153082693")]
    [DisplayName("Rejection Or Repair Status 6 Choice")]
    public abstract partial record RejectionOrRepairStatus6Choice_
    {
    }
}
