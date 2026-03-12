// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status is rejected.
    /// </summary>
    [KnownType(typeof(RejectedStatus3Choice.Reason))]
    [KnownType(typeof(RejectedStatus3Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(RejectedStatus3Choice.Reason),nameof(RejectedStatus3Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus3Choice.DataSourceScheme),nameof(RejectedStatus3Choice.DataSourceScheme))]
    [IsoId("_U23mWtp-Ed-ak6NoX_4Aeg_-368695389")]
    [DisplayName("Rejected Status 3 Choice")]
    public abstract partial record RejectedStatus3Choice_
    {
    }
}
