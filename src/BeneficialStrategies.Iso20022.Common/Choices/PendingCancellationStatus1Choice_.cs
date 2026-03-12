// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus1Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus1Choice.Reason))]
    [JsonDerivedType(typeof(PendingCancellationStatus1Choice.NotSpecifiedReason),nameof(PendingCancellationStatus1Choice.NotSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus1Choice.Reason),nameof(PendingCancellationStatus1Choice.Reason))]
    [IsoId("_Qx8_atp-Ed-ak6NoX_4Aeg_-810729399")]
    [DisplayName("Pending Cancellation Status 1 Choice")]
    public abstract partial record PendingCancellationStatus1Choice_
    {
    }
}
