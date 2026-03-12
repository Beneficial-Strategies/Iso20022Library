// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying globally to the instruction received.
    /// </summary>
    [KnownType(typeof(InstructionStatus2Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus2Choice.RejectionStatus))]
    [JsonDerivedType(typeof(InstructionStatus2Choice.ProcessingStatus),nameof(InstructionStatus2Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(InstructionStatus2Choice.RejectionStatus),nameof(InstructionStatus2Choice.RejectionStatus))]
    [IsoId("_RWnLqtp-Ed-ak6NoX_4Aeg_1637255890")]
    [DisplayName("Instruction Status 2 Choice")]
    public abstract partial record InstructionStatus2Choice_
    {
    }
}
