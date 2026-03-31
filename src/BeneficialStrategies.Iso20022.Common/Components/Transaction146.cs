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
[IsoId("_BmYzEYKzEeu4svNQ5N-l6w")]
[DisplayName("Transaction")]
public record Transaction146
{
    /// <summary>
    /// Type of transaction associated with the main service.
    /// For valid values, see &quot;Transaction type codes&quot; in ISO 8583 &quot;Financial transaction card originated messages — Interchange message specifications&quot;
    /// </summary>
    [IsoId("_BrTvUYKzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ISO8583TransactionTypeCode TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_BrTvU4KzEeu4svNQ5N-l6w")]
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
    [IsoId("_BrTvV4KzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public TransactionAttribute2Code? TransactionAttribute { get; init; }

    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_BrTvWYKzEeu4svNQ5N-l6w")]
    [DisplayName("Other Transaction Attribute")]
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherTransactionAttribute { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_cBQIN8sIEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined  in external code list.
    /// </summary>
    [IsoId("_BrTvXYKzEeu4svNQ5N-l6w")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_BrTvVYKzEeu4svNQ5N-l6w")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService2> AdditionalService { get; init; } = [];

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_BrTvX4KzEeu4svNQ5N-l6w")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_BrTvYYKzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification18 TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction currency of the acceptor.
    /// ISO 4217
    /// </summary>
    [IsoId("_BrTvY4KzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Currency")]
    [IsoXmlTag("TxCcy")]
    public ISO3NumericCurrencyCode? TransactionCurrency { get; init; }

    /// <summary>
    /// Further details of some or all amounts in the transaction amount.
    /// The detailed amount is used to calculate the reconciliation amount for messages in which the transaction amount is absent.
    /// </summary>
    [IsoId("_BrTvZYKzEeu4svNQ5N-l6w")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public ValueList<DetailedAmount23> DetailedAmount { get; init; } = [];

    /// <summary>
    /// Amount used for reconciliation.
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field
    /// </summary>
    [IsoId("_BrTvZ4KzEeu4svNQ5N-l6w")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public Amount15? ReconciliationAmount { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_BrTvaYKzEeu4svNQ5N-l6w")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<AdditionalAmounts3> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_BrTva4KzEeu4svNQ5N-l6w")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee2> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_BrTvbYKzEeu4svNQ5N-l6w")]
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService2? FundsServices { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_BrTvb4KzEeu4svNQ5N-l6w")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails3? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_BrTvcYKzEeu4svNQ5N-l6w")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails3? AccountTo { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_BrTvc4KzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_BrTvdYKzEeu4svNQ5N-l6w")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
