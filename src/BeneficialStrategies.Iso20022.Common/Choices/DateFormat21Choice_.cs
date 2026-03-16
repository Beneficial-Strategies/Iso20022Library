// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the value of a date.
    /// </summary>
    [KnownType(typeof(DateFormat21Choice.Date))]
    [KnownType(typeof(DateFormat21Choice.NotSpecifiedDate))]
    [JsonDerivedType(typeof(DateFormat21Choice.Date), nameof(DateFormat21Choice.Date))]
    [JsonDerivedType(
        typeof(DateFormat21Choice.NotSpecifiedDate),
        nameof(DateFormat21Choice.NotSpecifiedDate)
    )]
    [IsoId("_5PdBsfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Date Format 21 Choice")]
    public abstract record DateFormat21Choice_ { }
}
