// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a deadline code.
    /// </summary>
    [KnownType(typeof(DeadlineCode3Choice.Code))]
    [KnownType(typeof(DeadlineCode3Choice.Proprietary))]
    [JsonDerivedType(typeof(DeadlineCode3Choice.Code), nameof(DeadlineCode3Choice.Code))]
    [JsonDerivedType(
        typeof(DeadlineCode3Choice.Proprietary),
        nameof(DeadlineCode3Choice.Proprietary)
    )]
    [IsoId("_W4fbIUGZEeWqy4niLuXETA")]
    [DisplayName("Deadline Code 3 Choice")]
    public abstract record DeadlineCode3Choice_ { }
}
