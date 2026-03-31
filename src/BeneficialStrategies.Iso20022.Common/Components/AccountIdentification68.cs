// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Identification68.
/// </summary>
[IsoId("_kFW6cYVQEe-oeNhl-Tk6YQ")]
[DisplayName("Account Identification68")]
public record AccountIdentification68
{
    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification127Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Block Chain Address Or Wallet.
    /// </summary>
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Corporate Action Event And Balance.
    /// </summary>
    [DisplayName("Corporate Action Event And Balance")]
    [IsoXmlTag("CorpActnEvtAndBal")]
    public ValueList<CorporateActionEventAndBalance26> CorporateActionEventAndBalance { get; init; } =
        [];

    /// <summary>
    /// Safekeeping Account.
    /// </summary>
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public IsoMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat42Choice_? SafekeepingPlace { get; init; }
}
