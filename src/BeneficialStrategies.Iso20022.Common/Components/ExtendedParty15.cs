// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other type of party.
/// </summary>
[IsoId("_n3w6V5Q_EemqYPWMBuVawg")]
[DisplayName("Extended Party")]
public record ExtendedParty15
{
    /// <summary>
    /// Other type of party&apos;s role.
    /// </summary>
    [IsoId("_oK88AZQ_EemqYPWMBuVawg")]
    [DisplayName("Extended Party Role")]
    [IsoXmlTag("XtndedPtyRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedPartyRole { get; init; }

    /// <summary>
    /// Detailed ownership information about a party.
    /// </summary>
    [IsoId("_oK88A5Q_EemqYPWMBuVawg")]
    [DisplayName("Other Party Details")]
    [IsoXmlTag("OthrPtyDtls")]
    public required InvestmentAccountOwnershipInformation17 OtherPartyDetails { get; init; }
}
