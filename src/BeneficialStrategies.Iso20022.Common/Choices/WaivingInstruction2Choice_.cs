// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the waiving instruction.
    /// </summary>
    [KnownType(typeof(WaivingInstruction2Choice.Code))]
    [KnownType(typeof(WaivingInstruction2Choice.Proprietary))]
    [JsonDerivedType(typeof(WaivingInstruction2Choice.Code),nameof(WaivingInstruction2Choice.Code))]
    [JsonDerivedType(typeof(WaivingInstruction2Choice.Proprietary),nameof(WaivingInstruction2Choice.Proprietary))]
    [IsoId("_Ox8_UViPEeaMNZxYNthMeA")]
    [DisplayName("Waiving Instruction 2 Choice")]
    public abstract partial record WaivingInstruction2Choice_
    {
    }
}
