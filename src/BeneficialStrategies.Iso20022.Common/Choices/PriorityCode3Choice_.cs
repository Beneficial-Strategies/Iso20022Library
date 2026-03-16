// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Priority is expressed as a code or a text.
    /// </summary>
    [KnownType(typeof(PriorityCode3Choice.Code))]
    [KnownType(typeof(PriorityCode3Choice.Proprietary))]
    [JsonDerivedType(typeof(PriorityCode3Choice.Code), nameof(PriorityCode3Choice.Code))]
    [JsonDerivedType(
        typeof(PriorityCode3Choice.Proprietary),
        nameof(PriorityCode3Choice.Proprietary)
    )]
    [IsoId("_5FjlARbwEeOy-PlRuFSUzQ")]
    [DisplayName("Priority Code 3 Choice")]
    public abstract record PriorityCode3Choice_ { }
}
