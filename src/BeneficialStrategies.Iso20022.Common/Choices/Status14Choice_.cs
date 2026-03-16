// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the status.
    /// </summary>
    [KnownType(typeof(Status14Choice.Status))]
    [KnownType(typeof(Status14Choice.Rejected))]
    [JsonDerivedType(typeof(Status14Choice.Status), nameof(Status14Choice.Status))]
    [JsonDerivedType(typeof(Status14Choice.Rejected), nameof(Status14Choice.Rejected))]
    [IsoId("_HT5NMR6rEeODgY9qxg6TFA")]
    [DisplayName("Status 14 Choice")]
    public abstract record Status14Choice_ { }
}
