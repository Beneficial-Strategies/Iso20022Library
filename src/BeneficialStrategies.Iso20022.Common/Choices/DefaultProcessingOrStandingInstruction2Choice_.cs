// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Default Processing Or Standing Instruction2Choice.
    /// </summary>
    [KnownType(typeof(DefaultProcessingOrStandingInstruction2Choice.DefaultOptionIndicator))]
    [KnownType(typeof(DefaultProcessingOrStandingInstruction2Choice.StandingInstructionIndicator))]
    [JsonDerivedType(
        typeof(DefaultProcessingOrStandingInstruction2Choice.DefaultOptionIndicator),
        nameof(DefaultProcessingOrStandingInstruction2Choice.DefaultOptionIndicator)
    )]
    [JsonDerivedType(
        typeof(DefaultProcessingOrStandingInstruction2Choice.StandingInstructionIndicator),
        nameof(DefaultProcessingOrStandingInstruction2Choice.StandingInstructionIndicator)
    )]
    [IsoId("_fiXWcYudEe-ia-YMBhg53w")]
    [DisplayName("Default Processing Or Standing Instruction2Choice")]
    public abstract record DefaultProcessingOrStandingInstruction2Choice_ { }
}
