// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of instruction type status.
    /// </summary>
    [KnownType(typeof(InstructionTypeStatus4Choice.InstructionStatus))]
    [KnownType(typeof(InstructionTypeStatus4Choice.CancellationStatus))]
    [JsonDerivedType(
        typeof(InstructionTypeStatus4Choice.InstructionStatus),
        nameof(InstructionTypeStatus4Choice.InstructionStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionTypeStatus4Choice.CancellationStatus),
        nameof(InstructionTypeStatus4Choice.CancellationStatus)
    )]
    [IsoId("_ay2uYfNfEeqRfth943bvEA")]
    [DisplayName("Instruction Type Status 4 Choice")]
    public abstract record InstructionTypeStatus4Choice_ { }
}
