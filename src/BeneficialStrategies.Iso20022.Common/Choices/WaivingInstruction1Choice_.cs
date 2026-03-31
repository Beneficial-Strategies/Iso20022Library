// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the waiving instruction.
    /// </summary>
    [KnownType(typeof(WaivingInstruction1Choice.Code))]
    [KnownType(typeof(WaivingInstruction1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(WaivingInstruction1Choice.Code),
        nameof(WaivingInstruction1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(WaivingInstruction1Choice.Proprietary),
        nameof(WaivingInstruction1Choice.Proprietary)
    )]
    [IsoId("_NH7VgRuDEeOqSdXzJ0oydA")]
    [DisplayName("Waiving Instruction 1 Choice")]
    public abstract record WaivingInstruction1Choice_ { }
}
