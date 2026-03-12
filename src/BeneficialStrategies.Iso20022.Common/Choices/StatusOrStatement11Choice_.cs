// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status or statement that is requested.
    /// </summary>
    [KnownType(typeof(StatusOrStatement11Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement11Choice.Statement))]
    [JsonDerivedType(typeof(StatusOrStatement11Choice.StatusAdvice),nameof(StatusOrStatement11Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement11Choice.Statement),nameof(StatusOrStatement11Choice.Statement))]
    [IsoId("_4dK-USgSEeym1_Zp1BTvEw")]
    [DisplayName("Status Or Statement 11 Choice")]
    public abstract partial record StatusOrStatement11Choice_
    {
    }
}
