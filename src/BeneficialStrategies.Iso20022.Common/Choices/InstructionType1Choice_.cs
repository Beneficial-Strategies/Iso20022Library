// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Type of instruction.
    /// </summary>
    [KnownType(typeof(InstructionType1Choice.InstructionIdentification))]
    [KnownType(typeof(InstructionType1Choice.InstructionCancellationIdentification))]
    [JsonDerivedType(typeof(InstructionType1Choice.InstructionIdentification),nameof(InstructionType1Choice.InstructionIdentification))]
    [JsonDerivedType(typeof(InstructionType1Choice.InstructionCancellationIdentification),nameof(InstructionType1Choice.InstructionCancellationIdentification))]
    [IsoId("_RCWL1Np-Ed-ak6NoX_4Aeg_869239445")]
    [DisplayName("Instruction Type 1 Choice")]
    public abstract partial record InstructionType1Choice_
    {
    }
}
