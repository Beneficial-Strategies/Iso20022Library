// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the status of a notification advice.
    /// </summary>
    [KnownType(typeof(NotificationAdviceStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(NotificationAdviceStatus1Choice.RejectedStatus))]
    [JsonDerivedType(
        typeof(NotificationAdviceStatus1Choice.ProcessedStatus),
        nameof(NotificationAdviceStatus1Choice.ProcessedStatus)
    )]
    [JsonDerivedType(
        typeof(NotificationAdviceStatus1Choice.RejectedStatus),
        nameof(NotificationAdviceStatus1Choice.RejectedStatus)
    )]
    [IsoId("_Ri1Ctdp-Ed-ak6NoX_4Aeg_-997189670")]
    [DisplayName("Notification Advice Status 1 Choice")]
    public abstract record NotificationAdviceStatus1Choice_ { }
}
