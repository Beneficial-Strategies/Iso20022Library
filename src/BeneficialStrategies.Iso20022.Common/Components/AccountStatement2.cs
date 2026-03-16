// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the account statement.
/// </summary>
[IsoId("_RqIkl9p-Ed-ak6NoX_4Aeg_-1148769640")]
[DisplayName("Account Statement")]
public record AccountStatement2
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account statement.
    /// </summary>
    [IsoId("_RqIkmNp-Ed-ak6NoX_4Aeg_-1148769579")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Sequential number of the statement, as assigned by the account servicer.|Usage: The sequential number is increased incrementally for each statement sent electronically.
    /// </summary>
    [IsoId("_RqRugNp-Ed-ak6NoX_4Aeg_-1148769300")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Legal sequential number of the statement, as assigned by the account servicer. It is increased incrementally for each statement sent.||Usage: Where a paper statement is a legal requirement, it may have a number different from the electronic sequential number. Paper statements could for instance only be sent if movement on the account has taken place, whereas electronic statements could be sent at the end of each reporting period, regardless of whether movements have taken place or not.
    /// </summary>
    [IsoId("_RqRugdp-Ed-ak6NoX_4Aeg_-1148769270")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_RqRugtp-Ed-ak6NoX_4Aeg_-1148769548")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for which the account statement is issued.
    /// </summary>
    [IsoId("_RqRug9p-Ed-ak6NoX_4Aeg_-1148768322")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; }

    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_RqRuhNp-Ed-ak6NoX_4Aeg_-1148769239")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("_RqRuhdp-Ed-ak6NoX_4Aeg_-1148768784")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice_? ReportingSource { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("_RqRuhtp-Ed-ak6NoX_4Aeg_-1148768846")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount20 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the account for which the statement has been issued.
    /// </summary>
    [IsoId("_RqRuh9p-Ed-ak6NoX_4Aeg_-1148768631")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount16? RelatedAccount { get; init; }

    /// <summary>
    /// Set of elements used to provide general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_RqRuiNp-Ed-ak6NoX_4Aeg_-1148768661")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public AccountInterest2? Interest { get; init; }

    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("_RqRuidp-Ed-ak6NoX_4Aeg_-1148768260")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance3> Balance { get; init; } = [];

    // ID for the above is _RqRuidp-Ed-ak6NoX_4Aeg_-1148768260

    /// <summary>
    /// Set of elements used to provide summary information on entries.
    /// </summary>
    [IsoId("_RqbfgNp-Ed-ak6NoX_4Aeg_-1147847982")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions2? TransactionsSummary { get; init; }

    /// <summary>
    /// Set of elements used to specify an entry in the statement.|Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    [IsoId("_Rqbfgdp-Ed-ak6NoX_4Aeg_-1148768722")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ReportEntry2? Entry { get; init; }

    /// <summary>
    /// Further details of the account statement.
    /// </summary>
    [IsoId("_Rqbfgtp-Ed-ak6NoX_4Aeg_-1148769147")]
    [DisplayName("Additional Statement Information")]
    [IsoXmlTag("AddtlStmtInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalStatementInformation { get; init; }
}
