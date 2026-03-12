// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the status.
    /// </summary>
    [KnownType(typeof(Status20Choice.Status))]
    [KnownType(typeof(Status20Choice.Rejected))]
    [JsonDerivedType(typeof(Status20Choice.Status),nameof(Status20Choice.Status))]
    [JsonDerivedType(typeof(Status20Choice.Rejected),nameof(Status20Choice.Rejected))]
    [IsoId("_qOyAZSGaEeWKAaDJcYGKLw")]
    [DisplayName("Status 20 Choice")]
    public abstract partial record Status20Choice_
    {
    }
}
