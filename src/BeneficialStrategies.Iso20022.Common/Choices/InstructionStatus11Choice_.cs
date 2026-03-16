// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying globally to the instruction received.
    /// </summary>
    [KnownType(typeof(InstructionStatus11Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus11Choice.Rejected))]
    [KnownType(typeof(InstructionStatus11Choice.Pending))]
    [JsonDerivedType(
        typeof(InstructionStatus11Choice.ProcessingStatus),
        nameof(InstructionStatus11Choice.ProcessingStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionStatus11Choice.Rejected),
        nameof(InstructionStatus11Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionStatus11Choice.Pending),
        nameof(InstructionStatus11Choice.Pending)
    )]
    [IsoId("_hY-q3RrpEeyhRdHRjakS2w")]
    [DisplayName("Instruction Status 11 Choice")]
    public abstract record InstructionStatus11Choice_ { }
}
