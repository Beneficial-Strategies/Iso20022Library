// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason to reject the message.
/// </summary>
[IsoId("_wB6BMQgJEeSFYfyUKDXKaw")]
[DisplayName("Rejection Reason")]
public record RejectionReason23
{
    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    [IsoId("_wduahwgJEeSFYfyUKDXKaw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MessageRejectedReason1Code Reason { get; init; }

    /// <summary>
    /// Additional information about the rejection reason.
    /// </summary>
    [IsoId("_wduaiQgJEeSFYfyUKDXKaw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Identification of the invalid or unrecognised reference.
    /// </summary>
    [IsoId("_5VTfMAgJEeSFYfyUKDXKaw")]
    [DisplayName("Linked Message")]
    [IsoXmlTag("LkdMsg")]
    public LinkedMessage1Choice_? LinkedMessage { get; init; }
}
