// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction to be cancelled.
/// </summary>
[IsoId("_32G-IK-aEemJ1NnLPsTFaw")]
[DisplayName("Cancel Instruction")]
public record CancelInstruction1
{
    /// <summary>
    /// Identification of the individual instruction previously sent.
    /// </summary>
    [IsoId("_QVAV8K-bEemJ1NnLPsTFaw")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionIdentification { get; init; }

    /// <summary>
    /// Account and instructed positions to which the meeting instruction cancellation request applies.
    /// </summary>
    [IsoId("_TGfmIa-bEemJ1NnLPsTFaw")]
    [DisplayName("Instructed Position")]
    [IsoXmlTag("InstdPos")]
    public SafekeepingAccount9? InstructedPosition { get; init; }
}
