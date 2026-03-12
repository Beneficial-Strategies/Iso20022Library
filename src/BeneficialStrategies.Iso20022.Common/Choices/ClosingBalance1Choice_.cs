// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of closing balance.
    /// </summary>
    [KnownType(typeof(ClosingBalance1Choice.Final))]
    [KnownType(typeof(ClosingBalance1Choice.Intermediary))]
    [JsonDerivedType(typeof(ClosingBalance1Choice.Final),nameof(ClosingBalance1Choice.Final))]
    [JsonDerivedType(typeof(ClosingBalance1Choice.Intermediary),nameof(ClosingBalance1Choice.Intermediary))]
    [IsoId("_R9NRn9p-Ed-ak6NoX_4Aeg_-1862201522")]
    [DisplayName("Closing Balance 1 Choice")]
    public abstract partial record ClosingBalance1Choice_
    {
    }
}
