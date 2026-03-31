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
[IsoId("_Q7nBgYdREeuBS50MFjViNw")]
[DisplayName("Transaction")]
public record Transaction154
{
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_IjBYd8sJEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined  in external code list.
    /// </summary>
    [IsoId("_RDCfM4dREeuBS50MFjViNw")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_RDCfNYdREeuBS50MFjViNw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification17 TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction amounts.
    /// </summary>
    [IsoId("_RDCfN4dREeuBS50MFjViNw")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts2 TransactionAmounts { get; init; }

    /// <summary>
    /// Data related to the dispute.
    /// </summary>
    [IsoId("_RDCfOYdREeuBS50MFjViNw")]
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public required DisputeData3 DisputeData { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_RDCfO4dREeuBS50MFjViNw")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee2> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Additional information related to the chargeback.
    /// </summary>
    [IsoId("_RDCfPYdREeuBS50MFjViNw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation20? AdditionalInformation { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_RDCfP4dREeuBS50MFjViNw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
