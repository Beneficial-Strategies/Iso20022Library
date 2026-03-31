// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between selected investment plans issued during previous years or the entirety of the investment plans.
    /// </summary>
    [KnownType(typeof(PreviousYear1Choice.AllPreviousYears))]
    [KnownType(typeof(PreviousYear1Choice.SpecificPreviousYears))]
    [JsonDerivedType(
        typeof(PreviousYear1Choice.AllPreviousYears),
        nameof(PreviousYear1Choice.AllPreviousYears)
    )]
    [JsonDerivedType(
        typeof(PreviousYear1Choice.SpecificPreviousYears),
        nameof(PreviousYear1Choice.SpecificPreviousYears)
    )]
    [IsoId("_3fxScUXfEeGY6MkiuzuPOA_-1781639499")]
    [DisplayName("Previous Year 1 Choice")]
    public abstract record PreviousYear1Choice_ { }
}
