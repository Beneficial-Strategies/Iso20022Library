// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the cancellation request of a notification.
    /// </summary>
    [KnownType(typeof(NotificationCancellationReason1Choice.Code))]
    [KnownType(typeof(NotificationCancellationReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(NotificationCancellationReason1Choice.Code),nameof(NotificationCancellationReason1Choice.Code))]
    [JsonDerivedType(typeof(NotificationCancellationReason1Choice.Proprietary),nameof(NotificationCancellationReason1Choice.Proprietary))]
    [IsoId("_4LsqKSv_Eey3nPxW-HgLUw")]
    [DisplayName("Notification Cancellation Reason 1 Choice")]
    public abstract partial record NotificationCancellationReason1Choice_
    {
    }
}
