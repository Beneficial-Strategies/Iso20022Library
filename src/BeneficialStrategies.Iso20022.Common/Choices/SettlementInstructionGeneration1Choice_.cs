// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement instruction generation.
    /// </summary>
    [KnownType(typeof(SettlementInstructionGeneration1Choice.Code))]
    [KnownType(typeof(SettlementInstructionGeneration1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementInstructionGeneration1Choice.Code),
        nameof(SettlementInstructionGeneration1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementInstructionGeneration1Choice.Proprietary),
        nameof(SettlementInstructionGeneration1Choice.Proprietary)
    )]
    [IsoId("_AbMjstokEeC60axPepSq7g_-1902988326")]
    [DisplayName("Settlement Instruction Generation 1 Choice")]
    public abstract record SettlementInstructionGeneration1Choice_ { }
}
