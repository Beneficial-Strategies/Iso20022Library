// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the identification of a status or statement query.
    /// </summary>
    [KnownType(typeof(StatusOrStatement3Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement3Choice.Statement))]
    [JsonDerivedType(typeof(StatusOrStatement3Choice.StatusAdvice),nameof(StatusOrStatement3Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement3Choice.Statement),nameof(StatusOrStatement3Choice.Statement))]
    [IsoId("_CEeN0fJlEd-DocZblYEqZw")]
    [DisplayName("Status Or Statement 3 Choice")]
    public abstract partial record StatusOrStatement3Choice_
    {
    }
}
