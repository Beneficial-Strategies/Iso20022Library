// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of opening balance.
    /// </summary>
    [KnownType(typeof(OpeningBalance5Choice.First))]
    [KnownType(typeof(OpeningBalance5Choice.Intermediary))]
    [JsonDerivedType(typeof(OpeningBalance5Choice.First), nameof(OpeningBalance5Choice.First))]
    [JsonDerivedType(
        typeof(OpeningBalance5Choice.Intermediary),
        nameof(OpeningBalance5Choice.Intermediary)
    )]
    [IsoId("_8bhdbZNLEeWGlc8L7oPDIg")]
    [DisplayName("Opening Balance 5 Choice")]
    public abstract record OpeningBalance5Choice_ { }
}
