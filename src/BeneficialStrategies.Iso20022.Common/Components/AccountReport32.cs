// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the account report.
/// </summary>
[IsoId("_mxRFwQ5rEe2xs7BqO31w6w")]
[DisplayName("Account Report")]
public record AccountReport32
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account report.
    /// </summary>
    [IsoId("_nOWDUQ5rEe2xs7BqO31w6w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Provides details on the page number of the report.
    /// Usage: The pagination of the report is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_nOWDUw5rEe2xs7BqO31w6w")]
    [DisplayName("Report Pagination")]
    [IsoXmlTag("RptPgntn")]
    public Pagination1? ReportPagination { get; init; }

    /// <summary>
    /// Sequential number of the report, as assigned by the account servicer. |Usage: The sequential number is increased incrementally for each report sent electronically.
    /// </summary>
    [IsoId("_nOWDVQ5rEe2xs7BqO31w6w")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Specifies the range of identification sequence numbers, as provided in the request.
    /// </summary>
    [IsoId("_nOWDVw5rEe2xs7BqO31w6w")]
    [DisplayName("Reporting Sequence")]
    [IsoXmlTag("RptgSeq")]
    public SequenceRange1Choice_? ReportingSequence { get; init; }

    /// <summary>
    /// Legal sequential number of the report, as assigned by the account servicer. It is increased incrementally for each report sent.
    /// </summary>
    [IsoId("_nOWDWQ5rEe2xs7BqO31w6w")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the report was created.
    /// </summary>
    [IsoId("_nOWDWw5rEe2xs7BqO31w6w")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for which the account report is issued.
    /// </summary>
    [IsoId("_nOWDXQ5rEe2xs7BqO31w6w")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriod1? FromToDate { get; init; }

    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_nOWDXw5rEe2xs7BqO31w6w")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("_nOWDYQ5rEe2xs7BqO31w6w")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("_nOWDYw5rEe2xs7BqO31w6w")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount41 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the account for which the report has been issued.
    /// </summary>
    [IsoId("_nOWDZQ5rEe2xs7BqO31w6w")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_nOWDZw5rEe2xs7BqO31w6w")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public ValueList<AccountInterest4> Interest { get; init; } = [];

    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("_nOWDaQ5rEe2xs7BqO31w6w")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance8> Balance { get; init; } = [];

    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("_nOWDaw5rEe2xs7BqO31w6w")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions6? TransactionsSummary { get; init; }

    /// <summary>
    /// Specifies an entry in the report.
    /// Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// Usage Rule: In case of a Payments R-transaction the creditor / debtor referenced of the original payment initiation messages is also used for reporting of the R-transaction. The original debtor/creditor in the reporting of R-Transactions is not inverted.
    /// Following elements all defined in the TransactionDetails in RelatedParties or RelatedAgents are impacted by this usage rule:
    /// Creditor, UltimateCreditor, CreditorAccount, CreditorAgent, Debtor, UltimateDebtor, DebtorAccount and DebtorAgent.
    /// </summary>
    [IsoId("_nOWDbQ5rEe2xs7BqO31w6w")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<ReportEntry13> Entry { get; init; } = [];

    /// <summary>
    /// Further details of the account report.
    /// </summary>
    [IsoId("_nOWDbw5rEe2xs7BqO31w6w")]
    [DisplayName("Additional Report Information")]
    [IsoXmlTag("AddtlRptInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalReportInformation { get; init; }
}
