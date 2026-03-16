// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Link8.
/// </summary>
[IsoId("_cCbBYeFSEe6zNorB_Q2tDg")]
[DisplayName("Account Link8")]
public record AccountLink8
{
    /// <summary>
    /// Block Chain Address Or Wallet.
    /// </summary>
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Cash Account.
    /// </summary>
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public required CashAccount38 CashAccount { get; init; }

    /// <summary>
    /// Securities Account.
    /// </summary>
    [DisplayName("Securities Account")]
    [IsoXmlTag("SctiesAcct")]
    public SecuritiesAccount19? SecuritiesAccount { get; init; }

    /// <summary>
    /// Valid From.
    /// </summary>
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public required DateAndDateTime2Choice_ ValidFrom { get; init; }
}
