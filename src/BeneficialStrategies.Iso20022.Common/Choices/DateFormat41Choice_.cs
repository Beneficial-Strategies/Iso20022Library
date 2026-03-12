// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat41Choice.Date))]
    [KnownType(typeof(DateFormat41Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat41Choice.Date),nameof(DateFormat41Choice.Date))]
    [JsonDerivedType(typeof(DateFormat41Choice.DateCode),nameof(DateFormat41Choice.DateCode))]
    [IsoId("_c5LiM5KQEeWHWpTQn1FFVg")]
    [DisplayName("Date Format 41 Choice")]
    public abstract partial record DateFormat41Choice_
    {
    }
}
