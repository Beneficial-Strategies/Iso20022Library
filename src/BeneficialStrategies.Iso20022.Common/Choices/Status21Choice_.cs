// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the status.
    /// </summary>
    [KnownType(typeof(Status21Choice.Status))]
    [KnownType(typeof(Status21Choice.Rejected))]
    [KnownType(typeof(Status21Choice.Complete))]
    [KnownType(typeof(Status21Choice.Pending))]
    [JsonDerivedType(typeof(Status21Choice.Status), nameof(Status21Choice.Status))]
    [JsonDerivedType(typeof(Status21Choice.Rejected), nameof(Status21Choice.Rejected))]
    [JsonDerivedType(typeof(Status21Choice.Complete), nameof(Status21Choice.Complete))]
    [JsonDerivedType(typeof(Status21Choice.Pending), nameof(Status21Choice.Pending))]
    [IsoId("_zx7jgSYtEeW_ZNn8gbfY7Q")]
    [DisplayName("Status 21 Choice")]
    public abstract record Status21Choice_ { }
}
