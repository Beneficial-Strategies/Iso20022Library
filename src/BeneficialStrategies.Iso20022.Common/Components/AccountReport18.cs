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
[IsoId("_edxo8R77EeSxevWRRWxNAg")]
[DisplayName("Account Report")]
public record AccountReport18
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account report.
    /// </summary>
    [IsoId("_euj28x77EeSxevWRRWxNAg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Provides details on the page number of the report.
    /// Usage: The pagination of the report is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_euj29R77EeSxevWRRWxNAg")]
    [DisplayName("Report Pagination")]
    [IsoXmlTag("RptPgntn")]
    public Pagination? ReportPagination { get; init; }

    /// <summary>
    /// Sequential number of the report, as assigned by the account servicer. |Usage: The sequential number is increased incrementally for each report sent electronically.
    /// </summary>
    [IsoId("_euj29x77EeSxevWRRWxNAg")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Legal sequential number of the report, as assigned by the account servicer. It is increased incrementally for each report sent.
    /// </summary>
    [IsoId("_euj2-R77EeSxevWRRWxNAg")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_euj2-x77EeSxevWRRWxNAg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for which the account report is issued.
    /// </summary>
    [IsoId("_euj2_R77EeSxevWRRWxNAg")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; }

    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_euj2_x77EeSxevWRRWxNAg")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("_euj3AR77EeSxevWRRWxNAg")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("_euj3Ax77EeSxevWRRWxNAg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount25 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the account for which the report has been issued.
    /// </summary>
    [IsoId("_euj3BR77EeSxevWRRWxNAg")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount24? RelatedAccount { get; init; }

    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_euj3Bx77EeSxevWRRWxNAg")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public ValueList<AccountInterest3> Interest { get; init; } = [];

    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("_euj3CR77EeSxevWRRWxNAg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance3> Balance { get; init; } = [];

    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("_euj3Cx77EeSxevWRRWxNAg")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions4? TransactionsSummary { get; init; }

    /// <summary>
    /// Specifies an entry in the report.
    /// Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// Usage Rule: In case of a Payments R-transaction the creditor / debtor referenced of the original payment initiation messages is also used for reporting of the R-transaction. The original debtor/creditor in the reporting of R-Transactions is not inverted.
    /// Following elements all defined in the TransactionDetails in RelatedParties or RelatedAgents are impacted by this usage rule:
    /// Creditor, UltimateCreditor, CreditorAccount, CreditorAgent, Debtor, UltimateDebtor, DebtorAccount and DebtorAgent.
    /// </summary>
    [IsoId("_euj3DR77EeSxevWRRWxNAg")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<ReportEntry7> Entry { get; init; } = [];

    /// <summary>
    /// Further details of the account report.
    /// </summary>
    [IsoId("_euj3Dx77EeSxevWRRWxNAg")]
    [DisplayName("Additional Report Information")]
    [IsoXmlTag("AddtlRptInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalReportInformation { get; init; }
}
