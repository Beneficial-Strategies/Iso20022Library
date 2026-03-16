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
[IsoId("_pjc5EYNjEeuHqfO1LgkE9Q")]
[DisplayName("Transaction")]
public record Transaction147
{
    /// <summary>
    /// Type of transaction associated with the main service.
    /// For valid values, see &quot;Transaction type codes&quot; in ISO 8583 &quot;Financial transaction card originated messages — Interchange message specifications&quot;
    /// </summary>
    [IsoId("_ppkIIYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ISO8583TransactionTypeCode? TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_ppkII4NjEeuHqfO1LgkE9Q")]
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
    [IsoId("_ppkIJ4NjEeuHqfO1LgkE9Q")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public TransactionAttribute2Code? TransactionAttribute { get; init; }

    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_ppkIKYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Other Transaction Attribute")]
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherTransactionAttribute { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_0L-m18sIEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_ppkILYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax35Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// </summary>
    [IsoId("_ppkIL4NjEeuHqfO1LgkE9Q")]
    [DisplayName("Pre Authorisation Time Limit")]
    [IsoXmlTag("PreAuthstnTmLmt")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; }

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_ppkIJYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService2> AdditionalService { get; init; } = [];

    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_ppkIMYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_ppkIM4NjEeuHqfO1LgkE9Q")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_ppkINYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification18? TransactionIdentification { get; init; }

    /// <summary>
    /// Information about the dispute.
    /// </summary>
    [IsoId("_ppkIN4NjEeuHqfO1LgkE9Q")]
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public ValueList<DisputeData3> DisputeData { get; init; } = [];

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_ppkIOYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public TransactionAmounts2? TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_ppkIO4NjEeuHqfO1LgkE9Q")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<AdditionalAmounts3> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_ppkIPYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee2> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Fees not included in the original transaction amount.
    /// </summary>
    [IsoId("_ppkIP4NjEeuHqfO1LgkE9Q")]
    [DisplayName("Original Additional Fee")]
    [IsoXmlTag("OrgnlAddtlFee")]
    public ValueList<AdditionalFee2> OriginalAdditionalFee { get; init; } = [];

    /// <summary>
    /// Contains ATM deposit details.
    /// </summary>
    [IsoId("_ppkIQYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Deposit Details")]
    [IsoXmlTag("DpstDtls")]
    public ValueList<DepositDetails2> DepositDetails { get; init; } = [];

    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_ppkIQ4NjEeuHqfO1LgkE9Q")]
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService2? FundsServices { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_ppkIRYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails3? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_ppkIR4NjEeuHqfO1LgkE9Q")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails3? AccountTo { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_ppkISYNjEeuHqfO1LgkE9Q")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_ppkIS4NjEeuHqfO1LgkE9Q")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
