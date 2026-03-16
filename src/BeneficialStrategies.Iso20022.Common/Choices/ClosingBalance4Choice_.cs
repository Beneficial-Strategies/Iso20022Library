// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of closing balance.
    /// </summary>
    [KnownType(typeof(ClosingBalance4Choice.Final))]
    [KnownType(typeof(ClosingBalance4Choice.Intermediary))]
    [JsonDerivedType(typeof(ClosingBalance4Choice.Final), nameof(ClosingBalance4Choice.Final))]
    [JsonDerivedType(
        typeof(ClosingBalance4Choice.Intermediary),
        nameof(ClosingBalance4Choice.Intermediary)
    )]
    [IsoId("_Qd928znGEeWV5sr121Fc8A")]
    [DisplayName("Closing Balance 4 Choice")]
    public abstract record ClosingBalance4Choice_ { }
}
