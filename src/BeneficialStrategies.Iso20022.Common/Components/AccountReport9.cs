// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing further details on the account report.
/// </summary>
[IsoId("_RToJFNp-Ed-ak6NoX_4Aeg_1717615709")]
[DisplayName("Account Report")]
public record AccountReport9
{
    /// <summary>
    /// Unique and unambiguous identification of the account report, assigned by the account servicer.
    /// </summary>
    [IsoId("_RToJFdp-Ed-ak6NoX_4Aeg_-1849617907")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Sequential number of the report, assigned by the account servicer. It is increased incrementally for each report sent electronically.
    /// </summary>
    [IsoId("_RToJFtp-Ed-ak6NoX_4Aeg_-1308435115")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Legal sequential number of the report, assigned by the account servicer. It is increased incrementally for each report sent.||Usage: in those scenarios where eg a paper statement is a legal requirement, the paper statement may have a different numbering than the electronic sequential number. Paper statements can for instance only be sent if movement on the account has taken place, whereas electronic statements can be sent eg each day, regardless of whether movements have taken place or not.
    /// </summary>
    [IsoId("_RToJF9p-Ed-ak6NoX_4Aeg_-1265952060")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the report was created.
    /// </summary>
    [IsoId("_RToJGNp-Ed-ak6NoX_4Aeg_-1849617366")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between the start date and the end date for which the account report is issued.
    /// </summary>
    [IsoId("_RTx6ENp-Ed-ak6NoX_4Aeg_-59832366")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; }

    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_RTx6Edp-Ed-ak6NoX_4Aeg_-75800470")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_RTx6Etp-Ed-ak6NoX_4Aeg_86038872")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount13 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the reported account.
    /// </summary>
    [IsoId("_RTx6E9p-Ed-ak6NoX_4Aeg_-608669049")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount7? RelatedAccount { get; init; }

    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_RTx6FNp-Ed-ak6NoX_4Aeg_-149678698")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public ValueList<AccountInterest1> Interest { get; init; } = [];

    /// <summary>
    /// Set of elements defining the balance(s).
    /// </summary>
    [IsoId("_RTx6Fdp-Ed-ak6NoX_4Aeg_580186645")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance1> Balance { get; init; } = [];

    /// <summary>
    /// Set of element providing summary information on entries.
    /// </summary>
    [IsoId("_RTx6Ftp-Ed-ak6NoX_4Aeg_1417756045")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions1? TransactionsSummary { get; init; }

    /// <summary>
    /// Specifies the elements of an entry in the report.||Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    [IsoId("_RTx6F9p-Ed-ak6NoX_4Aeg_-1994259931")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<ReportEntry1> Entry { get; init; } = [];

    /// <summary>
    /// Further details on the account report.
    /// </summary>
    [IsoId("_RT7rENp-Ed-ak6NoX_4Aeg_1459644960")]
    [DisplayName("Additional Report Information")]
    [IsoXmlTag("AddtlRptInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalReportInformation { get; init; }
}
