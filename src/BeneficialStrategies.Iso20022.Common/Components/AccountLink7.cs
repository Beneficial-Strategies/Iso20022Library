// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Link7.
/// </summary>
[IsoId("_x_qKMeFREe6zNorB_Q2tDg")]
[DisplayName("Account Link7")]
public record AccountLink7
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
    /// Cash Settlement Indicator.
    /// </summary>
    [DisplayName("Cash Settlement Indicator")]
    [IsoXmlTag("CshSttlmInd")]
    public required IsoYesNoIndicator CashSettlementIndicator { get; init; }

    /// <summary>
    /// Collateralisation Indicator.
    /// </summary>
    [DisplayName("Collateralisation Indicator")]
    [IsoXmlTag("CollstnInd")]
    public required IsoYesNoIndicator CollateralisationIndicator { get; init; }

    /// <summary>
    /// Default Indicator.
    /// </summary>
    [DisplayName("Default Indicator")]
    [IsoXmlTag("DfltInd")]
    public required IsoYesNoIndicator DefaultIndicator { get; init; }

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

    /// <summary>
    /// Valid To.
    /// </summary>
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    public DateAndDateTime2Choice_? ValidTo { get; init; }
}
