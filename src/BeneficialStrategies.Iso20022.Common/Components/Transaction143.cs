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
[IsoId("_YhVm0TEFEeyjbpgZW6G1Fg")]
[DisplayName("Transaction")]
public record Transaction143
{
    /// <summary>
    /// Type of transaction associated with the main service
    /// For valid values, see &quot;Transaction type codes&quot; in ISO 8583 &quot;Financial transaction card originated messages — Interchange message specifications&quot;
    /// </summary>
    [IsoId("_YmYe4TEFEeyjbpgZW6G1Fg")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ISO8583TransactionTypeCode TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_YmYe6TEFEeyjbpgZW6G1Fg")]
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
    [IsoId("_YmYe6zEFEeyjbpgZW6G1Fg")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public TransactionAttribute2Code? TransactionAttribute { get; init; }

    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_YmYe7TEFEeyjbpgZW6G1Fg")]
    [DisplayName("Other Transaction Attribute")]
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherTransactionAttribute { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_hc07JzEFEeyjbpgZW6G1Fg")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined  in external code list.
    /// </summary>
    [IsoId("_inTKMTEFEeyjbpgZW6G1Fg")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// </summary>
    [IsoId("_YmYe7zEFEeyjbpgZW6G1Fg")]
    [DisplayName("Pre Authorisation Time Limit")]
    [IsoXmlTag("PreAuthstnTmLmt")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; }

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_YmYe8TEFEeyjbpgZW6G1Fg")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService2> AdditionalService { get; init; } = [];

    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_YmYe8zEFEeyjbpgZW6G1Fg")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_YmYe9TEFEeyjbpgZW6G1Fg")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction
    /// </summary>
    [IsoId("_YmYe9zEFEeyjbpgZW6G1Fg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification51 TransactionIdentification { get; init; }

    /// <summary>
    /// Data related to the dispute.
    /// </summary>
    [IsoId("_jYSiQTEFEeyjbpgZW6G1Fg")]
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public required DisputeData3 DisputeData { get; init; }

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_YmYe-TEFEeyjbpgZW6G1Fg")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts2 TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_YmYe-zEFEeyjbpgZW6G1Fg")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<AdditionalAmounts3> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_YmZF8zEFEeyjbpgZW6G1Fg")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee2> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Fees not included in the original transaction amount.
    /// </summary>
    [IsoId("_YmZF9TEFEeyjbpgZW6G1Fg")]
    [DisplayName("Original Additional Fee")]
    [IsoXmlTag("OrgnlAddtlFee")]
    public ValueList<AdditionalFee2> OriginalAdditionalFee { get; init; } = [];

    /// <summary>
    /// Balance of the account involved in the card transaction.
    /// </summary>
    [IsoId("_YmZF9zEFEeyjbpgZW6G1Fg")]
    [DisplayName("Account Balance")]
    [IsoXmlTag("AcctBal")]
    public ValueList<AccountBalance2> AccountBalance { get; init; } = [];

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_YmZF-TEFEeyjbpgZW6G1Fg")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails3? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_YmZF-zEFEeyjbpgZW6G1Fg")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails3? AccountTo { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_YmZF_TEFEeyjbpgZW6G1Fg")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_YmZF_zEFEeyjbpgZW6G1Fg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Additional information related to the chargeback.
    /// </summary>
    [IsoId("_kHWnsTEFEeyjbpgZW6G1Fg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation20? AdditionalInformation { get; init; }
}
