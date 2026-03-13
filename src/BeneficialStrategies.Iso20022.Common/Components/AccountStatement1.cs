// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing further details on the account statement.
/// </summary>
[IsoId("_RT7rEdp-Ed-ak6NoX_4Aeg_-1421600546")]
[DisplayName("Account Statement")]
public partial record AccountStatement1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the account report, assigned by the account servicer.
    /// </summary>
    [IsoId("_RT7rEtp-Ed-ak6NoX_4Aeg_-1421600272")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Sequential number of the report, assigned by the account servicer. It is increased incrementally for each report sent electronically.
    /// </summary>
    [IsoId("_RT7rE9p-Ed-ak6NoX_4Aeg_-1421600203")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    
    /// <summary>
    /// Legal sequential number of the report, assigned by the account servicer. It is increased incrementally for each report sent.||Usage: in those scenarios where eg a paper statement is a legal requirement, the paper statement may have a different numbering than the electronic sequential number. Paper statements can for instance only be sent if movement on the account has taken place, whereas electronic statements can be sent eg each day, regardless of whether movements have taken place or not.
    /// </summary>
    [IsoId("_RT7rFNp-Ed-ak6NoX_4Aeg_-1421600143")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; } 
    
    /// <summary>
    /// Date and time at which the report was created.
    /// </summary>
    [IsoId("_RT7rFdp-Ed-ak6NoX_4Aeg_-1421600238")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Range of time between the start date and the end date for which the account statement is issued.
    /// </summary>
    [IsoId("_RT7rFtp-Ed-ak6NoX_4Aeg_-1253221732")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; } 
    
    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_RT7rF9p-Ed-ak6NoX_4Aeg_-1421600101")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_RT7rGNp-Ed-ak6NoX_4Aeg_-1137198392")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount13 Account { get; init; } 
    
    /// <summary>
    /// Identifies the parent account of the reported account.
    /// </summary>
    [IsoId("_RT7rGdp-Ed-ak6NoX_4Aeg_-1137197851")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount7? RelatedAccount { get; init; } 
    
    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_RUE1ANp-Ed-ak6NoX_4Aeg_-1253221269")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public AccountInterest1? Interest { get; init; } 
    
    /// <summary>
    /// Set of elements defining the balance(s).
    /// </summary>
    [IsoId("_RUE1Adp-Ed-ak6NoX_4Aeg_-1137197929")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance2> Balance { get; init; } = [];
    // ID for the above is _RUE1Adp-Ed-ak6NoX_4Aeg_-1137197929
    
    /// <summary>
    /// Set of element providing summary information on entries.
    /// </summary>
    [IsoId("_RUE1Atp-Ed-ak6NoX_4Aeg_-1253221870")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions1? TransactionsSummary { get; init; } 
    
    /// <summary>
    /// Specifies the elements of an entry in the statement.||Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    [IsoId("_RUE1A9p-Ed-ak6NoX_4Aeg_-1137198067")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public StatementEntry1? Entry { get; init; } 
    
    /// <summary>
    /// Further details on the account statement.
    /// </summary>
    [IsoId("_RUE1BNp-Ed-ak6NoX_4Aeg_-1421600048")]
    [DisplayName("Additional Statement Information")]
    [IsoXmlTag("AddtlStmtInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalStatementInformation { get; init; } 
    
    
    #nullable disable
    
}
