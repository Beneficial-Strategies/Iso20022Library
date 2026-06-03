// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus59Choice.AcceptedAndConfirmed))]
    [KnownType(typeof(InstructionProcessingStatus59Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus59Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus59Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus59Choice.AcceptedAndConfirmed), nameof(InstructionProcessingStatus59Choice.AcceptedAndConfirmed))]
    [JsonDerivedType(typeof(InstructionProcessingStatus59Choice.Rejected), nameof(InstructionProcessingStatus59Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus59Choice.Pending), nameof(InstructionProcessingStatus59Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus59Choice.ProprietaryStatus), nameof(InstructionProcessingStatus59Choice.ProprietaryStatus))]
    [IsoId("_j6NGgd75Ee-NrtAAlrBEgQ")]
    [DisplayName("Instruction Processing Status 59 Choice")]
    public abstract record InstructionProcessingStatus59Choice_ { }
}
