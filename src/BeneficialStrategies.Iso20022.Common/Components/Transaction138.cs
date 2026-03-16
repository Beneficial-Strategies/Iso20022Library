// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement report transaction.
/// </summary>
[IsoId("_vEFHIYzGEeujJfnIQ4NlpQ")]
[DisplayName("Transaction")]
public record Transaction138
{
    /// <summary>
    /// Type of settlement report.
    /// </summary>
    [IsoId("_vJWBoYzGEeujJfnIQ4NlpQ")]
    [DisplayName("Settlement Report Type")]
    [IsoXmlTag("SttlmRptTp")]
    public required SettlementReportType1Code SettlementReportType { get; init; }

    /// <summary>
    /// Other type of settlement report in free text.
    /// </summary>
    [IsoId("_vJWosYzGEeujJfnIQ4NlpQ")]
    [DisplayName("Other Settlement Report Type")]
    [IsoXmlTag("OthrSttlmRptTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherSettlementReportType { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_J3GaB8sKEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ISO8583MessageReasonCode? MessageReason { get; init; }

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_vJWotYzGEeujJfnIQ4NlpQ")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AlternateMessageReason { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_vJWot4zGEeujJfnIQ4NlpQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification12 TransactionIdentification { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_vJWouYzGEeujJfnIQ4NlpQ")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; }

    /// <summary>
    /// Settlement totals of the report.
    /// </summary>
    [IsoId("_vJWou4zGEeujJfnIQ4NlpQ")]
    [DisplayName("Settlement Totals")]
    [IsoXmlTag("SttlmTtls")]
    public SettlementTotals2? SettlementTotals { get; init; }

    /// <summary>
    /// Contains the net funds transfer amount.
    /// </summary>
    [IsoId("_vJWovYzGEeujJfnIQ4NlpQ")]
    [DisplayName("Funds Transfer Amount")]
    [IsoXmlTag("FndsTrfAmt")]
    public Amount17? FundsTransferAmount { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_vJWov4zGEeujJfnIQ4NlpQ")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_vJWowYzGEeujJfnIQ4NlpQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
