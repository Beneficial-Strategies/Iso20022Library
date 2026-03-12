// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between date and date-time for the specification of a period.
    /// </summary>
    [KnownType(typeof(Period8Choice.DateTime))]
    [KnownType(typeof(Period8Choice.FromDateTime))]
    [KnownType(typeof(Period8Choice.ToDateTime))]
    [KnownType(typeof(Period8Choice.FromDateToDate))]
    [JsonDerivedType(typeof(Period8Choice.DateTime),nameof(Period8Choice.DateTime))]
    [JsonDerivedType(typeof(Period8Choice.FromDateTime),nameof(Period8Choice.FromDateTime))]
    [JsonDerivedType(typeof(Period8Choice.ToDateTime),nameof(Period8Choice.ToDateTime))]
    [JsonDerivedType(typeof(Period8Choice.FromDateToDate),nameof(Period8Choice.FromDateToDate))]
    [IsoId("_ctoHOP1cEeiAfJEqh4xF_Q")]
    [DisplayName("Period 8 Choice")]
    public abstract partial record Period8Choice_
    {
    }
}
