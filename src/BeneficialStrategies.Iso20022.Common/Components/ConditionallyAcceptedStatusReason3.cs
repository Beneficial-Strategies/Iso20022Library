// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a conditionally accepted status.
/// </summary>
[IsoId("_2I_zAEHZEeamVPoS58KxXA")]
[DisplayName("Conditionally Accepted Status Reason")]
public record ConditionallyAcceptedStatusReason3
{
    /// <summary>
    /// Reason for the conditionally accepted status expressed as a code.
    /// </summary>
    [IsoId("_84wPkEHZEeamVPoS58KxXA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required ConditionallyAcceptedStatusReason3Choice_ Reason { get; init; }

    /// <summary>
    /// Additional information about the conditionally accepted reason.
    /// </summary>
    [IsoId("_BL11YEHaEeamVPoS58KxXA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
