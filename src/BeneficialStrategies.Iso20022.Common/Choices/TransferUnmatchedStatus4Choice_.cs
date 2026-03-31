// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the unmatched status.
    /// </summary>
    [KnownType(typeof(TransferUnmatchedStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(TransferUnmatchedStatus4Choice.Reason))]
    [KnownType(typeof(TransferUnmatchedStatus4Choice.ExtendedReason))]
    [KnownType(typeof(TransferUnmatchedStatus4Choice.DataSourceScheme))]
    [JsonDerivedType(
        typeof(TransferUnmatchedStatus4Choice.NoSpecifiedReason),
        nameof(TransferUnmatchedStatus4Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(TransferUnmatchedStatus4Choice.Reason),
        nameof(TransferUnmatchedStatus4Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(TransferUnmatchedStatus4Choice.ExtendedReason),
        nameof(TransferUnmatchedStatus4Choice.ExtendedReason)
    )]
    [JsonDerivedType(
        typeof(TransferUnmatchedStatus4Choice.DataSourceScheme),
        nameof(TransferUnmatchedStatus4Choice.DataSourceScheme)
    )]
    [IsoId("_knN1kZM5EemKz5EOjv82iQ")]
    [DisplayName("Transfer Unmatched Status 4 Choice")]
    public abstract record TransferUnmatchedStatus4Choice_ { }
}
