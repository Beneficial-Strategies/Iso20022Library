// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a period or a period code.
    /// </summary>
    [KnownType(typeof(Period6Choice.Period))]
    [KnownType(typeof(Period6Choice.PeriodCode))]
    [JsonDerivedType(typeof(Period6Choice.Period),nameof(Period6Choice.Period))]
    [JsonDerivedType(typeof(Period6Choice.PeriodCode),nameof(Period6Choice.PeriodCode))]
    [IsoId("_jZvEW7QYEeeKRKrD60ELBQ")]
    [DisplayName("Period 6 Choice")]
    public abstract partial record Period6Choice_
    {
    }
}
