// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus2Choice.Code))]
    [KnownType(typeof(InstructionProcessingStatus2Choice.Proprietary))]
    [JsonDerivedType(typeof(InstructionProcessingStatus2Choice.Code),nameof(InstructionProcessingStatus2Choice.Code))]
    [JsonDerivedType(typeof(InstructionProcessingStatus2Choice.Proprietary),nameof(InstructionProcessingStatus2Choice.Proprietary))]
    [IsoId("_UYBuMNp-Ed-ak6NoX_4Aeg_-1515031070")]
    [DisplayName("Instruction Processing Status 2 Choice")]
    public abstract partial record InstructionProcessingStatus2Choice_
    {
    }
}
