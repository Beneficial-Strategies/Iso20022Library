// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the account statement.
/// </summary>
[IsoId("_9cVDkSGxEeKjd4jizyIDGA")]
[DisplayName("Account Statement")]
public partial record AccountStatement4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account statement.
    /// </summary>
    [IsoId("_9xolNSGxEeKjd4jizyIDGA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Provides details on the page number of the statement.
    /// Usage: The pagination of the statement is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_9xolOSGxEeKjd4jizyIDGA")]
    [DisplayName("Statement Pagination")]
    [IsoXmlTag("StmtPgntn")]
    public Pagination? StatementPagination { get; init; } 
    
    /// <summary>
    /// Sequential number of the statement, as assigned by the account servicer.|Usage: The sequential number is increased incrementally for each statement sent electronically.
    /// </summary>
    [IsoId("_9xolQSGxEeKjd4jizyIDGA")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    
    /// <summary>
    /// Legal sequential number of the statement, as assigned by the account servicer. It is increased incrementally for each statement sent.||Usage: Where a paper statement is a legal requirement, it may have a number different from the electronic sequential number. Paper statements could for instance only be sent if movement on the account has taken place, whereas electronic statements could be sent at the end of each reporting period, regardless of whether movements have taken place or not.
    /// </summary>
    [IsoId("_9xolRSGxEeKjd4jizyIDGA")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_9xolSSGxEeKjd4jizyIDGA")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Range of time between a start date and an end date for which the account statement is issued.
    /// </summary>
    [IsoId("_9xolTSGxEeKjd4jizyIDGA")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_9xolUSGxEeKjd4jizyIDGA")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("_9xolVSGxEeKjd4jizyIDGA")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("_9xolWSGxEeKjd4jizyIDGA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount25 Account { get; init; } 
    
    /// <summary>
    /// Identifies the parent account of the account for which the statement has been issued.
    /// </summary>
    [IsoId("_9xolXSGxEeKjd4jizyIDGA")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount24? RelatedAccount { get; init; } 
    
    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_9xolYSGxEeKjd4jizyIDGA")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public AccountInterest2? Interest { get; init; } 
    
    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("_9xolZSGxEeKjd4jizyIDGA")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance3> Balance { get; init; } = [];
    // ID for the above is _9xolZSGxEeKjd4jizyIDGA
    
    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("_9xolaSGxEeKjd4jizyIDGA")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions4? TransactionsSummary { get; init; } 
    
    /// <summary>
    /// Set of elements used to specify an entry in the statement.|Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    [IsoId("_9xolbSGxEeKjd4jizyIDGA")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ReportEntry4? Entry { get; init; } 
    
    /// <summary>
    /// Further details of the account statement.
    /// </summary>
    [IsoId("_9xolcSGxEeKjd4jizyIDGA")]
    [DisplayName("Additional Statement Information")]
    [IsoXmlTag("AddtlStmtInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalStatementInformation { get; init; } 
    
    
    #nullable disable
    
}
