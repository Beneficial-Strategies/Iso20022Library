// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a period or a period code.
    /// </summary>
    [KnownType(typeof(Period1Choice.Period))]
    [KnownType(typeof(Period1Choice.PeriodCode))]
    [JsonDerivedType(typeof(Period1Choice.Period),nameof(Period1Choice.Period))]
    [JsonDerivedType(typeof(Period1Choice.PeriodCode),nameof(Period1Choice.PeriodCode))]
    [IsoId("_T5oiBtp-Ed-ak6NoX_4Aeg_-201480059")]
    [DisplayName("Period 1 Choice")]
    public abstract partial record Period1Choice_
    {
    }
}
