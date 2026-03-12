// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of response status.
    /// </summary>
    [KnownType(typeof(ResponseStatus6Choice.Consented))]
    [KnownType(typeof(ResponseStatus6Choice.Rejected))]
    [KnownType(typeof(ResponseStatus6Choice.Pending))]
    [JsonDerivedType(typeof(ResponseStatus6Choice.Consented),nameof(ResponseStatus6Choice.Consented))]
    [JsonDerivedType(typeof(ResponseStatus6Choice.Rejected),nameof(ResponseStatus6Choice.Rejected))]
    [JsonDerivedType(typeof(ResponseStatus6Choice.Pending),nameof(ResponseStatus6Choice.Pending))]
    [IsoId("_l8zcITzpEeWeNtT0s2RbkQ")]
    [DisplayName("Response Status 6 Choice")]
    public abstract partial record ResponseStatus6Choice_
    {
    }
}
