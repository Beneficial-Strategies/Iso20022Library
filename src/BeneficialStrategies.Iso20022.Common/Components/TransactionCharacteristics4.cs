// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Characteristics4.
/// </summary>
[IsoId("_fUJjYZBqEe6TWIDarRgYow")]
[DisplayName("Transaction Characteristics4")]
public record TransactionCharacteristics4
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Alternate Message Reason.
    /// </summary>
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public ValueList<Max256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Cancellation.
    /// </summary>
    [DisplayName("Cancellation")]
    [IsoXmlTag("Cxl")]
    public TrueFalseIndicator? Cancellation { get; init; }

    /// <summary>
    /// Fee Collection Cycle.
    /// </summary>
    [DisplayName("Fee Collection Cycle")]
    [IsoXmlTag("FeeColltnCycl")]
    public Exact1NumericText? FeeCollectionCycle { get; init; }

    /// <summary>
    /// Message Reason.
    /// </summary>
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Transaction Description.
    /// </summary>
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    public Max1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Transaction Sub Type.
    /// </summary>
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    public Max35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Transaction Type.
    /// </summary>
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ISO8583TransactionTypeCode? TransactionType { get; init; }
}
