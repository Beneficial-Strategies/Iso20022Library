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
[IsoId("40eaa819-e004-464c-a427-b7c716ffe14e")]
[DisplayName("Account Notification25")]
public record AccountNotification25
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account notification.
    /// </summary>
    [IsoId("91ff7335-fd25-417a-9755-7f2f018a217b")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Provides details on the page number of the notification.
    /// </summary>
    [IsoId("59baf14a-246e-4c07-b454-b44bdf7bc002")]
    [DisplayName("Notification Pagination")]
    [IsoXmlTag("NtfctnPgntn")]
    public Pagination1? NotificationPagination { get; init; }

    /// <summary>
    /// Sequential number of the notification, as assigned by the account servicer.
    /// </summary>
    [IsoId("298d5b45-acfb-4a63-a7ff-0e243792b784")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Specifies the range of identification sequence numbers, as provided in the request.
    /// </summary>
    [IsoId("3258cee4-a0e0-4b42-ad35-c38e14dd4a78")]
    [DisplayName("Reporting Sequence")]
    [IsoXmlTag("RptgSeq")]
    public SequenceRange1Choice_? ReportingSequence { get; init; }

    /// <summary>
    /// Legal sequential number of the notification, as assigned by the account servicer.
    /// </summary>
    [IsoId("10b1471b-7aeb-4ed9-9e7a-51a6c60f349f")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the notification was created.
    /// </summary>
    [IsoId("fe46b445-dbf3-4735-a5d9-1da1dd4f43eb")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for which the account notification is issued.
    /// </summary>
    [IsoId("ae5781e3-0c23-4c05-8936-e6d5c7874df3")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriod1? FromToDate { get; init; }

    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("5562673e-36c3-4c5b-ab75-bdd6768a7791")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("3506cfa2-e8aa-43a3-80fd-5aa0145b29a3")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("e034d986-0030-424b-81fd-d5eeb37cafba")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount43 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the account for which the notification has been issued.
    /// </summary>
    [IsoId("60fa9e58-d777-4b06-b00f-7228f763a886")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("3bbeb519-4399-473f-9098-a284cfa6cc2b")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public ValueList<AccountInterest4> Interest { get; init; } = [];

    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("9a9c47a1-ff11-410e-9f15-efe18841bee7")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions6? TransactionsSummary { get; init; }

    /// <summary>
    /// Specifies an entry in the debit credit notification.
    /// </summary>
    [IsoId("f838a0ba-a572-46c5-afc7-21e876e7e26a")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<ReportEntry16> Entry { get; init; } = [];

    /// <summary>
    /// Further details of the account notification.
    /// </summary>
    [IsoId("70c7c621-607a-4b80-8c57-6826db65e8b0")]
    [DisplayName("Additional Notification Information")]
    [IsoXmlTag("AddtlNtfctnInf")]
    public IsoMax500Text? AdditionalNotificationInformation { get; init; }
}
