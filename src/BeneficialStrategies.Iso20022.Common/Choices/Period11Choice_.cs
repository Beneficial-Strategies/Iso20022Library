// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Period11Choice.
    /// </summary>
    [KnownType(typeof(Period11Choice.Date))]
    [KnownType(typeof(Period11Choice.FromDate))]
    [KnownType(typeof(Period11Choice.FromToDate))]
    [KnownType(typeof(Period11Choice.FromToDateTime))]
    [KnownType(typeof(Period11Choice.ToDate))]
    [JsonDerivedType(typeof(Period11Choice.Date), nameof(Period11Choice.Date))]
    [JsonDerivedType(typeof(Period11Choice.FromDate), nameof(Period11Choice.FromDate))]
    [JsonDerivedType(typeof(Period11Choice.FromToDate), nameof(Period11Choice.FromToDate))]
    [JsonDerivedType(typeof(Period11Choice.FromToDateTime), nameof(Period11Choice.FromToDateTime))]
    [JsonDerivedType(typeof(Period11Choice.ToDate), nameof(Period11Choice.ToDate))]
    [IsoId("_3JrykTgtEe60j93i-cxu5Q")]
    [DisplayName("Period11Choice")]
    public abstract record Period11Choice_ { }
}
