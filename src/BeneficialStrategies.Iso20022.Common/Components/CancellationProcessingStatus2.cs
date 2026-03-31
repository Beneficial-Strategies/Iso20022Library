// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status advising on the processing of the cancellation request.
/// </summary>
[IsoId("_VSSIMbLQEemDyeh7tbvg1w")]
[DisplayName("Cancellation Processing Status")]
public record CancellationProcessingStatus2
{
    /// <summary>
    /// Status code.
    /// </summary>
    [IsoId("_VqsBIbLQEemDyeh7tbvg1w")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required CancellationStatus6Code Status { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_VqsBI7LQEemDyeh7tbvg1w")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
