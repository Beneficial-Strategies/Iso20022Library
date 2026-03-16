// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the parties specific to the individual transaction.
/// </summary>
[IsoId("__NrwMW48EeiU9cctagi5ow")]
[DisplayName("Transaction Parties")]
public record TransactionParties6
{
    /// <summary>
    /// Party that initiated the payment that is reported in the entry.
    /// </summary>
    [IsoId("__Xhoo248EeiU9cctagi5ow")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public Party40Choice_? InitiatingParty { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("__XhopW48EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor.
    /// </summary>
    [IsoId("__Xhop248EeiU9cctagi5ow")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("__XhoqW48EeiU9cctagi5ow")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("__Xhoq248EeiU9cctagi5ow")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party40Choice_? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry has been posted as a result of the payment transaction.
    /// </summary>
    [IsoId("__XhorW48EeiU9cctagi5ow")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("__Xhor248EeiU9cctagi5ow")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }

    /// <summary>
    /// Party that plays an active role in planning and executing the transactions that create or liquidate investments of the investors assets, or that move the investor&apos;s assets from one investment to another. A trading party is a trade instructor, an investment decision-maker, a post trade administrator, or a trader. In the context of treasury, it is the party that negotiates and executes the treasury transaction.
    /// </summary>
    [IsoId("__XhosW48EeiU9cctagi5ow")]
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public Party40Choice_? TradingParty { get; init; }

    /// <summary>
    /// Proprietary party related to the underlying transaction.
    /// </summary>
    [IsoId("__Xhos248EeiU9cctagi5ow")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<ProprietaryParty5> Proprietary { get; init; } = [];
}
