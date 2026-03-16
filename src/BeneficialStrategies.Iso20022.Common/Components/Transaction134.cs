// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Network management transaction.
/// </summary>
[IsoId("_xpB0YYv7EeumSPwlS1PkxQ")]
[DisplayName("Transaction")]
public record Transaction134
{
    /// <summary>
    /// Type of network management service.
    /// ISO 8583:87/93 bit 24
    /// ISO 8583:2003 bit 70
    /// </summary>
    [IsoId("_xuMBMYv7EeumSPwlS1PkxQ")]
    [DisplayName("Network Management Type")]
    [IsoXmlTag("NtwkMgmtTp")]
    public NetworkManagementType1Code? NetworkManagementType { get; init; }

    /// <summary>
    /// Other type of network management in free text.
    /// </summary>
    [IsoId("_xuMBM4v7EeumSPwlS1PkxQ")]
    [DisplayName("Other Network Management Type")]
    [IsoXmlTag("OthrNtwkMgmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherNetworkManagementType { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_8-H8d8sJEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ISO8583MessageReasonCode? MessageReason { get; init; }

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_xuMBN4v7EeumSPwlS1PkxQ")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AlternateMessageReason { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_xuMBOYv7EeumSPwlS1PkxQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification12 TransactionIdentification { get; init; }

    /// <summary>
    /// Number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_xuMBO4v7EeumSPwlS1PkxQ")]
    [DisplayName("Number Of Messages")]
    [IsoXmlTag("NbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfMessages { get; init; }

    /// <summary>
    /// Maximum number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_xuMBPYv7EeumSPwlS1PkxQ")]
    [DisplayName("Maximum Number Of Messages")]
    [IsoXmlTag("MaxNbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumberOfMessages { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_xuMBP4v7EeumSPwlS1PkxQ")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; }

    /// <summary>
    /// Additional information pertaining to the network management type or function being performed.
    /// </summary>
    [IsoId("_xuMBQYv7EeumSPwlS1PkxQ")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_xuMBQ4v7EeumSPwlS1PkxQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
