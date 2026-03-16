// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the forex standing instruction information.
    /// </summary>
    [KnownType(typeof(FXStandingInstruction4Choice.Indicator))]
    [KnownType(typeof(FXStandingInstruction4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FXStandingInstruction4Choice.Indicator),
        nameof(FXStandingInstruction4Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(FXStandingInstruction4Choice.Proprietary),
        nameof(FXStandingInstruction4Choice.Proprietary)
    )]
    [IsoId("_aJUtUTtEEeWRTLSN0i0tng")]
    [DisplayName("FX Standing Instruction 4 Choice")]
    public abstract record FXStandingInstruction4Choice_ { }
}
