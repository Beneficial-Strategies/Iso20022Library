// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of opening balance.
    /// </summary>
    [KnownType(typeof(OpeningBalance4Choice.First))]
    [KnownType(typeof(OpeningBalance4Choice.Intermediary))]
    [JsonDerivedType(typeof(OpeningBalance4Choice.First), nameof(OpeningBalance4Choice.First))]
    [JsonDerivedType(
        typeof(OpeningBalance4Choice.Intermediary),
        nameof(OpeningBalance4Choice.Intermediary)
    )]
    [IsoId("_NIeh0znGEeWV5sr121Fc8A")]
    [DisplayName("Opening Balance 4 Choice")]
    public abstract record OpeningBalance4Choice_ { }
}
