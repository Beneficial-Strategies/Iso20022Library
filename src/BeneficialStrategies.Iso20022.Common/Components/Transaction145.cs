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
[IsoId("_QOxOMYKyEeu4svNQ5N-l6w")]
[DisplayName("Transaction")]
public record Transaction145
{
    /// <summary>
    /// Type of transaction associated with the main service.
    /// For valid values, see &quot;Transaction type codes&quot; in ISO 8583 &quot;Financial transaction card originated messages — Interchange message specifications&quot;
    /// </summary>
    [IsoId("_QT17cYKyEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ISO8583TransactionTypeCode TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_QT17c4KyEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Attribute of the transaction.
    /// ISO 8583:87 bit 25
    /// ISO 8583:2003 bit 22-3 &amp; bit 24
    /// </summary>
    [IsoId("_QT17d4KyEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public TransactionAttribute2Code? TransactionAttribute { get; init; }

    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_QT17eYKyEeu4svNQ5N-l6w")]
    [DisplayName("Other Transaction Attribute")]
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherTransactionAttribute { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_QT17e4KyEeu4svNQ5N-l6w")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ISO8583MessageReasonCode? MessageReason { get; init; }

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_QT17fYKyEeu4svNQ5N-l6w")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AlternateMessageReason { get; init; }

    /// <summary>
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// ISO8583:1993 and ISO 8583:2003 Bit 57
    /// </summary>
    [IsoId("_QT17f4KyEeu4svNQ5N-l6w")]
    [DisplayName("Pre Authorisation Time Limit")]
    [IsoXmlTag("PreAuthstnTmLmt")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; }

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_QT17dYKyEeu4svNQ5N-l6w")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public AdditionalService2? AdditionalService { get; init; }

    /// <summary>
    /// Indicates that additional data will be provided in a separate addendum message.
    /// </summary>
    [IsoId("_QT17gYKyEeu4svNQ5N-l6w")]
    [DisplayName("Associated Data Indicator")]
    [IsoXmlTag("AssoctdDataInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AssociatedDataIndicator { get; init; }

    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_QT17g4KyEeu4svNQ5N-l6w")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_QT17hYKyEeu4svNQ5N-l6w")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_QT17h4KyEeu4svNQ5N-l6w")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_QT17iYKyEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification16 TransactionIdentification { get; init; }

    /// <summary>
    /// Information about the dispute.
    /// </summary>
    [IsoId("_QT17i4KyEeu4svNQ5N-l6w")]
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public DisputeData3? DisputeData { get; init; }

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_QT17jYKyEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts2 TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_QT17j4KyEeu4svNQ5N-l6w")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public AdditionalAmounts3? AdditionalAmount { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_QT17kYKyEeu4svNQ5N-l6w")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; }

    /// <summary>
    /// Fees not included in the original transaction amount.
    /// </summary>
    [IsoId("_QT17k4KyEeu4svNQ5N-l6w")]
    [DisplayName("Original Additional Fee")]
    [IsoXmlTag("OrgnlAddtlFee")]
    public AdditionalFee2? OriginalAdditionalFee { get; init; }

    /// <summary>
    /// Contains ATM deposit details.
    /// </summary>
    [IsoId("_QT17lYKyEeu4svNQ5N-l6w")]
    [DisplayName("Deposit Details")]
    [IsoXmlTag("DpstDtls")]
    public DepositDetails2? DepositDetails { get; init; }

    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_QT17l4KyEeu4svNQ5N-l6w")]
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService2? FundsServices { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_QT17mYKyEeu4svNQ5N-l6w")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails3? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_QT17m4KyEeu4svNQ5N-l6w")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails3? AccountTo { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// ISO 8583:87/93 bit 104
    /// ISO 8583:2003 bit 104-71
    /// </summary>
    [IsoId("_QT17nYKyEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_QT17n4KyEeu4svNQ5N-l6w")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }

    /// <summary>
    /// Additional information related to the chargeback.
    /// </summary>
    [IsoId("_Wry28TEEEeyjbpgZW6G1Fg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation20? AdditionalInformation { get; init; }
}
