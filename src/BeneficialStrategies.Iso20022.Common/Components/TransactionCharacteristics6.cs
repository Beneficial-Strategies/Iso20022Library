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
[IsoId("_59mCwV59EfCoP_h9uwd39Q")]
[DisplayName("Transaction Characteristics6")]
public record TransactionCharacteristics6
{
    /// <summary>
    /// Code that indicates the type of transaction being undertaken in accordance with ISO 8583, Transaction Type.
    /// </summary>
    [IsoId("_6AVNsV59EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ISO8583TransactionTypeCode? TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_6AVNuV59EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Attribute of the transaction. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_6AVNu159EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public SimpleValueList<TransactionAttribute3Code> TransactionAttribute { get; init; } = [];

    /// <summary>
    /// Indicates the previous message is cancelled.
    /// </summary>
    [IsoId("_6AVNy159EfCoP_h9uwd39Q")]
    [DisplayName("Cancellation")]
    [IsoXmlTag("Cxl")]
    public IsoTrueFalseIndicator? Cancellation { get; init; }

    /// <summary>
    /// Indicates the type of transaction that will follow an approved InquiryVerificationResponse.
    /// </summary>
    [IsoId("_rMT08GP9EfCX7uJiAWHfoQ")]
    [DisplayName("Subsequent Transaction Type")]
    [IsoXmlTag("SbsqntTxTp")]
    public ISO8583TransactionTypeCode? SubsequentTransactionType { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// </summary>
    [IsoId("_6AVNzV59EfCoP_h9uwd39Q")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_6AVN2159EfCoP_h9uwd39Q")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_6AVN3V59EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_9Acvw159EfCoP_h9uwd39Q")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_9AcvxF59EfCoP_h9uwd39Q")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_9AcvxV59EfCoP_h9uwd39Q")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData22> LocalData { get; init; } = [];
}
