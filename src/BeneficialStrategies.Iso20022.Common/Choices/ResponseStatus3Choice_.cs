// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of response status.
    /// </summary>
    [KnownType(typeof(ResponseStatus3Choice.Consented))]
    [KnownType(typeof(ResponseStatus3Choice.Rejected))]
    [KnownType(typeof(ResponseStatus3Choice.Pending))]
    [JsonDerivedType(typeof(ResponseStatus3Choice.Consented),nameof(ResponseStatus3Choice.Consented))]
    [JsonDerivedType(typeof(ResponseStatus3Choice.Rejected),nameof(ResponseStatus3Choice.Rejected))]
    [JsonDerivedType(typeof(ResponseStatus3Choice.Pending),nameof(ResponseStatus3Choice.Pending))]
    [IsoId("_0j-I4AlIEeGATtfOBToyew_1037532092")]
    [DisplayName("Response Status 3 Choice")]
    public abstract partial record ResponseStatus3Choice_
    {
    }
}
