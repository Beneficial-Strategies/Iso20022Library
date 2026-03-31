// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of final and intermediary balances.
    /// </summary>
    [KnownType(typeof(ClosingBalance3Choice.FinalClosingBalance))]
    [KnownType(typeof(ClosingBalance3Choice.IntermediaryClosingBalance))]
    [JsonDerivedType(
        typeof(ClosingBalance3Choice.FinalClosingBalance),
        nameof(ClosingBalance3Choice.FinalClosingBalance)
    )]
    [JsonDerivedType(
        typeof(ClosingBalance3Choice.IntermediaryClosingBalance),
        nameof(ClosingBalance3Choice.IntermediaryClosingBalance)
    )]
    [IsoId("_t8VGsAgHEeSxsfb1OEDVsw")]
    [DisplayName("Closing Balance 3 Choice")]
    public abstract record ClosingBalance3Choice_ { }
}
