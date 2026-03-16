// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the standing settlement instruction information.
    /// </summary>
    [KnownType(typeof(SettlementStandingInstructionDatabase4Choice.Code))]
    [KnownType(typeof(SettlementStandingInstructionDatabase4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStandingInstructionDatabase4Choice.Code),
        nameof(SettlementStandingInstructionDatabase4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementStandingInstructionDatabase4Choice.Proprietary),
        nameof(SettlementStandingInstructionDatabase4Choice.Proprietary)
    )]
    [IsoId("_OX40sTtGEeWRTLSN0i0tng")]
    [DisplayName("Settlement Standing Instruction Database 4 Choice")]
    public abstract record SettlementStandingInstructionDatabase4Choice_ { }
}
