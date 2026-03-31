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
[IsoId("_YXNPXF99Ee262vCSVgjImg")]
[DisplayName("Account And Balance")]
public record AccountAndBalance56
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_YXNPal99Ee262vCSVgjImg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_YXNPcl99Ee262vCSVgjImg")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_YXNPdF99Ee262vCSVgjImg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification136Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_YXNPfF99Ee262vCSVgjImg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat32Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_YXNPhF99Ee262vCSVgjImg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalanceDetails46? Balance { get; init; }
}
