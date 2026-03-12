// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status or statement that is requested.
    /// </summary>
    [KnownType(typeof(StatusOrStatement10Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement10Choice.Statement))]
    [JsonDerivedType(typeof(StatusOrStatement10Choice.StatusAdvice),nameof(StatusOrStatement10Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement10Choice.Statement),nameof(StatusOrStatement10Choice.Statement))]
    [IsoId("_LSk41_fZEeiNZp_PtLohLw")]
    [DisplayName("Status Or Statement 10 Choice")]
    public abstract partial record StatusOrStatement10Choice_
    {
    }
}
