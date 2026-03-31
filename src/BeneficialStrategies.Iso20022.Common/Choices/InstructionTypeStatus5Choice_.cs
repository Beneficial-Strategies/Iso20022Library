// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of instruction type status.
    /// </summary>
    [KnownType(typeof(InstructionTypeStatus5Choice.InstructionStatus))]
    [KnownType(typeof(InstructionTypeStatus5Choice.CancellationStatus))]
    [JsonDerivedType(
        typeof(InstructionTypeStatus5Choice.InstructionStatus),
        nameof(InstructionTypeStatus5Choice.InstructionStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionTypeStatus5Choice.CancellationStatus),
        nameof(InstructionTypeStatus5Choice.CancellationStatus)
    )]
    [IsoId("_gvHOcRrpEeyhRdHRjakS2w")]
    [DisplayName("Instruction Type Status 5 Choice")]
    public abstract record InstructionTypeStatus5Choice_ { }
}
