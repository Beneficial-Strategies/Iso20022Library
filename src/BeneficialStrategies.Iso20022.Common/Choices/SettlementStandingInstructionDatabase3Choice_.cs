// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the standing settlement instruction information.
    /// </summary>
    [KnownType(typeof(SettlementStandingInstructionDatabase3Choice.Code))]
    [KnownType(typeof(SettlementStandingInstructionDatabase3Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStandingInstructionDatabase3Choice.Code),nameof(SettlementStandingInstructionDatabase3Choice.Code))]
    [JsonDerivedType(typeof(SettlementStandingInstructionDatabase3Choice.Proprietary),nameof(SettlementStandingInstructionDatabase3Choice.Proprietary))]
    [IsoId("_AbWUtdokEeC60axPepSq7g_-1066698614")]
    [DisplayName("Settlement Standing Instruction Database 3 Choice")]
    public abstract partial record SettlementStandingInstructionDatabase3Choice_
    {
    }
}
