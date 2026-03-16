// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the account statement.
/// </summary>
[IsoId("_tqvhIlkyEeGeoaLUQk__nA_-1076556870")]
[DisplayName("Account Statement")]
public record AccountStatement3
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account statement.
    /// </summary>
    [IsoId("_tqvhI1kyEeGeoaLUQk__nA_-2073629223")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Provides details on the page number of the statement.
    /// Usage: The pagination of the statement is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_tqvhJFkyEeGeoaLUQk__nA_95626296")]
    [DisplayName("Statement Pagination")]
    [IsoXmlTag("StmtPgntn")]
    public Pagination? StatementPagination { get; init; }

    /// <summary>
    /// Sequential number of the statement, as assigned by the account servicer.|Usage: The sequential number is increased incrementally for each statement sent electronically.
    /// </summary>
    [IsoId("_tq5SIFkyEeGeoaLUQk__nA_-112375598")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Legal sequential number of the statement, as assigned by the account servicer. It is increased incrementally for each statement sent.||Usage: Where a paper statement is a legal requirement, it may have a number different from the electronic sequential number. Paper statements could for instance only be sent if movement on the account has taken place, whereas electronic statements could be sent at the end of each reporting period, regardless of whether movements have taken place or not.
    /// </summary>
    [IsoId("_tq5SIVkyEeGeoaLUQk__nA_-1992681238")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_tq5SIlkyEeGeoaLUQk__nA_1094614502")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for which the account statement is issued.
    /// </summary>
    [IsoId("_tq5SI1kyEeGeoaLUQk__nA_-1077648876")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; }

    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_tq5SJFkyEeGeoaLUQk__nA_-2122332456")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("_trCcEFkyEeGeoaLUQk__nA_371462")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("_trCcEVkyEeGeoaLUQk__nA_581428124")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount25 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the account for which the statement has been issued.
    /// </summary>
    [IsoId("_trCcElkyEeGeoaLUQk__nA_-386083520")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount24? RelatedAccount { get; init; }

    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_trCcE1kyEeGeoaLUQk__nA_374681633")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public AccountInterest2? Interest { get; init; }

    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("_trCcFFkyEeGeoaLUQk__nA_1709532480")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance3> Balance { get; init; } = [];

    // ID for the above is _trCcFFkyEeGeoaLUQk__nA_1709532480

    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("_trMNEFkyEeGeoaLUQk__nA_-1635275225")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions2? TransactionsSummary { get; init; }

    /// <summary>
    /// Set of elements used to specify an entry in the statement.|Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    [IsoId("_trMNEVkyEeGeoaLUQk__nA_-217685922")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ReportEntry3? Entry { get; init; }

    /// <summary>
    /// Further details of the account statement.
    /// </summary>
    [IsoId("_trMNElkyEeGeoaLUQk__nA_1765360007")]
    [DisplayName("Additional Statement Information")]
    [IsoXmlTag("AddtlStmtInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalStatementInformation { get; init; }
}
