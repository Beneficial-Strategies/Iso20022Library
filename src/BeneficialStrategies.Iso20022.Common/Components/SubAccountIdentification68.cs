// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
[IsoId("_ciE6oTi8Eeydid5dcNPKvg")]
[DisplayName("Sub Account Identification")]
public record SubAccountIdentification68
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_ciE6sTi8Eeydid5dcNPKvg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification156? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_ciE6uTi8Eeydid5dcNPKvg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount34? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_ciE6wTi8Eeydid5dcNPKvg")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet9? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_ciE6wzi8Eeydid5dcNPKvg")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities subaccount.
    /// </summary>
    [IsoId("_ciE6yzi8Eeydid5dcNPKvg")]
    [DisplayName("Balance For Sub Account")]
    [IsoXmlTag("BalForSubAcct")]
    public ValueList<AggregateBalanceInformation43> BalanceForSubAccount { get; init; } = [];
}
