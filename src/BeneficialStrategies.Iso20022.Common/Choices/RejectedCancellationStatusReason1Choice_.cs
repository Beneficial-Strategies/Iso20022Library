// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for which a cancellation is rejected.
    /// </summary>
    [KnownType(typeof(RejectedCancellationStatusReason1Choice.Reason))]
    [KnownType(typeof(RejectedCancellationStatusReason1Choice.ExtendedReason))]
    [KnownType(typeof(RejectedCancellationStatusReason1Choice.DataSourceScheme))]
    [JsonDerivedType(
        typeof(RejectedCancellationStatusReason1Choice.Reason),
        nameof(RejectedCancellationStatusReason1Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(RejectedCancellationStatusReason1Choice.ExtendedReason),
        nameof(RejectedCancellationStatusReason1Choice.ExtendedReason)
    )]
    [JsonDerivedType(
        typeof(RejectedCancellationStatusReason1Choice.DataSourceScheme),
        nameof(RejectedCancellationStatusReason1Choice.DataSourceScheme)
    )]
    [IsoId("_RXptdNp-Ed-ak6NoX_4Aeg_890850288")]
    [DisplayName("Rejected Cancellation Status Reason 1 Choice")]
    public abstract record RejectedCancellationStatusReason1Choice_ { }
}
