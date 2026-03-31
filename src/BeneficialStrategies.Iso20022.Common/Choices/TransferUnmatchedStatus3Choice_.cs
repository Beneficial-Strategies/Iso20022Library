// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the unmatched status.
    /// </summary>
    [KnownType(typeof(TransferUnmatchedStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(TransferUnmatchedStatus3Choice.Reason))]
    [KnownType(typeof(TransferUnmatchedStatus3Choice.ExtendedReason))]
    [KnownType(typeof(TransferUnmatchedStatus3Choice.DataSourceScheme))]
    [JsonDerivedType(
        typeof(TransferUnmatchedStatus3Choice.NoSpecifiedReason),
        nameof(TransferUnmatchedStatus3Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(TransferUnmatchedStatus3Choice.Reason),
        nameof(TransferUnmatchedStatus3Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(TransferUnmatchedStatus3Choice.ExtendedReason),
        nameof(TransferUnmatchedStatus3Choice.ExtendedReason)
    )]
    [JsonDerivedType(
        typeof(TransferUnmatchedStatus3Choice.DataSourceScheme),
        nameof(TransferUnmatchedStatus3Choice.DataSourceScheme)
    )]
    [IsoId("_duzpkSY4EeW_ZNn8gbfY7Q")]
    [DisplayName("Transfer Unmatched Status 3 Choice")]
    public abstract record TransferUnmatchedStatus3Choice_ { }
}
