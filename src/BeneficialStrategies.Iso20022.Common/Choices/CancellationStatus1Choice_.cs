// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying to the instruction cancellation request received.
    /// </summary>
    [KnownType(typeof(CancellationStatus1Choice.ProcessingStatus))]
    [KnownType(typeof(CancellationStatus1Choice.RejectionStatus))]
    [JsonDerivedType(typeof(CancellationStatus1Choice.ProcessingStatus),nameof(CancellationStatus1Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(CancellationStatus1Choice.RejectionStatus),nameof(CancellationStatus1Choice.RejectionStatus))]
    [IsoId("_RVa41dp-Ed-ak6NoX_4Aeg_-538392841")]
    [DisplayName("Cancellation Status 1 Choice")]
    public abstract partial record CancellationStatus1Choice_
    {
    }
}
