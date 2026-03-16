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
[IsoId("_EyN00cL8EeujWbERHVYCew")]
[DisplayName("Transaction")]
public record Transaction142
{
    /// <summary>
    /// Code that indicates the type of transaction being undertaken in accordance with ISO 8583, Transaction Type.
    /// </summary>
    [IsoId("_E3L0YcL8EeujWbERHVYCew")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ISO8583TransactionTypeCode TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_E3L0Y8L8EeujWbERHVYCew")]
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
    [IsoId("_E3L0ZcL8EeujWbERHVYCew")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public TransactionAttribute2Code? TransactionAttribute { get; init; }

    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_E3L0Z8L8EeujWbERHVYCew")]
    [DisplayName("Other Transaction Attribute")]
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherTransactionAttribute { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_PPQxh8sKEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_E3L0a8L8EeujWbERHVYCew")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// ISO8583:1993 and ISO 8583:2003 Bit 57
    /// </summary>
    [IsoId("_E3L0bcL8EeujWbERHVYCew")]
    [DisplayName("Pre Authorisation Time Limit")]
    [IsoXmlTag("PreAuthstnTmLmt")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; }

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_E3L0b8L8EeujWbERHVYCew")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService2> AdditionalService { get; init; } = [];

    /// <summary>
    /// Indicates that additional data will be provided in a separate addendum message.
    /// </summary>
    [IsoId("_E3L0ccL8EeujWbERHVYCew")]
    [DisplayName("Associated Data Indicator")]
    [IsoXmlTag("AssoctdDataInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AssociatedDataIndicator { get; init; }

    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_E3L0c8L8EeujWbERHVYCew")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_E3L0dcL8EeujWbERHVYCew")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_E3L0d8L8EeujWbERHVYCew")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_E3L0ecL8EeujWbERHVYCew")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification51 TransactionIdentification { get; init; }

    /// <summary>
    /// Information about the dispute.
    /// </summary>
    [IsoId("_E3L0e8L8EeujWbERHVYCew")]
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public ValueList<DisputeData3> DisputeData { get; init; } = [];

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_E3L0fcL8EeujWbERHVYCew")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts2 TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_E3L0f8L8EeujWbERHVYCew")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<AdditionalAmounts3> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_E3L0h8L8EeujWbERHVYCew")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee2> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Fees not included in the original transaction amount.
    /// </summary>
    [IsoId("_E3L0icL8EeujWbERHVYCew")]
    [DisplayName("Original Additional Fee")]
    [IsoXmlTag("OrgnlAddtlFee")]
    public ValueList<AdditionalFee2> OriginalAdditionalFee { get; init; } = [];

    /// <summary>
    /// Contains ATM deposit details.
    /// </summary>
    [IsoId("_E3L0l8L8EeujWbERHVYCew")]
    [DisplayName("Deposit Details")]
    [IsoXmlTag("DpstDtls")]
    public ValueList<DepositDetails2> DepositDetails { get; init; } = [];

    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_E3L0mcL8EeujWbERHVYCew")]
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService2? FundsServices { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_E3L0m8L8EeujWbERHVYCew")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails3? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_E3L0ncL8EeujWbERHVYCew")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails3? AccountTo { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// ISO 8583:87/93 bit 104
    /// ISO 8583:2003 bit 104-71
    /// </summary>
    [IsoId("_E3L0n8L8EeujWbERHVYCew")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_E3L0ocL8EeujWbERHVYCew")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
