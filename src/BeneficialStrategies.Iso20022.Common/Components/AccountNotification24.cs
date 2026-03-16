// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Notification24.
/// </summary>
[IsoId("_ESCXUT3dEe-thIfLZ94a1w")]
[DisplayName("Account Notification24")]
public record AccountNotification24
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount43 Account { get; init; }

    /// <summary>
    /// Additional Notification Information.
    /// </summary>
    [DisplayName("Additional Notification Information")]
    [IsoXmlTag("AddtlNtfctnInf")]
    public IsoMax500Text? AdditionalNotificationInformation { get; init; }

    /// <summary>
    /// Copy Duplicate Indicator.
    /// </summary>
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Electronic Sequence Number.
    /// </summary>
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Entry.
    /// </summary>
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<ReportEntry15> Entry { get; init; } = [];

    /// <summary>
    /// From To Date.
    /// </summary>
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriod1? FromToDate { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Interest.
    /// </summary>
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public ValueList<AccountInterest4> Interest { get; init; } = [];

    /// <summary>
    /// Legal Sequence Number.
    /// </summary>
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Notification Pagination.
    /// </summary>
    [DisplayName("Notification Pagination")]
    [IsoXmlTag("NtfctnPgntn")]
    public Pagination1? NotificationPagination { get; init; }

    /// <summary>
    /// Related Account.
    /// </summary>
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Reporting Sequence.
    /// </summary>
    [DisplayName("Reporting Sequence")]
    [IsoXmlTag("RptgSeq")]
    public SequenceRange1Choice_? ReportingSequence { get; init; }

    /// <summary>
    /// Reporting Source.
    /// </summary>
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; }

    /// <summary>
    /// Transactions Summary.
    /// </summary>
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions6? TransactionsSummary { get; init; }
}
