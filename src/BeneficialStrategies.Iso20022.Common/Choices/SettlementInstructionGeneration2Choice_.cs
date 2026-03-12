// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement instruction generation.
    /// </summary>
    [KnownType(typeof(SettlementInstructionGeneration2Choice.Code))]
    [KnownType(typeof(SettlementInstructionGeneration2Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementInstructionGeneration2Choice.Code),nameof(SettlementInstructionGeneration2Choice.Code))]
    [JsonDerivedType(typeof(SettlementInstructionGeneration2Choice.Proprietary),nameof(SettlementInstructionGeneration2Choice.Proprietary))]
    [IsoId("_gb_yQZCBEeakHoV5BVecAQ")]
    [DisplayName("Settlement Instruction Generation 2 Choice")]
    public abstract partial record SettlementInstructionGeneration2Choice_
    {
    }
}
