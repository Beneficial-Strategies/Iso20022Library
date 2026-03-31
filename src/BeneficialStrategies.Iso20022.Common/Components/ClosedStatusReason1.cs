// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a closed status.
/// </summary>
[IsoId("_d6JVwUzDEeafiMTDrtSnyw")]
[DisplayName("Closed Status Reason")]
public record ClosedStatusReason1
{
    /// <summary>
    /// Reason for the closed account status.
    /// </summary>
    [IsoId("_eUB1YUzDEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ClosedStatusReason2Choice_ Code { get; init; }

    /// <summary>
    /// Additional information about the reason for the closed account status.
    /// </summary>
    [IsoId("_eUB1Y0zDEeafiMTDrtSnyw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
