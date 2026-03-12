// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the cancellation request of the transaction.
    /// </summary>
    [KnownType(typeof(CancellationReason1Choice.Code))]
    [KnownType(typeof(CancellationReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason1Choice.Code),nameof(CancellationReason1Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason1Choice.Proprietary),nameof(CancellationReason1Choice.Proprietary))]
    [IsoId("_TO3Gs9p-Ed-ak6NoX_4Aeg_-748049495")]
    [DisplayName("Cancellation Reason 1 Choice")]
    public abstract partial record CancellationReason1Choice_
    {
    }
}
