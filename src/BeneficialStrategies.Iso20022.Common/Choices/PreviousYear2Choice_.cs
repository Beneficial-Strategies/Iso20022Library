// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between selected investment plans issued during previous years or all investment plans.
    /// </summary>
    [KnownType(typeof(PreviousYear2Choice.AllPreviousYears))]
    [KnownType(typeof(PreviousYear2Choice.SpecificPreviousYears))]
    [JsonDerivedType(
        typeof(PreviousYear2Choice.AllPreviousYears),
        nameof(PreviousYear2Choice.AllPreviousYears)
    )]
    [JsonDerivedType(
        typeof(PreviousYear2Choice.SpecificPreviousYears),
        nameof(PreviousYear2Choice.SpecificPreviousYears)
    )]
    [IsoId("_dNZ_cbNBEeex65jrLOfSTw")]
    [DisplayName("Previous Year 2 Choice")]
    public abstract record PreviousYear2Choice_ { }
}
