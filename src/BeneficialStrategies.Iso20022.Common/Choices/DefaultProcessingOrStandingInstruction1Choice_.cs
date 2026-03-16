// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between default processing or standing instruction.
    /// </summary>
    [KnownType(typeof(DefaultProcessingOrStandingInstruction1Choice.DefaultOptionIndicator))]
    [KnownType(typeof(DefaultProcessingOrStandingInstruction1Choice.StandingInstructionIndicator))]
    [JsonDerivedType(
        typeof(DefaultProcessingOrStandingInstruction1Choice.DefaultOptionIndicator),
        nameof(DefaultProcessingOrStandingInstruction1Choice.DefaultOptionIndicator)
    )]
    [JsonDerivedType(
        typeof(DefaultProcessingOrStandingInstruction1Choice.StandingInstructionIndicator),
        nameof(DefaultProcessingOrStandingInstruction1Choice.StandingInstructionIndicator)
    )]
    [IsoId("_Q0VlAtp-Ed-ak6NoX_4Aeg_-931844170")]
    [DisplayName("Default Processing Or Standing Instruction 1 Choice")]
    public abstract record DefaultProcessingOrStandingInstruction1Choice_ { }
}
