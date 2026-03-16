// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between various statuses.
    /// </summary>
    [KnownType(typeof(NotificationCancellationRequestStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(NotificationCancellationRequestStatus1Choice.RejectedStatus))]
    [JsonDerivedType(
        typeof(NotificationCancellationRequestStatus1Choice.ProcessedStatus),
        nameof(NotificationCancellationRequestStatus1Choice.ProcessedStatus)
    )]
    [JsonDerivedType(
        typeof(NotificationCancellationRequestStatus1Choice.RejectedStatus),
        nameof(NotificationCancellationRequestStatus1Choice.RejectedStatus)
    )]
    [IsoId("_RiYWw9p-Ed-ak6NoX_4Aeg_-987032957")]
    [DisplayName("Notification Cancellation Request Status 1 Choice")]
    public abstract record NotificationCancellationRequestStatus1Choice_ { }
}
