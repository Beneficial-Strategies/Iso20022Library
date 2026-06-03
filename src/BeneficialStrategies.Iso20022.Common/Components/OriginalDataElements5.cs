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
[IsoId("_CDI5QRUOEfC_aaedwHHlmw")]
[DisplayName("Original Data Elements5")]
public record OriginalDataElements5
{
    /// <summary>
    /// Message class of the original message.
    /// </summary>
    [IsoId("_CKgskRUOEfC_aaedwHHlmw")]
    [DisplayName("Message Class")]
    [IsoXmlTag("MsgClss")]
    public MessageClass2Code? MessageClass { get; init; }

    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_CKgskxUOEfC_aaedwHHlmw")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public MessageFunction16Code? MessageFunction { get; init; }

    /// <summary>
    /// Code identifying the acquirer of the original message.
    /// </summary>
    [IsoId("_CKgslRUOEfC_aaedwHHlmw")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public IsoMax11NumericText? AcquirerIdentification { get; init; }

    /// <summary>
    /// Code identifying the sender of the original message.
    /// </summary>
    [IsoId("_CKgslxUOEfC_aaedwHHlmw")]
    [DisplayName("Sender Identification")]
    [IsoXmlTag("SndrId")]
    public IsoMax11NumericText? SenderIdentification { get; init; }

    /// <summary>
    /// Type of transaction associated with the main service.
    /// </summary>
    [IsoId("_CKgsmRUOEfC_aaedwHHlmw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ISO8583TransactionTypeCode? TransactionType { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_CKgsoRUOEfC_aaedwHHlmw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public OriginalTransactionIdentification2? TransactionIdentification { get; init; }

    /// <summary>
    /// Detailed results of the processing, conforming to ISO 8583 Response codes list.
    /// </summary>
    [IsoId("_CKgsqRUOEfC_aaedwHHlmw")]
    [DisplayName("Response Code")]
    [IsoXmlTag("RspnCd")]
    public ISO8583ResponseCode? ResponseCode { get; init; }
}
