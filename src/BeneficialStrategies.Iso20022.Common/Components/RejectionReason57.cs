// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction or request has a rejected status.
/// </summary>
[IsoId("_PDlpMStWEeyhipY4f42fZQ")]
[DisplayName("Rejection Reason")]
public record RejectionReason57
{
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    [IsoId("_PcLIQStWEeyhipY4f42fZQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RejectionReason42Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_PcLISStWEeyhipY4f42fZQ")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
