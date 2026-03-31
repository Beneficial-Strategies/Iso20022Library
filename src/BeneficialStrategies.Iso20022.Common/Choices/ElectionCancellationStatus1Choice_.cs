// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between various statuses for an corporate action election cancellation.
    /// </summary>
    [KnownType(typeof(ElectionCancellationStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(ElectionCancellationStatus1Choice.RejectedStatus))]
    [JsonDerivedType(
        typeof(ElectionCancellationStatus1Choice.ProcessedStatus),
        nameof(ElectionCancellationStatus1Choice.ProcessedStatus)
    )]
    [JsonDerivedType(
        typeof(ElectionCancellationStatus1Choice.RejectedStatus),
        nameof(ElectionCancellationStatus1Choice.RejectedStatus)
    )]
    [IsoId("_RiiHwtp-Ed-ak6NoX_4Aeg_1698122957")]
    [DisplayName("Election Cancellation Status 1 Choice")]
    public abstract record ElectionCancellationStatus1Choice_ { }
}
