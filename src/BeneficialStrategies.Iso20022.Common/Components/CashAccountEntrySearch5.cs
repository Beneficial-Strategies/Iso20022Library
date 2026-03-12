// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a cash entry.
/// </summary>
[IsoId("_P4orDZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Cash Account Entry Search")]
public partial record CashAccountEntrySearch5
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_QApXd5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentificationSearchCriteria2Choice_? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the entry amount(s) on which the query is performed.
    /// </summary>
    [IsoId("_QApXeZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Entry Amount")]
    [IsoXmlTag("NtryAmt")]
    public ActiveOrHistoricAmountRange2Choice_? EntryAmount { get; init; } 
    
    /// <summary>
    /// Currency of the entry amount.
    /// </summary>
    [IsoId("_QApXe5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Entry Amount Currency")]
    [IsoXmlTag("NtryAmtCcy")]
    public ActiveOrHistoricCurrencyCode? EntryAmountCurrency { get; init; } 
    
    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_QApXfZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    [IsoId("_QApXf5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Entry Status")]
    [IsoXmlTag("NtrySts")]
    public EntryStatus1Code? EntryStatus { get; init; } 
    
    /// <summary>
    /// Date and time at which an entry is posted to an account on the account servicer&apos;s books.
    /// </summary>
    [IsoId("_QApXgZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Entry Date")]
    [IsoXmlTag("NtryDt")]
    public DateAndDateTimeSearch3Choice_? EntryDate { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_QApXg5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification125? AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.|.
    /// </summary>
    [IsoId("_QApXhZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    
    
    #nullable disable
    
}
