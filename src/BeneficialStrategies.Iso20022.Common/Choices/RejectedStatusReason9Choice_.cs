// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for which a transaction report is rejected.
    /// </summary>
    [KnownType(typeof(RejectedStatusReason9Choice.Reason))]
    [KnownType(typeof(RejectedStatusReason9Choice.ExtendedReason))]
    [KnownType(typeof(RejectedStatusReason9Choice.DataSourceScheme))]
    [JsonDerivedType(
        typeof(RejectedStatusReason9Choice.Reason),
        nameof(RejectedStatusReason9Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(RejectedStatusReason9Choice.ExtendedReason),
        nameof(RejectedStatusReason9Choice.ExtendedReason)
    )]
    [JsonDerivedType(
        typeof(RejectedStatusReason9Choice.DataSourceScheme),
        nameof(RejectedStatusReason9Choice.DataSourceScheme)
    )]
    [IsoId("_RXWyh9p-Ed-ak6NoX_4Aeg_-1456677531")]
    [DisplayName("Rejected Status Reason 9 Choice")]
    public abstract record RejectedStatusReason9Choice_ { }
}
