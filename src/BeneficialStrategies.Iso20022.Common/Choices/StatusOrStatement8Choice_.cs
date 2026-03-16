// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status or statement that is requested.
    /// </summary>
    [KnownType(typeof(StatusOrStatement8Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement8Choice.Statement))]
    [JsonDerivedType(
        typeof(StatusOrStatement8Choice.StatusAdvice),
        nameof(StatusOrStatement8Choice.StatusAdvice)
    )]
    [JsonDerivedType(
        typeof(StatusOrStatement8Choice.Statement),
        nameof(StatusOrStatement8Choice.Statement)
    )]
    [IsoId("_8RszhZNLEeWGlc8L7oPDIg")]
    [DisplayName("Status Or Statement 8 Choice")]
    public abstract record StatusOrStatement8Choice_ { }
}
