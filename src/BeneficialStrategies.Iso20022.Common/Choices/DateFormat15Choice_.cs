// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the date.
    /// </summary>
    [KnownType(typeof(DateFormat15Choice.Date))]
    [KnownType(typeof(DateFormat15Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat15Choice.Date), nameof(DateFormat15Choice.Date))]
    [JsonDerivedType(typeof(DateFormat15Choice.DateCode), nameof(DateFormat15Choice.DateCode))]
    [IsoId("_QmL0QNp-Ed-ak6NoX_4Aeg_838705942")]
    [DisplayName("Date Format 15 Choice")]
    public abstract record DateFormat15Choice_ { }
}
