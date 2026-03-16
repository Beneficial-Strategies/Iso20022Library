// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the forex standing instruction information.
    /// </summary>
    [KnownType(typeof(FXStandingInstruction5Choice.Indicator))]
    [KnownType(typeof(FXStandingInstruction5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FXStandingInstruction5Choice.Indicator),
        nameof(FXStandingInstruction5Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(FXStandingInstruction5Choice.Proprietary),
        nameof(FXStandingInstruction5Choice.Proprietary)
    )]
    [IsoId("_5xrHDZNLEeWGlc8L7oPDIg")]
    [DisplayName("FX Standing Instruction 5 Choice")]
    public abstract record FXStandingInstruction5Choice_ { }
}
