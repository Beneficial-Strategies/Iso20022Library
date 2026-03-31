// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of opening and intermediary balances.
    /// </summary>
    [KnownType(typeof(OpeningBalance3Choice.FirstOpeningBalance))]
    [KnownType(typeof(OpeningBalance3Choice.IntermediaryOpeningBalance))]
    [JsonDerivedType(
        typeof(OpeningBalance3Choice.FirstOpeningBalance),
        nameof(OpeningBalance3Choice.FirstOpeningBalance)
    )]
    [JsonDerivedType(
        typeof(OpeningBalance3Choice.IntermediaryOpeningBalance),
        nameof(OpeningBalance3Choice.IntermediaryOpeningBalance)
    )]
    [IsoId("_Lu4l8QgHEeSxsfb1OEDVsw")]
    [DisplayName("Opening Balance 3 Choice")]
    public abstract record OpeningBalance3Choice_ { }
}
