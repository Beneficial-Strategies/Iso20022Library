// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account information and detailed account holdings information report for corporate action events.
/// </summary>
[IsoId("_H-OIkRn1EeyroI8qKgB7Mg")]
[DisplayName("Account Identification")]
public record AccountIdentification58
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_IThqNRn1EeyroI8qKgB7Mg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_lakHIiLPEeyNSNrMl2zWxg")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_IThqPRn1EeyroI8qKgB7Mg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification127Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_IThqRRn1EeyroI8qKgB7Mg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Detailed account holdings information report for a corporate action event.
    /// </summary>
    [IsoId("_IThqTRn1EeyroI8qKgB7Mg")]
    [DisplayName("Corporate Action Event And Balance")]
    [IsoXmlTag("CorpActnEvtAndBal")]
    public ValueList<CorporateActionEventAndBalance22> CorporateActionEventAndBalance { get; init; } =
        [];
}
