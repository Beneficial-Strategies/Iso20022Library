// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status for the cancellation request of a cheque presentment.
    /// </summary>
    [KnownType(typeof(ChequeCancellationStatus1Choice.Code))]
    [KnownType(typeof(ChequeCancellationStatus1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ChequeCancellationStatus1Choice.Code),
        nameof(ChequeCancellationStatus1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ChequeCancellationStatus1Choice.Proprietary),
        nameof(ChequeCancellationStatus1Choice.Proprietary)
    )]
    [IsoId("_PJJT-7tyEeq_cfXrH83Rcw")]
    [DisplayName("Cheque Cancellation Status 1 Choice")]
    public abstract record ChequeCancellationStatus1Choice_ { }
}
