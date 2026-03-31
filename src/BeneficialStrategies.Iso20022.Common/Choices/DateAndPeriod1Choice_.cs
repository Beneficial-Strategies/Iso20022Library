// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date and period.
    /// </summary>
    [KnownType(typeof(DateAndPeriod1Choice.StatementDate))]
    [KnownType(typeof(DateAndPeriod1Choice.StatementPeriod))]
    [JsonDerivedType(
        typeof(DateAndPeriod1Choice.StatementDate),
        nameof(DateAndPeriod1Choice.StatementDate)
    )]
    [JsonDerivedType(
        typeof(DateAndPeriod1Choice.StatementPeriod),
        nameof(DateAndPeriod1Choice.StatementPeriod)
    )]
    [IsoId("_Qqpdidp-Ed-ak6NoX_4Aeg_-2134500203")]
    [DisplayName("Date And Period 1 Choice")]
    public abstract record DateAndPeriod1Choice_ { }
}
