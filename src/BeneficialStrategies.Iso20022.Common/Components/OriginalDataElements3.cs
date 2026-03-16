// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Data Elements3.
/// </summary>
[IsoId("_GCyNcW3nEe6dwbOqHXrHWg")]
[DisplayName("Original Data Elements3")]
public partial record OriginalDataElements3
{
    #nullable enable

    /// <summary>
    /// Acquirer Identification.
    /// </summary>
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public IsoMax11NumericText? AcquirerIdentification { get; init; } 

    /// <summary>
    /// Additional Fee.
    /// </summary>
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee3> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Approval Code.
    /// </summary>
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; } 

    /// <summary>
    /// Conversion Date Time.
    /// </summary>
    [DisplayName("Conversion Date Time")]
    [IsoXmlTag("ConvsDtTm")]
    public DateTime2? ConversionDateTime { get; init; } 

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
    /// Transaction Amounts.
    /// </summary>
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public OriginalTransactionAmounts3? TransactionAmounts { get; init; } 

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

    
    #nullable disable
    
}
