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
[IsoId("_ZQ1w_bXDEeiTob_PrFFUxA")]
[DisplayName("Account And Balance")]
public record AccountAndBalance41
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_ZijMBbXDEeiTob_PrFFUxA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_ZijMDbXDEeiTob_PrFFUxA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification127Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_ZijMFbXDEeiTob_PrFFUxA")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_ZijMHbXDEeiTob_PrFFUxA")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalanceDetails32? Balance { get; init; }
}
