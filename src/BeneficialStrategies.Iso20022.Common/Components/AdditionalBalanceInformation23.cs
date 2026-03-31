// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sub-balances providing additional information on a specific position but that is not to be accounted for in the building of the aggregate balance, for example, registered.
/// </summary>
[IsoId("_ciApNzi8Eeydid5dcNPKvg")]
[DisplayName("Additional Balance Information")]
public record AdditionalBalanceInformation23
{
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_ciApPTi8Eeydid5dcNPKvg")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SubBalanceType14Choice_ SubBalanceType { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_ciApRTi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity9Choice_ Quantity { get; init; }

    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    [IsoId("_ciApTTi8Eeydid5dcNPKvg")]
    [DisplayName("Sub Balance Additional Details")]
    [IsoXmlTag("SubBalAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? SubBalanceAdditionalDetails { get; init; }
}
