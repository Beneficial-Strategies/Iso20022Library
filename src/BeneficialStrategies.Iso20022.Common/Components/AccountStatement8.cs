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
[IsoId("_um8A866QEeexrtTFgmVD3Q")]
[DisplayName("Account Statement")]
public record AccountStatement8
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account statement.
    /// </summary>
    [IsoId("_uvbOc66QEeexrtTFgmVD3Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Provides details on the page number of the statement.
    /// Usage: The pagination of the statement is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_uvbOda6QEeexrtTFgmVD3Q")]
    [DisplayName("Statement Pagination")]
    [IsoXmlTag("StmtPgntn")]
    public Pagination1? StatementPagination { get; init; }

    /// <summary>
    /// Sequential number of the statement, as assigned by the account servicer.|Usage: The sequential number is increased incrementally for each statement sent electronically.
    /// </summary>
    [IsoId("_uvbOd66QEeexrtTFgmVD3Q")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Specifies the range of identification sequence numbers, as provided in the request.
    /// </summary>
    [IsoId("_uvbOea6QEeexrtTFgmVD3Q")]
    [DisplayName("Reporting Sequence")]
    [IsoXmlTag("RptgSeq")]
    public SequenceRange1Choice_? ReportingSequence { get; init; }

    /// <summary>
    /// Legal sequential number of the statement, as assigned by the account servicer. It is increased incrementally for each statement sent.||Usage: Where a paper statement is a legal requirement, it may have a number different from the electronic sequential number. Paper statements could for instance only be sent if movement on the account has taken place, whereas electronic statements could be sent at the end of each reporting period, regardless of whether movements have taken place or not.
    /// </summary>
    [IsoId("_uvbOe66QEeexrtTFgmVD3Q")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the statement was created.
    /// </summary>
    [IsoId("_uvbOfa6QEeexrtTFgmVD3Q")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for which the account statement is issued.
    /// </summary>
    [IsoId("_uvbOf66QEeexrtTFgmVD3Q")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriod1? FromToDate { get; init; }

    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_uvbOga6QEeexrtTFgmVD3Q")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("_uvbOg66QEeexrtTFgmVD3Q")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("_uvbOha6QEeexrtTFgmVD3Q")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount36 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the account for which the statement has been issued.
    /// </summary>
    [IsoId("_uvbOh66QEeexrtTFgmVD3Q")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount24? RelatedAccount { get; init; }

    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_uvbOia6QEeexrtTFgmVD3Q")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public AccountInterest4? Interest { get; init; }

    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("_uvbOi66QEeexrtTFgmVD3Q")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance8> Balance { get; init; } = [];

    // ID for the above is _uvbOi66QEeexrtTFgmVD3Q

    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("_uvbOja6QEeexrtTFgmVD3Q")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions6? TransactionsSummary { get; init; }

    /// <summary>
    /// Specify an entry in the statement.
    /// Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// Usage Rule: In case of a Payments R-transaction the creditor / debtor referenced of the original payment initiation messages is also used for reporting of the R-transaction. The original debtor/creditor in the reporting of R-Transactions is not inverted.
    /// Following elements all defined in the TransactionDetails in RelatedParties or RelatedAgents are impacted by this usage rule:
    /// Creditor, UltimateCreditor, CreditorAccount, CreditorAgent, Debtor, UltimateDebtor, DebtorAccount and DebtorAgent.
    /// </summary>
    [IsoId("_uvbOj66QEeexrtTFgmVD3Q")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ReportEntry9? Entry { get; init; }

    /// <summary>
    /// Further details of the account statement.
    /// </summary>
    [IsoId("_uvbOka6QEeexrtTFgmVD3Q")]
    [DisplayName("Additional Statement Information")]
    [IsoXmlTag("AddtlStmtInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalStatementInformation { get; init; }
}
