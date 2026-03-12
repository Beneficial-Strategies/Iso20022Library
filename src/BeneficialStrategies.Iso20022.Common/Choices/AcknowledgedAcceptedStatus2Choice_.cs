// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus2Choice.Reason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus2Choice.NoSpecifiedReason),nameof(AcknowledgedAcceptedStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus2Choice.Reason),nameof(AcknowledgedAcceptedStatus2Choice.Reason))]
    [IsoId("_UWYvcNp-Ed-ak6NoX_4Aeg_1912312217")]
    [DisplayName("Acknowledged Accepted Status 2 Choice")]
    public abstract partial record AcknowledgedAcceptedStatus2Choice_
    {
    }
}
