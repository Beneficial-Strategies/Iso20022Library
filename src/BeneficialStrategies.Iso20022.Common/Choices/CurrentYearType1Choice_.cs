// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the selections of individual saving accounts issued during the current fiscal year.
    /// </summary>
    [KnownType(typeof(CurrentYearType1Choice.CurrentYearType))]
    [KnownType(typeof(CurrentYearType1Choice.ExtendedCurrentYearType))]
    [JsonDerivedType(typeof(CurrentYearType1Choice.CurrentYearType),nameof(CurrentYearType1Choice.CurrentYearType))]
    [JsonDerivedType(typeof(CurrentYearType1Choice.ExtendedCurrentYearType),nameof(CurrentYearType1Choice.ExtendedCurrentYearType))]
    [IsoId("_3f6cYEXfEeGY6MkiuzuPOA_1308013300")]
    [DisplayName("Current Year Type 1 Choice")]
    public abstract partial record CurrentYearType1Choice_
    {
    }
}
