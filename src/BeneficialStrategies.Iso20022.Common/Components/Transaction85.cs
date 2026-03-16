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
[IsoId("_f0o4JuwcEeiMkKo2clXHdQ")]
[DisplayName("Transaction")]
public record Transaction85
{
    /// <summary>
    /// Type of transaction associated with the main service.
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    [IsoId("_f0o4NOwcEeiMkKo2clXHdQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public IsoExact2AlphaNumericText? TransactionType { get; init; }

    /// <summary>
    /// Provides further granularity of purpose of TransactionType
    /// </summary>
    [IsoId("_SkMTURqkEeqH1IQNpbVpEw")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_f0o4LOwcEeiMkKo2clXHdQ")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService1> AdditionalService { get; init; } = [];

    /// <summary>
    /// Attribute of the transaction.
    /// ISO 8583:87 bit 25
    /// ISO 8583:2003 bit 22-3 &amp; bit 24
    /// </summary>
    [IsoId("_f0o4K-wcEeiMkKo2clXHdQ")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public TransactionAttribute1Code? TransactionAttribute { get; init; }

    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_f0o4J-wcEeiMkKo2clXHdQ")]
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
    [IsoId("_f0pfIuwcEeiMkKo2clXHdQ")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<IsoExact4NumericText> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_f0pfJOwcEeiMkKo2clXHdQ")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax35Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// </summary>
    [IsoId("_f0o4MOwcEeiMkKo2clXHdQ")]
    [DisplayName("Pre Authorisation Time Limit")]
    [IsoXmlTag("PreAuthstnTmLmt")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; }

    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_f0pfIOwcEeiMkKo2clXHdQ")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_f0o4KOwcEeiMkKo2clXHdQ")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_f0pfIewcEeiMkKo2clXHdQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification11? TransactionIdentification { get; init; }

    /// <summary>
    /// Information about the dispute.
    /// </summary>
    [IsoId("_f0o4KewcEeiMkKo2clXHdQ")]
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public ValueList<DisputeData1> DisputeData { get; init; } = [];

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_f0o4LewcEeiMkKo2clXHdQ")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public TransactionAmounts1? TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// ISO 8583 bit 54
    /// </summary>
    [IsoId("_f0o4LuwcEeiMkKo2clXHdQ")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public ValueList<AdditionalAmounts1> AdditionalAmounts { get; init; } = [];

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_f0pfJewcEeiMkKo2clXHdQ")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public ValueList<AdditionalFee1> AdditionalFees { get; init; } = [];

    /// <summary>
    /// Fees not included in the original transaction amount.
    /// </summary>
    [IsoId("_f0o4MuwcEeiMkKo2clXHdQ")]
    [DisplayName("Original Additional Fees")]
    [IsoXmlTag("OrgnlAddtlFees")]
    public ValueList<AdditionalFee1> OriginalAdditionalFees { get; init; } = [];

    /// <summary>
    /// Contains ATM deposit details.
    /// </summary>
    [IsoId("_f0o4L-wcEeiMkKo2clXHdQ")]
    [DisplayName("Deposit Details")]
    [IsoXmlTag("DpstDtls")]
    public ValueList<DepositDetails1> DepositDetails { get; init; } = [];

    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_f0pfI-wcEeiMkKo2clXHdQ")]
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService1? FundsServices { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_f0o4MewcEeiMkKo2clXHdQ")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails2? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_f0o4M-wcEeiMkKo2clXHdQ")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails2? AccountTo { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_f0o4KuwcEeiMkKo2clXHdQ")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_BX2RMRqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
