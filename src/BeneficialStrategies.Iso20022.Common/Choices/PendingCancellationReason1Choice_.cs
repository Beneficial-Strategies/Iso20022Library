// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingCancellationReason1Choice.Code))]
    [KnownType(typeof(PendingCancellationReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingCancellationReason1Choice.Code),nameof(PendingCancellationReason1Choice.Code))]
    [JsonDerivedType(typeof(PendingCancellationReason1Choice.Proprietary),nameof(PendingCancellationReason1Choice.Proprietary))]
    [IsoId("_Qx8_Ydp-Ed-ak6NoX_4Aeg_21307425")]
    [DisplayName("Pending Cancellation Reason 1 Choice")]
    public abstract partial record PendingCancellationReason1Choice_
    {
    }
}
