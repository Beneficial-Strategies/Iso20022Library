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
[IsoId("_7yNYRYarEeeUws0ZryHQ2w")]
[DisplayName("Transaction Parties")]
public record TransactionParties4
{
    /// <summary>
    /// Party that initiated the payment that is reported in the entry.
    /// </summary>
    [IsoId("_76i0s4arEeeUws0ZryHQ2w")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public Party35Choice_? InitiatingParty { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_76i0tYarEeeUws0ZryHQ2w")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party35Choice_? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor.
    /// </summary>
    [IsoId("_76i0t4arEeeUws0ZryHQ2w")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_76i0uYarEeeUws0ZryHQ2w")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party35Choice_? UltimateDebtor { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_76i0u4arEeeUws0ZryHQ2w")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party35Choice_? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry has been posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_76i0vYarEeeUws0ZryHQ2w")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_76i0v4arEeeUws0ZryHQ2w")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party35Choice_? UltimateCreditor { get; init; }

    /// <summary>
    /// Party that plays an active role in planning and executing the transactions that create or liquidate investments of the investors assets, or that move the investor&apos;s assets from one investment to another. A trading party is a trade instructor, an investment decision-maker, a post trade administrator, or a trader. In the context of treasury, it is the party that negotiates and executes the treasury transaction.
    /// </summary>
    [IsoId("_76i0wYarEeeUws0ZryHQ2w")]
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public Party35Choice_? TradingParty { get; init; }

    /// <summary>
    /// Proprietary party related to the underlying transaction.
    /// </summary>
    [IsoId("_76i0w4arEeeUws0ZryHQ2w")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryParty4? Proprietary { get; init; }
}
