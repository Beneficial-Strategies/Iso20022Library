// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the dispute notification details for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(DisputeNotification2Choice.DisputeNotificationDetails))]
    [KnownType(typeof(DisputeNotification2Choice.SegregatedIndependentAmountDisputeDetails))]
    [JsonDerivedType(typeof(DisputeNotification2Choice.DisputeNotificationDetails),nameof(DisputeNotification2Choice.DisputeNotificationDetails))]
    [JsonDerivedType(typeof(DisputeNotification2Choice.SegregatedIndependentAmountDisputeDetails),nameof(DisputeNotification2Choice.SegregatedIndependentAmountDisputeDetails))]
    [IsoId("_KLqxkStOEeyOa655cLd-DQ")]
    [DisplayName("Dispute Notification 2 Choice")]
    public abstract partial record DisputeNotification2Choice_
    {
    }
}
