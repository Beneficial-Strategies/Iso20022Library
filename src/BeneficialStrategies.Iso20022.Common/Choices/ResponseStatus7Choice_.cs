// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the response status.
    /// </summary>
    [KnownType(typeof(ResponseStatus7Choice.Code))]
    [KnownType(typeof(ResponseStatus7Choice.Proprietary))]
    [JsonDerivedType(typeof(ResponseStatus7Choice.Code), nameof(ResponseStatus7Choice.Code))]
    [JsonDerivedType(
        typeof(ResponseStatus7Choice.Proprietary),
        nameof(ResponseStatus7Choice.Proprietary)
    )]
    [IsoId("_8QcPRZNLEeWGlc8L7oPDIg")]
    [DisplayName("Response Status 7 Choice")]
    public abstract record ResponseStatus7Choice_ { }
}
