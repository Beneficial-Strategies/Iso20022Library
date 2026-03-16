// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status advising on the processing of the instruction.
/// </summary>
[IsoId("_9DhyV6-nEemJ1NnLPsTFaw")]
[DisplayName("Instruction Processing Status")]
public record InstructionProcessingStatus4
{
    /// <summary>
    /// Status code.
    /// </summary>
    [IsoId("_9YNB0a-nEemJ1NnLPsTFaw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status8Code Status { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_9YNB06-nEemJ1NnLPsTFaw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
