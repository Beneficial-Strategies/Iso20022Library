// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the status.
    /// </summary>
    [KnownType(typeof(Status12Choice.Status))]
    [KnownType(typeof(Status12Choice.Rejected))]
    [JsonDerivedType(typeof(Status12Choice.Status),nameof(Status12Choice.Status))]
    [JsonDerivedType(typeof(Status12Choice.Rejected),nameof(Status12Choice.Rejected))]
    [IsoId("_BspiIxdSEeK5g-3oYI0_9Q")]
    [DisplayName("Status 12 Choice")]
    public abstract partial record Status12Choice_
    {
    }
}
