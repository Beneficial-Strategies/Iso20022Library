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
[IsoId("__j2rMV5-EfCoP_h9uwd39Q")]
[DisplayName("Transaction Characteristics7")]
public record TransactionCharacteristics7
{
    /// <summary>
    /// Code that indicates the type of transaction being undertaken in accordance with ISO 8583, Transaction Type.
    /// </summary>
    [IsoId("__j2rNV5-EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ISO8583TransactionTypeCode? TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("__j2rOV5-EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Indicates the previous message is cancelled.
    /// </summary>
    [IsoId("__j2rPV5-EfCoP_h9uwd39Q")]
    [DisplayName("Cancellation")]
    [IsoXmlTag("Cxl")]
    public IsoTrueFalseIndicator? Cancellation { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// </summary>
    [IsoId("__j2rQV5-EfCoP_h9uwd39Q")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("__j2rRV5-EfCoP_h9uwd39Q")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Indicates the Fee Collection cycle.
    /// </summary>
    [IsoId("__j2rSV5-EfCoP_h9uwd39Q")]
    [DisplayName("Fee Collection Cycle")]
    [IsoXmlTag("FeeColltnCycle")]
    public IsoExact1NumericText? FeeCollectionCycle { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("__j2rTV5-EfCoP_h9uwd39Q")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("__j2rUV5-EfCoP_h9uwd39Q")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("__j2rVV5-EfCoP_h9uwd39Q")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("__j2rWV5-EfCoP_h9uwd39Q")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData22> LocalData { get; init; } = [];
}
