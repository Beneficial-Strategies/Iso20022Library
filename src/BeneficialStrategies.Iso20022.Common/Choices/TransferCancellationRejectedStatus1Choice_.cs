// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [KnownType(typeof(TransferCancellationRejectedStatus1Choice.Reason))]
    [KnownType(typeof(TransferCancellationRejectedStatus1Choice.DataSourceScheme))]
    [JsonDerivedType(
        typeof(TransferCancellationRejectedStatus1Choice.Reason),
        nameof(TransferCancellationRejectedStatus1Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(TransferCancellationRejectedStatus1Choice.DataSourceScheme),
        nameof(TransferCancellationRejectedStatus1Choice.DataSourceScheme)
    )]
    [IsoId("_U0fAstp-Ed-ak6NoX_4Aeg_330240032")]
    [DisplayName("Transfer Cancellation Rejected Status 1 Choice")]
    public abstract record TransferCancellationRejectedStatus1Choice_ { }
}
