// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date and period.
    /// </summary>
    [KnownType(typeof(DateAndPeriod3Choice.StatementDate))]
    [KnownType(typeof(DateAndPeriod3Choice.StatementPeriod))]
    [JsonDerivedType(typeof(DateAndPeriod3Choice.StatementDate),nameof(DateAndPeriod3Choice.StatementDate))]
    [JsonDerivedType(typeof(DateAndPeriod3Choice.StatementPeriod),nameof(DateAndPeriod3Choice.StatementPeriod))]
    [IsoId("_xstj3QzJEeuTPv2wqaotHg")]
    [DisplayName("Date And Period 3 Choice")]
    public abstract partial record DateAndPeriod3Choice_
    {
    }
}
