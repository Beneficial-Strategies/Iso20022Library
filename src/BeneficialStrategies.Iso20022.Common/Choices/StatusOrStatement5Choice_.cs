// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the identification of a status or statement query.
    /// </summary>
    [KnownType(typeof(StatusOrStatement5Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement5Choice.Statement))]
    [JsonDerivedType(typeof(StatusOrStatement5Choice.StatusAdvice),nameof(StatusOrStatement5Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement5Choice.Statement),nameof(StatusOrStatement5Choice.Statement))]
    [IsoId("_BTEbgf7yEeCvPoRGOxRobQ")]
    [DisplayName("Status Or Statement 5 Choice")]
    public abstract partial record StatusOrStatement5Choice_
    {
    }
}
