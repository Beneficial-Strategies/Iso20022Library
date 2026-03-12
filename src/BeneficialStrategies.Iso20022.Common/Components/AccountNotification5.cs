// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the account notification.
/// </summary>
[IsoId("_tryC8FkyEeGeoaLUQk__nA_-1904568694")]
[DisplayName("Account Notification")]
public partial record AccountNotification5
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account notification.
    /// </summary>
    [IsoId("_tryC8VkyEeGeoaLUQk__nA_-1257642607")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Provides details on the page number of the notification.
    /// Usage: The pagination of the notification is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_tryC8lkyEeGeoaLUQk__nA_1110213172")]
    [DisplayName("Notification Pagination")]
    [IsoXmlTag("NtfctnPgntn")]
    public Pagination? NotificationPagination { get; init; } 
    
    /// <summary>
    /// Sequential number of the notification, as assigned by the account servicer. |Usage: The sequential number is increased incrementally for each notification sent electronically.
    /// </summary>
    [IsoId("_tryC81kyEeGeoaLUQk__nA_1157019049")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    
    /// <summary>
    /// Legal sequential number of the notification, as assigned by the account servicer. It is increased incrementally for each notification sent.
    /// </summary>
    [IsoId("_tryC9FkyEeGeoaLUQk__nA_46107630")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_tr7z8FkyEeGeoaLUQk__nA_-803555338")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Range of time between a start date and an end date for which the account notification is issued.
    /// </summary>
    [IsoId("_tr7z8VkyEeGeoaLUQk__nA_1319148580")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_tr7z8lkyEeGeoaLUQk__nA_1027367831")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("_tr7z81kyEeGeoaLUQk__nA_-1144895547")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("_tr7z9FkyEeGeoaLUQk__nA_-1596532334")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount25 Account { get; init; } 
    
    /// <summary>
    /// Identifies the parent account of the account for which the notification has been issued.
    /// </summary>
    [IsoId("_tsFk8FkyEeGeoaLUQk__nA_-295626120")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount24? RelatedAccount { get; init; } 
    
    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_tsFk8VkyEeGeoaLUQk__nA_626537190")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public AccountInterest2? Interest { get; init; } 
    
    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("_tsFk8lkyEeGeoaLUQk__nA_1636053978")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions2? TransactionsSummary { get; init; } 
    
    /// <summary>
    /// Set of elements used to specify an entry in the debit credit notification.|Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    [IsoId("_tsFk81kyEeGeoaLUQk__nA_-1241324015")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ReportEntry3? Entry { get; init; } 
    
    /// <summary>
    /// Further details of the account notification.
    /// </summary>
    [IsoId("_tsFk9FkyEeGeoaLUQk__nA_147755913")]
    [DisplayName("Additional Notification Information")]
    [IsoXmlTag("AddtlNtfctnInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalNotificationInformation { get; init; } 
    
    
    #nullable disable
    
}
