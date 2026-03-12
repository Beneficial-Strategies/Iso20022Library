// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus8Choice.Reason))]
    [KnownType(typeof(RejectedStatus8Choice.ExtendedReason))]
    [KnownType(typeof(RejectedStatus8Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(RejectedStatus8Choice.Reason),nameof(RejectedStatus8Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus8Choice.ExtendedReason),nameof(RejectedStatus8Choice.ExtendedReason))]
    [JsonDerivedType(typeof(RejectedStatus8Choice.DataSourceScheme),nameof(RejectedStatus8Choice.DataSourceScheme))]
    [IsoId("_RQy3gdp-Ed-ak6NoX_4Aeg_-368514445")]
    [DisplayName("Rejected Status 8 Choice")]
    public abstract partial record RejectedStatus8Choice_
    {
    }
}
