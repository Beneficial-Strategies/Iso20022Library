// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus44Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus44Choice.Cancelled),nameof(InstructionProcessingStatus44Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus44Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus44Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus44Choice.Rejected),nameof(InstructionProcessingStatus44Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus44Choice.Pending),nameof(InstructionProcessingStatus44Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus44Choice.DefaultAction),nameof(InstructionProcessingStatus44Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus44Choice.StandingInstruction),nameof(InstructionProcessingStatus44Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus44Choice.ProprietaryStatus),nameof(InstructionProcessingStatus44Choice.ProprietaryStatus))]
    [IsoId("_9FAl9x9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Processing Status 44 Choice")]
    public abstract partial record InstructionProcessingStatus44Choice_
    {
    }
}
