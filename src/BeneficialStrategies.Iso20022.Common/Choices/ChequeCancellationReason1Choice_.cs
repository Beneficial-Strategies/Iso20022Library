// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the cancellation request of a cheque presentment.
    /// </summary>
    [KnownType(typeof(ChequeCancellationReason1Choice.Code))]
    [KnownType(typeof(ChequeCancellationReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(ChequeCancellationReason1Choice.Code),nameof(ChequeCancellationReason1Choice.Code))]
    [JsonDerivedType(typeof(ChequeCancellationReason1Choice.Proprietary),nameof(ChequeCancellationReason1Choice.Proprietary))]
    [IsoId("_kwwc-7tvEeq_cfXrH83Rcw")]
    [DisplayName("Cheque Cancellation Reason 1 Choice")]
    public abstract partial record ChequeCancellationReason1Choice_
    {
    }
}
