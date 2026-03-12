// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the dispute notification details for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(DisputeNotification1Choice.DisputeNotificationDetails))]
    [KnownType(typeof(DisputeNotification1Choice.SegregatedIndependentAmountDisputeDetails))]
    [JsonDerivedType(typeof(DisputeNotification1Choice.DisputeNotificationDetails),nameof(DisputeNotification1Choice.DisputeNotificationDetails))]
    [JsonDerivedType(typeof(DisputeNotification1Choice.SegregatedIndependentAmountDisputeDetails),nameof(DisputeNotification1Choice.SegregatedIndependentAmountDisputeDetails))]
    [IsoId("_QmU-Mtp-Ed-ak6NoX_4Aeg_2020917030")]
    [DisplayName("Dispute Notification 1 Choice")]
    public abstract partial record DisputeNotification1Choice_
    {
    }
}
