// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the FX Standing Instruction information.
    /// </summary>
    [KnownType(typeof(FXStandingInstruction3Choice.Indicator))]
    [KnownType(typeof(FXStandingInstruction3Choice.Proprietary))]
    [JsonDerivedType(typeof(FXStandingInstruction3Choice.Indicator),nameof(FXStandingInstruction3Choice.Indicator))]
    [JsonDerivedType(typeof(FXStandingInstruction3Choice.Proprietary),nameof(FXStandingInstruction3Choice.Proprietary))]
    [IsoId("_Aamt1NokEeC60axPepSq7g_1602416385")]
    [DisplayName("FX Standing Instruction 3 Choice")]
    public abstract partial record FXStandingInstruction3Choice_
    {
    }
}
