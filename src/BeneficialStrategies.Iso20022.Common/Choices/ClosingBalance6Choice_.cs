// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of closing balance.
    /// </summary>
    [KnownType(typeof(ClosingBalance6Choice.Final))]
    [KnownType(typeof(ClosingBalance6Choice.Intermediary))]
    [JsonDerivedType(typeof(ClosingBalance6Choice.Final),nameof(ClosingBalance6Choice.Final))]
    [JsonDerivedType(typeof(ClosingBalance6Choice.Intermediary),nameof(ClosingBalance6Choice.Intermediary))]
    [IsoId("_BpAVcyp8EeyR9JrVGfaMKw")]
    [DisplayName("Closing Balance 6 Choice")]
    public abstract partial record ClosingBalance6Choice_
    {
    }
}
