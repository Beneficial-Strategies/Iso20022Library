// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data elements contained in the original message. ISO 8583:1987 bit 90 and ISO 8583 1993/2003 bit 56.
/// </summary>
[IsoId("_U0bLwSH4EfCkq6-p7S3J1Q")]
[DisplayName("Original Data Elements6")]
public record OriginalDataElements6
{
    /// <summary>
    /// Message class of the original message.
    /// </summary>
    [IsoId("_U2-JcSH4EfCkq6-p7S3J1Q")]
    [DisplayName("Message Class")]
    [IsoXmlTag("MsgClss")]
    public MessageClass2Code? MessageClass { get; init; }

    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_U2-JcyH4EfCkq6-p7S3J1Q")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public MessageFunction16Code? MessageFunction { get; init; }

    /// <summary>
    /// Code identifying the acquirer of the original message.
    /// </summary>
    [IsoId("_U2-JdSH4EfCkq6-p7S3J1Q")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public IsoMax11NumericText? AcquirerIdentification { get; init; }

    /// <summary>
    /// Code identifying the sender of the original message.
    /// </summary>
    [IsoId("_U2-JdyH4EfCkq6-p7S3J1Q")]
    [DisplayName("Sender Identification")]
    [IsoXmlTag("SndrId")]
    public IsoMax11NumericText? SenderIdentification { get; init; }

    /// <summary>
    /// Type of transaction associated with the main service.
    /// </summary>
    [IsoId("_U2-JeSH4EfCkq6-p7S3J1Q")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ISO8583TransactionTypeCode? TransactionType { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_U2-JgSH4EfCkq6-p7S3J1Q")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public OriginalTransactionIdentification2? TransactionIdentification { get; init; }

    /// <summary>
    /// Date and Time of currency conversion.
    /// </summary>
    [IsoId("_U2-JgyH4EfCkq6-p7S3J1Q")]
    [DisplayName("Conversion Date Time")]
    [IsoXmlTag("ConvsDtTm")]
    public DateTime2? ConversionDateTime { get; init; }

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_U2-JhSH4EfCkq6-p7S3J1Q")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public OriginalTransactionAmounts4? TransactionAmounts { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_U2-JhyH4EfCkq6-p7S3J1Q")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee4> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Detailed results of the processing, conforming to ISO 8583 Response codes list.
    /// </summary>
    [IsoId("_U2-JiSH4EfCkq6-p7S3J1Q")]
    [DisplayName("Response Code")]
    [IsoXmlTag("RspnCd")]
    public ISO8583ResponseCode? ResponseCode { get; init; }

    /// <summary>
    /// Value assigned by the entity when the transaction is approved.
    /// </summary>
    [IsoId("_U2-JkSH4EfCkq6-p7S3J1Q")]
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; }

    /// <summary>
    /// Deferred settlement date of the original transaction.
    /// </summary>
    [IsoId("_KW-qkCH6EfCkq6-p7S3J1Q")]
    [DisplayName("Deferred Settlement Date")]
    [IsoXmlTag("DfrrdSttlmDt")]
    public IsoISODate? DeferredSettlementDate { get; init; }
}
