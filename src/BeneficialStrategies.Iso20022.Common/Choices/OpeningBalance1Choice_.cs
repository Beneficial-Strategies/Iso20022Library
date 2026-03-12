// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of opening balance.
    /// </summary>
    [KnownType(typeof(OpeningBalance1Choice.First))]
    [KnownType(typeof(OpeningBalance1Choice.Intermediary))]
    [JsonDerivedType(typeof(OpeningBalance1Choice.First),nameof(OpeningBalance1Choice.First))]
    [JsonDerivedType(typeof(OpeningBalance1Choice.Intermediary),nameof(OpeningBalance1Choice.Intermediary))]
    [IsoId("_R9Wbh9p-Ed-ak6NoX_4Aeg_-1067705678")]
    [DisplayName("Opening Balance 1 Choice")]
    public abstract partial record OpeningBalance1Choice_
    {
    }
}
