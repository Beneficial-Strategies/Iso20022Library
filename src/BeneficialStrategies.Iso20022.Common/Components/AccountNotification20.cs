// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the account notification.
/// </summary>
[IsoId("_-zo_AStxEeysar7zFstVmw")]
[DisplayName("Account Notification")]
public record AccountNotification20
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account notification.
    /// </summary>
    [IsoId("__J_pgStxEeysar7zFstVmw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Provides details on the page number of the notification.
    /// Usage: The pagination of the notification is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("__J_pgytxEeysar7zFstVmw")]
    [DisplayName("Notification Pagination")]
    [IsoXmlTag("NtfctnPgntn")]
    public Pagination1? NotificationPagination { get; init; }

    /// <summary>
    /// Sequential number of the notification, as assigned by the account servicer. |Usage: The sequential number is increased incrementally for each notification sent electronically.
    /// </summary>
    [IsoId("__J_phStxEeysar7zFstVmw")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Specifies the range of identification sequence numbers, as provided in the request.
    /// </summary>
    [IsoId("__J_phytxEeysar7zFstVmw")]
    [DisplayName("Reporting Sequence")]
    [IsoXmlTag("RptgSeq")]
    public SequenceRange1Choice_? ReportingSequence { get; init; }

    /// <summary>
    /// Legal sequential number of the notification, as assigned by the account servicer. It is increased incrementally for each notification sent.
    /// </summary>
    [IsoId("__J_piStxEeysar7zFstVmw")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the notification was created.
    /// </summary>
    [IsoId("__J_piytxEeysar7zFstVmw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for which the account notification is issued.
    /// </summary>
    [IsoId("__J_pjStxEeysar7zFstVmw")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriod1? FromToDate { get; init; }

    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("__J_pjytxEeysar7zFstVmw")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("__J_pkStxEeysar7zFstVmw")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("__J_pkytxEeysar7zFstVmw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount41 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the account for which the notification has been issued.
    /// </summary>
    [IsoId("__J_plStxEeysar7zFstVmw")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("__J_plytxEeysar7zFstVmw")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public AccountInterest4? Interest { get; init; }

    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("__J_pmStxEeysar7zFstVmw")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions6? TransactionsSummary { get; init; }

    /// <summary>
    /// Specifies an entry in the debit credit notification.
    /// Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// Usage Rule: In case of a Payments R-transaction the creditor / debtor referenced of the original payment initiation messages is also used for reporting of the R-transaction. The original debtor/creditor in the reporting of R-Transactions is not inverted.
    /// Following elements all defined in the TransactionDetails in RelatedParties or RelatedAgents are impacted by this usage rule:
    /// Creditor, UltimateCreditor, CreditorAccount, CreditorAgent, Debtor, UltimateDebtor, DebtorAccount and DebtorAgent.
    /// </summary>
    [IsoId("__J_pmytxEeysar7zFstVmw")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ReportEntry12? Entry { get; init; }

    /// <summary>
    /// Further details of the account notification.
    /// </summary>
    [IsoId("__J_pnStxEeysar7zFstVmw")]
    [DisplayName("Additional Notification Information")]
    [IsoXmlTag("AddtlNtfctnInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalNotificationInformation { get; init; }
}
