// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status or statement that is requested.
    /// </summary>
    [KnownType(typeof(StatusOrStatement12Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement12Choice.Statement))]
    [JsonDerivedType(
        typeof(StatusOrStatement12Choice.StatusAdvice),
        nameof(StatusOrStatement12Choice.StatusAdvice)
    )]
    [JsonDerivedType(
        typeof(StatusOrStatement12Choice.Statement),
        nameof(StatusOrStatement12Choice.Statement)
    )]
    [IsoId("_gBH0DTi8Eeydid5dcNPKvg")]
    [DisplayName("Status Or Statement 12 Choice")]
    public abstract record StatusOrStatement12Choice_ { }
}
