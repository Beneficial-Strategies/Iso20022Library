// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the date.
    /// </summary>
    [KnownType(typeof(DateCode18Choice.Code))]
    [KnownType(typeof(DateCode18Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode18Choice.Code),nameof(DateCode18Choice.Code))]
    [JsonDerivedType(typeof(DateCode18Choice.Proprietary),nameof(DateCode18Choice.Proprietary))]
    [IsoId("_ZtQSJzqkEeWyoP0PbocV1Q")]
    [DisplayName("Date Code 18 Choice")]
    public abstract partial record DateCode18Choice_
    {
    }
}
