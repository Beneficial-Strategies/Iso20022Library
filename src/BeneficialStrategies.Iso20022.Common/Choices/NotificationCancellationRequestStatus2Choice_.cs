// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Notification Cancellation Request Status2Choice.
    /// </summary>
    [KnownType(typeof(NotificationCancellationRequestStatus2Choice.ProcessedStatus))]
    [KnownType(typeof(NotificationCancellationRequestStatus2Choice.RejectedStatus))]
    [JsonDerivedType(
        typeof(NotificationCancellationRequestStatus2Choice.ProcessedStatus),
        nameof(NotificationCancellationRequestStatus2Choice.ProcessedStatus)
    )]
    [JsonDerivedType(
        typeof(NotificationCancellationRequestStatus2Choice.RejectedStatus),
        nameof(NotificationCancellationRequestStatus2Choice.RejectedStatus)
    )]
    [IsoId("_Eye7gVvFEe6gDOpEK7Q4ig")]
    [DisplayName("Notification Cancellation Request Status2Choice")]
    public abstract record NotificationCancellationRequestStatus2Choice_ { }
}
