// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Notification Advice Status2Choice.
    /// </summary>
    [KnownType(typeof(NotificationAdviceStatus2Choice.ProcessedStatus))]
    [KnownType(typeof(NotificationAdviceStatus2Choice.RejectedStatus))]
    [JsonDerivedType(typeof(NotificationAdviceStatus2Choice.ProcessedStatus),nameof(NotificationAdviceStatus2Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(NotificationAdviceStatus2Choice.RejectedStatus),nameof(NotificationAdviceStatus2Choice.RejectedStatus))]
    [IsoId("_VZBnEVuxEe6gDOpEK7Q4ig")]
    [DisplayName("Notification Advice Status2Choice")]
    public abstract partial record NotificationAdviceStatus2Choice_
    {
    }
}
