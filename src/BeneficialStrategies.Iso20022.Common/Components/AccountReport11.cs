// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the account report.
/// </summary>
[IsoId("_RpFbtNp-Ed-ak6NoX_4Aeg_-1975945805")]
[DisplayName("Account Report")]
public record AccountReport11
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account report.
    /// </summary>
    [IsoId("_RpFbtdp-Ed-ak6NoX_4Aeg_-1975945557")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Sequential number of the report, as assigned by the account servicer. |Usage: The sequential number is increased incrementally for each report sent electronically.
    /// </summary>
    [IsoId("_RpFbttp-Ed-ak6NoX_4Aeg_-1975945503")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Legal sequential number of the report, as assigned by the account servicer. It is increased incrementally for each report sent.
    /// </summary>
    [IsoId("_RpFbt9p-Ed-ak6NoX_4Aeg_-1975945442")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_RpFbuNp-Ed-ak6NoX_4Aeg_-1975945534")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for which the account report is issued.
    /// </summary>
    [IsoId("_RpFbudp-Ed-ak6NoX_4Aeg_-1975944948")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; }

    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_RpPMsNp-Ed-ak6NoX_4Aeg_-1975945411")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("_RpPMsdp-Ed-ak6NoX_4Aeg_-334997135")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("_RpPMstp-Ed-ak6NoX_4Aeg_-1975945040")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount20 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the account for which the report has been issued.
    /// </summary>
    [IsoId("_RpPMs9p-Ed-ak6NoX_4Aeg_-1975944917")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount16? RelatedAccount { get; init; }

    /// <summary>
    /// Set of elements used to provide general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_RpPMtNp-Ed-ak6NoX_4Aeg_-1975944978")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public AccountInterest2? Interest { get; init; }

    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("_RpPMtdp-Ed-ak6NoX_4Aeg_-1975944608")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CashBalance3? Balance { get; init; }

    /// <summary>
    /// Set of elements used to provide summary information on entries.
    /// </summary>
    [IsoId("_RpPMttp-Ed-ak6NoX_4Aeg_-1975944856")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions2? TransactionsSummary { get; init; }

    /// <summary>
    /// Set of elements used to specify an entry in the report.|Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    [IsoId("_RpPMt9p-Ed-ak6NoX_4Aeg_-1975945070")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ReportEntry2? Entry { get; init; }

    /// <summary>
    /// Further details of the account report.
    /// </summary>
    [IsoId("_RpPMuNp-Ed-ak6NoX_4Aeg_-1975945102")]
    [DisplayName("Additional Report Information")]
    [IsoXmlTag("AddtlRptInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalReportInformation { get; init; }
}
