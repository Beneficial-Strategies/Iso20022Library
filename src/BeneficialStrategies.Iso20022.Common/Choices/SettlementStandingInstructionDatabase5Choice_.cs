// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the standing settlement instruction information.
    /// </summary>
    [KnownType(typeof(SettlementStandingInstructionDatabase5Choice.Code))]
    [KnownType(typeof(SettlementStandingInstructionDatabase5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStandingInstructionDatabase5Choice.Code),
        nameof(SettlementStandingInstructionDatabase5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementStandingInstructionDatabase5Choice.Proprietary),
        nameof(SettlementStandingInstructionDatabase5Choice.Proprietary)
    )]
    [IsoId("_5myE3JNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Standing Instruction Database 5 Choice")]
    public abstract record SettlementStandingInstructionDatabase5Choice_ { }
}
