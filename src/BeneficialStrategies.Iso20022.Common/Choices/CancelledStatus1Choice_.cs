// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction or instruction cancellation cancelled/cancellation completed status.
    /// </summary>
    [KnownType(typeof(CancelledStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus1Choice.Reason))]
    [JsonDerivedType(
        typeof(CancelledStatus1Choice.NoSpecifiedReason),
        nameof(CancelledStatus1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(CancelledStatus1Choice.Reason), nameof(CancelledStatus1Choice.Reason))]
    [IsoId("_Qy2XRtp-Ed-ak6NoX_4Aeg_-1326182926")]
    [DisplayName("Cancelled Status 1 Choice")]
    public abstract record CancelledStatus1Choice_ { }
}
