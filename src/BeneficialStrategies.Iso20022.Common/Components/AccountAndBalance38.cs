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
[IsoId("_cjtBI5KQEeWHWpTQn1FFVg")]
[DisplayName("Account And Balance")]
public record AccountAndBalance38
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_cjtBJ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_cjtBL5KQEeWHWpTQn1FFVg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification103Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_cjtBN5KQEeWHWpTQn1FFVg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat11Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_cjtBP5KQEeWHWpTQn1FFVg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required CorporateActionBalanceDetails35 Balance { get; init; }
}
