// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between selected investment plans issued during previous years or the entirety of the investment plans.
    /// </summary>
    [KnownType(typeof(PreviousYearChoice.AllPreviousYears))]
    [KnownType(typeof(PreviousYearChoice.SpecificPreviousYears))]
    [JsonDerivedType(
        typeof(PreviousYearChoice.AllPreviousYears),
        nameof(PreviousYearChoice.AllPreviousYears)
    )]
    [JsonDerivedType(
        typeof(PreviousYearChoice.SpecificPreviousYears),
        nameof(PreviousYearChoice.SpecificPreviousYears)
    )]
    [IsoId("_Rb-Mwdp-Ed-ak6NoX_4Aeg_-639862937")]
    [DisplayName("Previous Year Choice")]
    public abstract record PreviousYearChoice_ { }
}
