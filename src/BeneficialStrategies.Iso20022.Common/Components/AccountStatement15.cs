// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the account statement.
/// </summary>
[IsoId("f2d5db70-d297-4049-9ae1-97fe2c32f5ef")]
[DisplayName("Account Statement15")]
public record AccountStatement15
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account statement.
    /// </summary>
    [IsoId("6e3e2272-6daf-46fb-9ab6-83ff34f08155")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Provides details on the page number of the statement.
    /// </summary>
    [IsoId("df275ee3-f4d9-4a64-b4fd-9cacf4c6004b")]
    [DisplayName("Statement Pagination")]
    [IsoXmlTag("StmtPgntn")]
    public Pagination1? StatementPagination { get; init; }

    /// <summary>
    /// Sequential number of the statement, as assigned by the account servicer.
    /// </summary>
    [IsoId("c5f4c80a-a8f3-4d3f-881b-20bf2d990db4")]
    [DisplayName("Electronic Sequence Number")]
    [IsoXmlTag("ElctrncSeqNb")]
    public IsoNumber? ElectronicSequenceNumber { get; init; }

    /// <summary>
    /// Specifies the range of identification sequence numbers, as provided in the request.
    /// </summary>
    [IsoId("5d16a146-9a8e-4b78-9ec4-e5f01bb83f61")]
    [DisplayName("Reporting Sequence")]
    [IsoXmlTag("RptgSeq")]
    public SequenceRange1Choice? ReportingSequence { get; init; }

    /// <summary>
    /// Legal sequential number of the statement, as assigned by the account servicer.
    /// </summary>
    [IsoId("48e101a8-2e98-4baa-96cf-00c18c0d5a00")]
    [DisplayName("Legal Sequence Number")]
    [IsoXmlTag("LglSeqNb")]
    public IsoNumber? LegalSequenceNumber { get; init; }

    /// <summary>
    /// Date and time at which the statement was created.
    /// </summary>
    [IsoId("012b0fff-86ec-4c9d-971a-1fd7ccdfd8e1")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for which the account statement is issued.
    /// </summary>
    [IsoId("dbe574d0-dcfd-4a06-a353-dcd3a8bd4039")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriod1? FromToDate { get; init; }

    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("160725eb-93bd-4284-b0b5-c5a97a928464")]
    [DisplayName("Copy Duplicate Indicator")]
    [IsoXmlTag("CpyDplctInd")]
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("c777fbd9-ef07-4c36-a124-6d852f0d856b")]
    [DisplayName("Reporting Source")]
    [IsoXmlTag("RptgSrc")]
    public ReportingSource1Choice? ReportingSource { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("82493aba-0890-4d4d-b390-b834cd35600b")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount43 Account { get; init; }

    /// <summary>
    /// Identifies the parent account of the account for which the statement has been issued.
    /// </summary>
    [IsoId("d7d4c04f-11e9-493f-885b-ad142fa7f504")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("9e152592-106c-40ed-8af8-601a81c41008")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public ValueList<AccountInterest4> Interest { get; init; } = [];

    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("62002a5c-b6a0-496c-ae85-d8dfff8cbaaf")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    [MinLength(1)]
    public ValueList<CashBalance8> Balance { get; init; } = [];

    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("2a0f7266-6db8-41b7-ae18-6a621d7f011d")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public TotalTransactions6? TransactionsSummary { get; init; }

    /// <summary>
    /// Specify an entry in the statement.
    /// </summary>
    [IsoId("c1bfd244-584b-46fd-bcfb-45d012593359")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<ReportEntry16> Entry { get; init; } = [];

    /// <summary>
    /// Further details of the account statement.
    /// </summary>
    [IsoId("75366df7-0827-4c64-bc68-db0739e045ae")]
    [DisplayName("Additional Statement Information")]
    [IsoXmlTag("AddtlStmtInf")]
    public IsoMax500Text? AdditionalStatementInformation { get; init; }
}
