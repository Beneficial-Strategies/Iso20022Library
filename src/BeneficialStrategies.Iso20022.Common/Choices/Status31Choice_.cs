// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the status.
    /// </summary>
    [KnownType(typeof(Status31Choice.Status))]
    [KnownType(typeof(Status31Choice.Rejected))]
    [KnownType(typeof(Status31Choice.Complete))]
    [KnownType(typeof(Status31Choice.Pending))]
    [JsonDerivedType(typeof(Status31Choice.Status), nameof(Status31Choice.Status))]
    [JsonDerivedType(typeof(Status31Choice.Rejected), nameof(Status31Choice.Rejected))]
    [JsonDerivedType(typeof(Status31Choice.Complete), nameof(Status31Choice.Complete))]
    [JsonDerivedType(typeof(Status31Choice.Pending), nameof(Status31Choice.Pending))]
    [IsoId("_ySVFQZM6EemKz5EOjv82iQ")]
    [DisplayName("Status 31 Choice")]
    public abstract record Status31Choice_ { }
}
