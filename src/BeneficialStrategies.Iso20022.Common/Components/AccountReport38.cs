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
[IsoId("8e32bd2a-089d-4e57-86f2-070723702e8f")]
[DisplayName("Account Report38")]
public record AccountReport38
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account report.
    /// </summary>
    [IsoId("a56b4f10-b9bd-4240-b168-e5d3eacd01b3")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Provides details on the page number of the report.
    /// </summary>
    [IsoId("51c7d898-5460-4ed6-9376-8545d10844b4")]
    [DisplayName("Report Pagination")]
    [IsoXmlTag("RptPgntn")]
    public Pagination1? ReportPagination { get; init; }

    /// <summary>
    /// Sequential number of the report, as assigned by the account servicer.
    /// </summary>
    [IsoId("5b1ff039-5642-4e1f-ac22-86014c598365")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Specifies the range of identification sequence numbers, as provided in the request.
    /// </summary>
    [IsoId("04887206-daa6-4a89-9fe1-abc1c1c839cc")]
    [DisplayName("Reporting Sequence")]
    [IsoXmlTag("RptgSeq")]
    public SequenceRange1Choice? ReportingSequence { get; init; }

    /// <summary>
    /// Legal sequential number of the report, as assigned by the account servicer.
    /// </summary>
    [IsoId("b3351a0a-2602-484c-bacc-d39758f53e7f")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the report was created.
    /// </summary>
    [IsoId("58177df5-73a1-42cd-987c-e04e5d718ac4")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for which the account report is issued.
    /// </summary>
    [IsoId("3a0aa275-3309-49ce-bb56-b97ec376a9db")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriod1? FromToDate { get; init; }

    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("0e93eb35-6880-4dc7-88e5-f7f9859e6aad")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("f7c8bc37-981f-4182-91e2-dce90fbce911")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice? ReportingSource { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("7dabe380-7935-408d-b5cb-d22efc1aff01")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount43 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the account for which the report has been issued.
    /// </summary>
    [IsoId("10a4dba3-cb3d-4320-99a4-1666c34ccf7f")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("1527736f-5ef6-46b0-b9da-5f50cfb78b2f")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public ValueList<AccountInterest4> Interest { get; init; } = [];

    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("751b2e13-baf1-4a2e-b28d-13e8703d83c8")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance8> Balance { get; init; } = [];

    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("e7507351-de1e-49d1-a7a9-345cc7d4c13b")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions6? TransactionsSummary { get; init; }

    /// <summary>
    /// Specifies an entry in the report.
    /// </summary>
    [IsoId("d8d4ee19-4a3a-49c5-85ac-d3acbffef460")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<ReportEntry16> Entry { get; init; } = [];

    /// <summary>
    /// Further details of the account report.
    /// </summary>
    [IsoId("2d3200bc-a6f6-4b5c-b89e-bd55aa4e8cd8")]
    [DisplayName("Additional Report Information")]
    [IsoXmlTag("AddtlRptInf")]
    public IsoMax500Text? AdditionalReportInformation { get; init; }
}
