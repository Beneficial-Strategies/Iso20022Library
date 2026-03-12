// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides acceptance status of the holding item.
    /// </summary>
    [KnownType(typeof(ReportItemStatus1Choice.Accepted))]
    [KnownType(typeof(ReportItemStatus1Choice.AcceptedWithException))]
    [KnownType(typeof(ReportItemStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(ReportItemStatus1Choice.Accepted),nameof(ReportItemStatus1Choice.Accepted))]
    [JsonDerivedType(typeof(ReportItemStatus1Choice.AcceptedWithException),nameof(ReportItemStatus1Choice.AcceptedWithException))]
    [JsonDerivedType(typeof(ReportItemStatus1Choice.Rejected),nameof(ReportItemStatus1Choice.Rejected))]
    [IsoId("_0w3vwb3QEeO2FLWuu_JIqg")]
    [DisplayName("Report Item Status 1 Choice")]
    public abstract partial record ReportItemStatus1Choice_
    {
    }
}
