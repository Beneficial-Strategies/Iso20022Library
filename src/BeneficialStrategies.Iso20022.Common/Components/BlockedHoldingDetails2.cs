// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a blocked holding.
/// </summary>
[IsoId("_H0B8ESGdEeWKAaDJcYGKLw")]
[DisplayName("Blocked Holding Details")]
public record BlockedHoldingDetails2
{
    /// <summary>
    /// Specifies how the blocked account holding is defined.
    /// </summary>
    [IsoId("_IQ5eSSGdEeWKAaDJcYGKLw")]
    [DisplayName("Blocked Holding")]
    [IsoXmlTag("BlckdHldg")]
    public required Holding1Code BlockedHolding { get; init; }

    /// <summary>
    /// When an account is blocked at the level of fund or security, partially, this is the number of units blocked.
    /// </summary>
    [IsoId("_IQ5eSyGdEeWKAaDJcYGKLw")]
    [DisplayName("Partial Holding Units")]
    [IsoXmlTag("PrtlHldgUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? PartialHoldingUnits { get; init; }

    /// <summary>
    /// When an account is blocked at the level of fund or security, this specifies the certificate number of the blocked units.
    /// </summary>
    [IsoId("_IQ5eTSGdEeWKAaDJcYGKLw")]
    [DisplayName("Holding Certificate Number")]
    [IsoXmlTag("HldgCertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? HoldingCertificateNumber { get; init; }
}
