// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status Or Statement13Choice.
    /// </summary>
    [KnownType(typeof(StatusOrStatement13Choice.Statement))]
    [KnownType(typeof(StatusOrStatement13Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement13Choice.Statement),nameof(StatusOrStatement13Choice.Statement))]
    [JsonDerivedType(typeof(StatusOrStatement13Choice.StatusAdvice),nameof(StatusOrStatement13Choice.StatusAdvice))]
    [IsoId("_7CEOEYYREe-Pv9KR9bv9IA")]
    [DisplayName("Status Or Statement13Choice")]
    public abstract partial record StatusOrStatement13Choice_
    {
    }
}
