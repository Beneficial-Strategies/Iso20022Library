// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of opening balance.
    /// </summary>
    [KnownType(typeof(OpeningBalance7Choice.First))]
    [KnownType(typeof(OpeningBalance7Choice.Intermediary))]
    [JsonDerivedType(typeof(OpeningBalance7Choice.First),nameof(OpeningBalance7Choice.First))]
    [JsonDerivedType(typeof(OpeningBalance7Choice.Intermediary),nameof(OpeningBalance7Choice.Intermediary))]
    [IsoId("_gJxZ8zi8Eeydid5dcNPKvg")]
    [DisplayName("Opening Balance 7 Choice")]
    public abstract partial record OpeningBalance7Choice_
    {
    }
}
