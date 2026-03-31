// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the status.
    /// </summary>
    [KnownType(typeof(Status25Choice.Status))]
    [KnownType(typeof(Status25Choice.Rejected))]
    [JsonDerivedType(typeof(Status25Choice.Status), nameof(Status25Choice.Status))]
    [JsonDerivedType(typeof(Status25Choice.Rejected), nameof(Status25Choice.Rejected))]
    [IsoId("_EcQ-wUQTEealVdmlTDXWkw")]
    [DisplayName("Status 25 Choice")]
    public abstract record Status25Choice_ { }
}
