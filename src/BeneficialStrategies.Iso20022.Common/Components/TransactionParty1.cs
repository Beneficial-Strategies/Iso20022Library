// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_PyUuZNp-Ed-ak6NoX_4Aeg_482028635")]
[DisplayName("Transaction Party")]
public partial record TransactionParty1
{
    #nullable enable
    
    /// <summary>
    /// Party initiating the payment to an agent. In the payment context, this can either be the debtor (in a credit transfer), the creditor (in a direct debit), or a party that initiates the payment on behalf of the debtor or creditor. In the context of treasury, the party that instructs the trading party to execute a treasury deal on its behalf.
    /// </summary>
    [IsoId("_PyUuZdp-Ed-ak6NoX_4Aeg_482951151")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification8? InitiatingParty { get; init; } 
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_PyUuZtp-Ed-ak6NoX_4Aeg_1473373314")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification8? Debtor { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor.
    /// </summary>
    [IsoId("_PyUuZ9p-Ed-ak6NoX_4Aeg_1473373384")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount7? DebtorAccount { get; init; } 
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_PyUuaNp-Ed-ak6NoX_4Aeg_482951211")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification8? UltimateDebtor { get; init; } 
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_PyefYNp-Ed-ak6NoX_4Aeg_1788291282")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification8? Creditor { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor of the payment transaction.
    /// </summary>
    [IsoId("_PyefYdp-Ed-ak6NoX_4Aeg_1788291222")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount7? CreditorAccount { get; init; } 
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_PyefYtp-Ed-ak6NoX_4Aeg_482949272")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification8? UltimateCreditor { get; init; } 
    
    /// <summary>
    /// Party that plays an active role in planning and executing the transactions that create or liquidate investments of the investors assets, or that move the investor&apos;s assets from one investment to another. A trading party is a trade instructor, an investment decision-maker, a post trade administrator, or a trader. In the context of treasury, it is the party that negotiates and executes the treasury transaction.
    /// </summary>
    [IsoId("_PyefY9p-Ed-ak6NoX_4Aeg_1518216858")]
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public PartyIdentification8? TradingParty { get; init; } 
    
    /// <summary>
    /// Provides proprietary party information.
    /// </summary>
    [IsoId("_PyefZNp-Ed-ak6NoX_4Aeg_2019612158")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryParty1? Proprietary { get; init; } 
    
    
    #nullable disable
    
}
