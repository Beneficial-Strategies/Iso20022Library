// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date and period.
    /// </summary>
    [KnownType(typeof(DateAndPeriod2Choice.Date))]
    [KnownType(typeof(DateAndPeriod2Choice.Period))]
    [KnownType(typeof(DateAndPeriod2Choice.FromDate))]
    [KnownType(typeof(DateAndPeriod2Choice.ToDate))]
    [JsonDerivedType(typeof(DateAndPeriod2Choice.Date),nameof(DateAndPeriod2Choice.Date))]
    [JsonDerivedType(typeof(DateAndPeriod2Choice.Period),nameof(DateAndPeriod2Choice.Period))]
    [JsonDerivedType(typeof(DateAndPeriod2Choice.FromDate),nameof(DateAndPeriod2Choice.FromDate))]
    [JsonDerivedType(typeof(DateAndPeriod2Choice.ToDate),nameof(DateAndPeriod2Choice.ToDate))]
    [IsoId("_76Z3ZaMgEeCJ6YNENx4h-w_1548347311")]
    [DisplayName("Date And Period 2 Choice")]
    public abstract partial record DateAndPeriod2Choice_
    {
    }
}
