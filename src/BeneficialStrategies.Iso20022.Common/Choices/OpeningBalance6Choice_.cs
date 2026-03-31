// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of opening balance.
    /// </summary>
    [KnownType(typeof(OpeningBalance6Choice.First))]
    [KnownType(typeof(OpeningBalance6Choice.Intermediary))]
    [JsonDerivedType(typeof(OpeningBalance6Choice.First), nameof(OpeningBalance6Choice.First))]
    [JsonDerivedType(
        typeof(OpeningBalance6Choice.Intermediary),
        nameof(OpeningBalance6Choice.Intermediary)
    )]
    [IsoId("__xDVUyp7EeyR9JrVGfaMKw")]
    [DisplayName("Opening Balance 6 Choice")]
    public abstract record OpeningBalance6Choice_ { }
}
