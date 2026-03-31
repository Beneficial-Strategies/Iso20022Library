// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Status12Choice.
    /// </summary>
    [KnownType(typeof(InstructionStatus12Choice.Pending))]
    [KnownType(typeof(InstructionStatus12Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus12Choice.Rejected))]
    [JsonDerivedType(
        typeof(InstructionStatus12Choice.Pending),
        nameof(InstructionStatus12Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionStatus12Choice.ProcessingStatus),
        nameof(InstructionStatus12Choice.ProcessingStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionStatus12Choice.Rejected),
        nameof(InstructionStatus12Choice.Rejected)
    )]
    [IsoId("_Y4Vmi1x1Ee6fgZt44_IqFA")]
    [DisplayName("Instruction Status12Choice")]
    public abstract record InstructionStatus12Choice_ { }
}
