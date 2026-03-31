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
[IsoId("_fmsTgYv_EeuC5632vxUfGg")]
[DisplayName("Transaction")]
public record Transaction136
{
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_GImvB8sKEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_frgiE4v_EeuC5632vxUfGg")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_frgiFYv_EeuC5632vxUfGg")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_frgiF4v_EeuC5632vxUfGg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification18 TransactionIdentification { get; init; }

    /// <summary>
    /// Data related to the dispute.
    /// </summary>
    [IsoId("_rtWXcDD_EeyjbpgZW6G1Fg")]
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public ValueList<DisputeData3> DisputeData { get; init; } = [];

    /// <summary>
    /// Fulfilment request instructions for the retrieval.
    /// </summary>
    [IsoId("_frgiG4v_EeuC5632vxUfGg")]
    [DisplayName("Retrieval Fulfilment Instructions")]
    [IsoXmlTag("RtrvlFlfmtInstrs")]
    public ValueList<RetrievalFulfilmentInstructions2> RetrievalFulfilmentInstructions { get; init; } =
        [];

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_frgiHYv_EeuC5632vxUfGg")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee2> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_frgiH4v_EeuC5632vxUfGg")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_frgiIYv_EeuC5632vxUfGg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
