// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing further details on the account notification.
/// </summary>
[IsoId("_RTe_JNp-Ed-ak6NoX_4Aeg_-1487171908")]
[DisplayName("Account Notification")]
public partial record AccountNotification1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the account report, assigned by the account servicer.
    /// </summary>
    [IsoId("_RTe_Jdp-Ed-ak6NoX_4Aeg_-1487171890")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Sequential number of the report, assigned by the account servicer. It is increased incrementally for each report sent electronically.
    /// </summary>
    [IsoId("_RTe_Jtp-Ed-ak6NoX_4Aeg_-1487171561")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    
    /// <summary>
    /// Legal sequential number of the report, assigned by the account servicer. It is increased incrementally for each report sent.||Usage: in those scenarios where eg a paper statement is a legal requirement, the paper statement may have a different numbering than the electronic sequential number. Paper statements can for instance only be sent if movement on the account has taken place, whereas electronic statements can be sent eg each day, regardless of whether movements have taken place or not.
    /// </summary>
    [IsoId("_RTe_J9p-Ed-ak6NoX_4Aeg_-1487171501")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; } 
    
    /// <summary>
    /// Date and time at which the report was created.
    /// </summary>
    [IsoId("_RTe_KNp-Ed-ak6NoX_4Aeg_-1487171596")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Range of time between the start date and the end date for which the account notification is issued.
    /// </summary>
    [IsoId("_RTe_Kdp-Ed-ak6NoX_4Aeg_-1487170226")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; } 
    
    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_RTe_Ktp-Ed-ak6NoX_4Aeg_-1487171218")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_RTe_K9p-Ed-ak6NoX_4Aeg_1577699571")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount13 Account { get; init; } 
    
    /// <summary>
    /// Identifies the parent account of the reported account.
    /// </summary>
    [IsoId("_RToJENp-Ed-ak6NoX_4Aeg_1577699416")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount7? RelatedAccount { get; init; } 
    
    /// <summary>
    /// Set of element providing summary information on entries.
    /// </summary>
    [IsoId("_RToJEdp-Ed-ak6NoX_4Aeg_1577699338")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions1? TransactionsSummary { get; init; } 
    
    /// <summary>
    /// Specifies the elements of an entry in the report.||Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    [IsoId("_RToJEtp-Ed-ak6NoX_4Aeg_1577699848")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public NotificationEntry1? Entry { get; init; } 
    
    /// <summary>
    /// Further details on the account notification.
    /// </summary>
    [IsoId("_RToJE9p-Ed-ak6NoX_4Aeg_-1487171176")]
    [DisplayName("Additional Notification Information")]
    [IsoXmlTag("AddtlNtfctnInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalNotificationInformation { get; init; } 
    
    
    #nullable disable
    
}
