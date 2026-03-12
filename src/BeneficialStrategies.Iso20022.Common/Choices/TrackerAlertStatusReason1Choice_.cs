// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the status of the tracker alert.
    /// </summary>
    [KnownType(typeof(TrackerAlertStatusReason1Choice.Code))]
    [KnownType(typeof(TrackerAlertStatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(TrackerAlertStatusReason1Choice.Code),nameof(TrackerAlertStatusReason1Choice.Code))]
    [JsonDerivedType(typeof(TrackerAlertStatusReason1Choice.Proprietary),nameof(TrackerAlertStatusReason1Choice.Proprietary))]
    [IsoId("_mtb_6c79EemEIuVuDudp4g")]
    [DisplayName("Tracker Alert Status Reason 1 Choice")]
    public abstract partial record TrackerAlertStatusReason1Choice_
    {
    }
}
