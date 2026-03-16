// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the selections of individual saving accounts issued during the current fiscal year.
    /// </summary>
    [KnownType(typeof(CurrentYearType2Choice.CurrentYearType))]
    [KnownType(typeof(CurrentYearType2Choice.ExtendedCurrentYearType))]
    [JsonDerivedType(
        typeof(CurrentYearType2Choice.CurrentYearType),
        nameof(CurrentYearType2Choice.CurrentYearType)
    )]
    [JsonDerivedType(
        typeof(CurrentYearType2Choice.ExtendedCurrentYearType),
        nameof(CurrentYearType2Choice.ExtendedCurrentYearType)
    )]
    [IsoId("_3f6cY0XfEeGY6MkiuzuPOA_-540956173")]
    [DisplayName("Current Year Type 2 Choice")]
    public abstract record CurrentYearType2Choice_ { }
}
