// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Data Elements4.
/// </summary>
[IsoId("_nt-iMZgXEe6OBt2eQPMPsQ")]
[DisplayName("Original Data Elements4")]
public record OriginalDataElements4
{
    /// <summary>
    /// Acquirer Identification.
    /// </summary>
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public IsoMax11NumericText? AcquirerIdentification { get; init; }

    /// <summary>
    /// Message Class.
    /// </summary>
    [DisplayName("Message Class")]
    [IsoXmlTag("MsgClss")]
    public MessageClass1Code? MessageClass { get; init; }

    /// <summary>
    /// Message Function.
    /// </summary>
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public MessageFunction16Code? MessageFunction { get; init; }

    /// <summary>
    /// Response Code.
    /// </summary>
    [DisplayName("Response Code")]
    [IsoXmlTag("RspnCd")]
    public ISO8583ResponseCode? ResponseCode { get; init; }

    /// <summary>
    /// Sender Identification.
    /// </summary>
    [DisplayName("Sender Identification")]
    [IsoXmlTag("SndrId")]
    public IsoMax11NumericText? SenderIdentification { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public OriginalTransactionIdentification1? TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction Type.
    /// </summary>
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ISO8583TransactionTypeCode? TransactionType { get; init; }
}
