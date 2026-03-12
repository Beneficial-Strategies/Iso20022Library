// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the value of a date.
    /// </summary>
    [KnownType(typeof(DateFormat45Choice.Date))]
    [KnownType(typeof(DateFormat45Choice.NotSpecifiedDate))]
    [JsonDerivedType(typeof(DateFormat45Choice.Date),nameof(DateFormat45Choice.Date))]
    [JsonDerivedType(typeof(DateFormat45Choice.NotSpecifiedDate),nameof(DateFormat45Choice.NotSpecifiedDate))]
    [IsoId("_j3y5LbQYEeeKRKrD60ELBQ")]
    [DisplayName("Date Format 45 Choice")]
    public abstract partial record DateFormat45Choice_
    {
    }
}
