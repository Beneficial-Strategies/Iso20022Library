// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the underlying rejection reason for the status of an object.
/// </summary>
[IsoId("_d7-FdTt5EeW638lNyHKv7A")]
[DisplayName("Rejection Reason")]
public record RejectionReason27
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected status.
    /// </summary>
    [IsoId("_ecZ5ATt5EeW638lNyHKv7A")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RejectionReason25Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_ecZ5Azt5EeW638lNyHKv7A")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
