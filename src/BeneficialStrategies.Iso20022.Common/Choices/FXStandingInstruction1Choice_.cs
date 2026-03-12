// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the FX Standing Instruction information.
    /// </summary>
    [KnownType(typeof(FXStandingInstruction1Choice.Indicator))]
    [KnownType(typeof(FXStandingInstruction1Choice.Proprietary))]
    [JsonDerivedType(typeof(FXStandingInstruction1Choice.Indicator),nameof(FXStandingInstruction1Choice.Indicator))]
    [JsonDerivedType(typeof(FXStandingInstruction1Choice.Proprietary),nameof(FXStandingInstruction1Choice.Proprietary))]
    [IsoId("_QuFMBdp-Ed-ak6NoX_4Aeg_-1270541396")]
    [DisplayName("FX Standing Instruction 1 Choice")]
    public abstract partial record FXStandingInstruction1Choice_
    {
    }
}
