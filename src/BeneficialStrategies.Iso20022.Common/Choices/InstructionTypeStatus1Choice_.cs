// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of instruction type status.
    /// </summary>
    [KnownType(typeof(InstructionTypeStatus1Choice.InstructionStatus))]
    [KnownType(typeof(InstructionTypeStatus1Choice.CancellationStatus))]
    [JsonDerivedType(
        typeof(InstructionTypeStatus1Choice.InstructionStatus),
        nameof(InstructionTypeStatus1Choice.InstructionStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionTypeStatus1Choice.CancellationStatus),
        nameof(InstructionTypeStatus1Choice.CancellationStatus)
    )]
    [IsoId("_RCWL19p-Ed-ak6NoX_4Aeg_1310681941")]
    [DisplayName("Instruction Type Status 1 Choice")]
    public abstract record InstructionTypeStatus1Choice_ { }
}
