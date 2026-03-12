// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus24Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.Cancelled),nameof(InstructionProcessingStatus24Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus24Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.Rejected),nameof(InstructionProcessingStatus24Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.Pending),nameof(InstructionProcessingStatus24Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.DefaultAction),nameof(InstructionProcessingStatus24Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.StandingInstruction),nameof(InstructionProcessingStatus24Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.ProprietaryStatus),nameof(InstructionProcessingStatus24Choice.ProprietaryStatus))]
    [IsoId("_wj9GAUGUEeWqy4niLuXETA")]
    [DisplayName("Instruction Processing Status 24 Choice")]
    public abstract partial record InstructionProcessingStatus24Choice_
    {
    }
}
