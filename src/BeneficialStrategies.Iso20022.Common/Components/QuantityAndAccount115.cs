// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity And Account115.
/// </summary>
[IsoId("_wJJ27YoiEe-efPejSUAtLw")]
[DisplayName("Quantity And Account115")]
public record QuantityAndAccount115
{
    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

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
    public CashAccountIdentification9Choice_? CashAccount { get; init; }

    /// <summary>
    /// Denomination Choice.
    /// </summary>
    [DisplayName("Denomination Choice")]
    [IsoXmlTag("DnmtnChc")]
    public IsoMax210Text? DenominationChoice { get; init; }

    /// <summary>
    /// Previously Settled Amount.
    /// </summary>
    [DisplayName("Previously Settled Amount")]
    [IsoXmlTag("PrevslySttldAmt")]
    public AmountAndDirection52? PreviouslySettledAmount { get; init; }

    /// <summary>
    /// Previously Settled Quantity.
    /// </summary>
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity33Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity Breakdown.
    /// </summary>
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown63> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Remaining To Be Settled Amount.
    /// </summary>
    [DisplayName("Remaining To Be Settled Amount")]
    [IsoXmlTag("RmngToBeSttldAmt")]
    public AmountAndDirection52? RemainingToBeSettledAmount { get; init; }

    /// <summary>
    /// Remaining To Be Settled Quantity.
    /// </summary>
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity33Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Safekeeping Account.
    /// </summary>
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace5? SafekeepingPlace { get; init; }

    /// <summary>
    /// Settled Quantity.
    /// </summary>
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required Quantity51Choice_ SettledQuantity { get; init; }
}
