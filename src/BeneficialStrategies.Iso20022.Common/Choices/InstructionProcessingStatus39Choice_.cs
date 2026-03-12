// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus39Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.Cancelled),nameof(InstructionProcessingStatus39Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus39Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.Rejected),nameof(InstructionProcessingStatus39Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.Pending),nameof(InstructionProcessingStatus39Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.DefaultAction),nameof(InstructionProcessingStatus39Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.StandingInstruction),nameof(InstructionProcessingStatus39Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.ProprietaryStatus),nameof(InstructionProcessingStatus39Choice.ProprietaryStatus))]
    [IsoId("_Pl7SQAVSEeqjd8n6wD9JVw")]
    [DisplayName("Instruction Processing Status 39 Choice")]
    public abstract partial record InstructionProcessingStatus39Choice_
    {
    }
}
