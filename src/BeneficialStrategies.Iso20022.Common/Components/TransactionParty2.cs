// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the parties specific to the individual transaction.
/// </summary>
[IsoId("_P6qyIdp-Ed-ak6NoX_4Aeg_37270857")]
[DisplayName("Transaction Party")]
public record TransactionParty2
{
    /// <summary>
    /// Party that initiated the payment that is reported in the entry.
    /// </summary>
    [IsoId("_P60jENp-Ed-ak6NoX_4Aeg_37271103")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification32? InitiatingParty { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_P60jEdp-Ed-ak6NoX_4Aeg_37271011")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification32? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor.
    /// </summary>
    [IsoId("_P60jEtp-Ed-ak6NoX_4Aeg_37271504")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount16? DebtorAccount { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_P60jE9p-Ed-ak6NoX_4Aeg_37270902")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_P60jFNp-Ed-ak6NoX_4Aeg_37270950")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification32? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry has been posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_P60jFdp-Ed-ak6NoX_4Aeg_37271534")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_P60jFtp-Ed-ak6NoX_4Aeg_37271072")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <summary>
    /// Party that plays an active role in planning and executing the transactions that create or liquidate investments of the investors assets, or that move the investor&apos;s assets from one investment to another. A trading party is a trade instructor, an investment decision-maker, a post trade administrator, or a trader. In the context of treasury, it is the party that negotiates and executes the treasury transaction.
    /// </summary>
    [IsoId("_P60jF9p-Ed-ak6NoX_4Aeg_37271381")]
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public PartyIdentification32? TradingParty { get; init; }

    /// <summary>
    /// Proprietary party related to the underlying transaction.
    /// </summary>
    [IsoId("_P60jGNp-Ed-ak6NoX_4Aeg_37271443")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryParty2? Proprietary { get; init; }
}
