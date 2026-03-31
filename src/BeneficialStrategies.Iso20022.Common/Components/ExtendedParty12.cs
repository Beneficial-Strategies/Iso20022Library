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
[IsoId("_IHvGcUzQEea8fovz_9xSTQ")]
[DisplayName("Extended Party")]
public record ExtendedParty12
{
    /// <summary>
    /// Other type of party&apos;s role.
    /// </summary>
    [IsoId("_Ihlw4UzQEea8fovz_9xSTQ")]
    [DisplayName("Extended Party Role")]
    [IsoXmlTag("XtndedPtyRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedPartyRole { get; init; }

    /// <summary>
    /// Detailed ownership information about a party.
    /// </summary>
    [IsoId("_Ihlw40zQEea8fovz_9xSTQ")]
    [DisplayName("Other Party Details")]
    [IsoXmlTag("OthrPtyDtls")]
    public required InvestmentAccountOwnershipInformation15 OtherPartyDetails { get; init; }
}
