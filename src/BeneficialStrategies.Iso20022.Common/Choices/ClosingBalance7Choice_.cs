// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of closing balance.
    /// </summary>
    [KnownType(typeof(ClosingBalance7Choice.Final))]
    [KnownType(typeof(ClosingBalance7Choice.Intermediary))]
    [JsonDerivedType(typeof(ClosingBalance7Choice.Final),nameof(ClosingBalance7Choice.Final))]
    [JsonDerivedType(typeof(ClosingBalance7Choice.Intermediary),nameof(ClosingBalance7Choice.Intermediary))]
    [IsoId("_gJxaizi8Eeydid5dcNPKvg")]
    [DisplayName("Closing Balance 7 Choice")]
    public abstract partial record ClosingBalance7Choice_
    {
    }
}
