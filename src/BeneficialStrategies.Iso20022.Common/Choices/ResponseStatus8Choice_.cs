// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of response status.
    /// </summary>
    [KnownType(typeof(ResponseStatus8Choice.Consented))]
    [KnownType(typeof(ResponseStatus8Choice.Rejected))]
    [KnownType(typeof(ResponseStatus8Choice.Pending))]
    [JsonDerivedType(
        typeof(ResponseStatus8Choice.Consented),
        nameof(ResponseStatus8Choice.Consented)
    )]
    [JsonDerivedType(
        typeof(ResponseStatus8Choice.Rejected),
        nameof(ResponseStatus8Choice.Rejected)
    )]
    [JsonDerivedType(typeof(ResponseStatus8Choice.Pending), nameof(ResponseStatus8Choice.Pending))]
    [IsoId("_Vl2wJZNSEeWGlc8L7oPDIg")]
    [DisplayName("Response Status 8 Choice")]
    public abstract record ResponseStatus8Choice_ { }
}
