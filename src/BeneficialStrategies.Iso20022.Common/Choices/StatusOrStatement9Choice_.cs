// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status or statement that is requested.
    /// </summary>
    [KnownType(typeof(StatusOrStatement9Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement9Choice.Statement))]
    [JsonDerivedType(typeof(StatusOrStatement9Choice.StatusAdvice),nameof(StatusOrStatement9Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement9Choice.Statement),nameof(StatusOrStatement9Choice.Statement))]
    [IsoId("_9a9TMdBxEeihG9bKfarOOA")]
    [DisplayName("Status Or Statement 9 Choice")]
    public abstract partial record StatusOrStatement9Choice_
    {
    }
}
