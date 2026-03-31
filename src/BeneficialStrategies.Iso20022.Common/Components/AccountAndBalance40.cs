// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account and balance information.
/// </summary>
[IsoId("_c3zCxZKQEeWHWpTQn1FFVg")]
[DisplayName("Account And Balance")]
public record AccountAndBalance40
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_c3zCx5KQEeWHWpTQn1FFVg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    [IsoId("_c3zo45KQEeWHWpTQn1FFVg")]
    [DisplayName("Confirmed Balance")]
    [IsoXmlTag("ConfdBal")]
    public required BalanceFormat7Choice_ ConfirmedBalance { get; init; }
}
