// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of the tracker alert.
    /// </summary>
    [KnownType(typeof(TrackerAlertStatus1Choice.Code))]
    [KnownType(typeof(TrackerAlertStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(TrackerAlertStatus1Choice.Code),nameof(TrackerAlertStatus1Choice.Code))]
    [JsonDerivedType(typeof(TrackerAlertStatus1Choice.Proprietary),nameof(TrackerAlertStatus1Choice.Proprietary))]
    [IsoId("_M7UA5PWlEemtd4wHZYvFUQ")]
    [DisplayName("Tracker Alert Status 1 Choice")]
    public abstract partial record TrackerAlertStatus1Choice_
    {
    }
}
