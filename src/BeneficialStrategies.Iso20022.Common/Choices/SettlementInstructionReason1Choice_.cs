// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the settlement instruction reason.
    /// </summary>
    [KnownType(typeof(SettlementInstructionReason1Choice.Code))]
    [KnownType(typeof(SettlementInstructionReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementInstructionReason1Choice.Code),
        nameof(SettlementInstructionReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementInstructionReason1Choice.Proprietary),
        nameof(SettlementInstructionReason1Choice.Proprietary)
    )]
    [IsoId("_YtrTQCCsEeWJd9HF2tO7BA")]
    [DisplayName("Settlement Instruction Reason 1 Choice")]
    public abstract record SettlementInstructionReason1Choice_ { }
}
