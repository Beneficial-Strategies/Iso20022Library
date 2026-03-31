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
[IsoId("_2NxawTWhEe2OzdGcZrUAEQ")]
[DisplayName("Rejection Reason")]
public record RejectionReason69
{
    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    [IsoId("_2mW54zWhEe2OzdGcZrUAEQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MessageRejectedReason2Code Reason { get; init; }

    /// <summary>
    /// Additional information about the rejection reason.
    /// </summary>
    [IsoId("_2mW55TWhEe2OzdGcZrUAEQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Identification of the invalid or unrecognised reference.
    /// </summary>
    [IsoId("_2mW55zWhEe2OzdGcZrUAEQ")]
    [DisplayName("Linked Message")]
    [IsoXmlTag("LkdMsg")]
    public LinkedMessage6Choice_? LinkedMessage { get; init; }
}
