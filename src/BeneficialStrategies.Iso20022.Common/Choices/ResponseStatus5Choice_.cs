// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the response status.
    /// </summary>
    [KnownType(typeof(ResponseStatus5Choice.Code))]
    [KnownType(typeof(ResponseStatus5Choice.Proprietary))]
    [JsonDerivedType(typeof(ResponseStatus5Choice.Code), nameof(ResponseStatus5Choice.Code))]
    [JsonDerivedType(
        typeof(ResponseStatus5Choice.Proprietary),
        nameof(ResponseStatus5Choice.Proprietary)
    )]
    [IsoId("_kFqooTqqEeWyoP0PbocV1Q")]
    [DisplayName("Response Status 5 Choice")]
    public abstract record ResponseStatus5Choice_ { }
}
