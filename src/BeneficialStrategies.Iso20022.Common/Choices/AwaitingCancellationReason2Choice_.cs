// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allegment reason.
    /// </summary>
    [KnownType(typeof(AwaitingCancellationReason2Choice.Code))]
    [KnownType(typeof(AwaitingCancellationReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(AwaitingCancellationReason2Choice.Code),nameof(AwaitingCancellationReason2Choice.Code))]
    [JsonDerivedType(typeof(AwaitingCancellationReason2Choice.Proprietary),nameof(AwaitingCancellationReason2Choice.Proprietary))]
    [IsoId("_mYibFQd4Ee2fOITqoTnSLQ")]
    [DisplayName("Awaiting Cancellation Reason 2 Choice")]
    public abstract partial record AwaitingCancellationReason2Choice_
    {
    }
}
