// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
[IsoId("_GYwNwVwfEeeFSOC87I8qLw")]
[DisplayName("Transaction")]
public record Transaction77
{
    /// <summary>
    /// Type of transaction associated with the main service.
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    [IsoId("_GlJrAVwfEeeFSOC87I8qLw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public required IsoExact2AlphaNumericText TransactionType { get; init; }

    /// <summary>
    /// Provides further granularity of purpose of TransactionType
    /// </summary>
    [IsoId("_13NxgRqjEeqH1IQNpbVpEw")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_H5JMkFyaEeeve7Je9cXtkQ")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService1> AdditionalService { get; init; } = [];

    /// <summary>
    /// Attribute of the transaction.
    /// ISO 8583:87 bit 25
    /// ISO 8583:2003 bit 22-3 &amp; bit 24
    /// </summary>
    [IsoId("_JtDHgkP3EeiFlYmBVFSxUw")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public TransactionAttribute1Code? TransactionAttribute { get; init; }

    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_JtDHg0P3EeiFlYmBVFSxUw")]
    [DisplayName("Other Transaction Attribute")]
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherTransactionAttribute { get; init; }

    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_GlJrA1wfEeeFSOC87I8qLw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<IsoExact4NumericText> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_q8sy8YkGEeiUdscb3zN7pw")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax35Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// ISO8583:1993 and ISO 8583:2003 Bit 57
    /// </summary>
    [IsoId("_JHYeUYkGEeiUdscb3zN7pw")]
    [DisplayName("Pre Authorisation Time Limit")]
    [IsoXmlTag("PreAuthstnTmLmt")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; }

    /// <summary>
    /// Indicates that additional data will be provided in a separate addendum message.
    /// </summary>
    [IsoId("_pgm1sOkVEemeDPHh-U9b6w")]
    [DisplayName("Associated Data Indicator")]
    [IsoXmlTag("AssoctdDataInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AssociatedDataIndicator { get; init; }

    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_OquXweFlEeeA0cKTZTRL5g")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_3ZsFYOkVEemeDPHh-U9b6w")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_GlJrCVwfEeeFSOC87I8qLw")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_GlJrC1wfEeeFSOC87I8qLw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification8 TransactionIdentification { get; init; }

    /// <summary>
    /// Information about the dispute.
    /// </summary>
    [IsoId("_GlJrDVwfEeeFSOC87I8qLw")]
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public ValueList<DisputeData1> DisputeData { get; init; } = [];

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_GlJrD1wfEeeFSOC87I8qLw")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts1 TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// ISO 8583 bit 54
    /// </summary>
    [IsoId("_ienjYRb3Eeit0dtP9bTmEg")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public ValueList<AdditionalAmounts1> AdditionalAmounts { get; init; } = [];

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_pME34RcNEeit0dtP9bTmEg")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public ValueList<AdditionalFee1> AdditionalFees { get; init; } = [];

    /// <summary>
    /// Fees not included in the original transaction amount.
    /// ISO 8583:93/2003 bit 66
    /// </summary>
    [IsoId("_FkuBgUKJEeizracUzPue1w")]
    [DisplayName("Original Additional Fees")]
    [IsoXmlTag("OrgnlAddtlFees")]
    public ValueList<AdditionalFee1> OriginalAdditionalFees { get; init; } = [];

    /// <summary>
    /// Contains ATM deposit details.
    /// </summary>
    [IsoId("_wVlg8NCIEei_pMueJh_zOA")]
    [DisplayName("Deposit Details")]
    [IsoXmlTag("DpstDtls")]
    public ValueList<DepositDetails1> DepositDetails { get; init; } = [];

    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_GlJrE1wfEeeFSOC87I8qLw")]
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService1? FundsServices { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_GlJrFVwfEeeFSOC87I8qLw")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails2? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_GlJrF1wfEeeFSOC87I8qLw")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails2? AccountTo { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// ISO 8583:87/93 bit 104
    /// ISO 8583:2003 bit 104-71
    /// </summary>
    [IsoId("_HlWc8ZcpEeel1pCh5hkJPA")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_7rytURqlEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
