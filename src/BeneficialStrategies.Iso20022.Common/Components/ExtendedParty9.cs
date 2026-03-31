// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account information.
/// </summary>
[IsoId("_I97rcSCBEeWhHbfCMWc1cw")]
[DisplayName("Extended Party")]
public record ExtendedParty9
{
    /// <summary>
    /// Other type of party&apos;s role.
    /// </summary>
    [IsoId("_JZciwSCBEeWhHbfCMWc1cw")]
    [DisplayName("Extended Party Role")]
    [IsoXmlTag("XtndedPtyRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedPartyRole { get; init; }

    /// <summary>
    /// Detailed ownership information about a party.
    /// </summary>
    [IsoId("_JZciwyCBEeWhHbfCMWc1cw")]
    [DisplayName("Other Party Details")]
    [IsoXmlTag("OthrPtyDtls")]
    public required InvestmentAccountOwnershipInformation12 OtherPartyDetails { get; init; }
}
