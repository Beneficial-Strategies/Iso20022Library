// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key exchange activity transaction.
/// </summary>
[IsoId("_LFWIoIv6EeumSPwlS1PkxQ")]
[DisplayName("Transaction")]
public partial record Transaction133
{
    #nullable enable
    
    /// <summary>
    /// Type of key exchange function being performed.
    /// </summary>
    [IsoId("_LKnqMYv6EeumSPwlS1PkxQ")]
    [DisplayName("Key Exchange Function")]
    [IsoXmlTag("KeyXchgFctn")]
    public required CardServiceType5Code KeyExchangeFunction { get; init; } 
    
    /// <summary>
    /// Other key exchange function being performed.
    /// </summary>
    [IsoId("_LKnqM4v6EeumSPwlS1PkxQ")]
    [DisplayName("Other Key Exchange Function")]
    [IsoXmlTag("OthrKeyXchgFctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherKeyExchangeFunction { get; init; } 
    
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_uMxA98sJEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ISO8583MessageReasonCode? MessageReason { get; init; } 
    
    /// <summary>
    /// Alternate reason to send a message.
    /// </summary>
    [IsoId("_LKnqN4v6EeumSPwlS1PkxQ")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AlternateMessageReason { get; init; } 
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_LKnqOYv6EeumSPwlS1PkxQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Defines the type of key being exchanged.
    /// </summary>
    [IsoId("_LKnqO4v6EeumSPwlS1PkxQ")]
    [DisplayName("Key Exchange Type")]
    [IsoXmlTag("KeyXchgTp")]
    public KeyType1Code? KeyExchangeType { get; init; } 
    
    /// <summary>
    /// Other type of key being exchanged.
    /// </summary>
    [IsoId("_LKnqPYv6EeumSPwlS1PkxQ")]
    [DisplayName("Other Key Exchange Type")]
    [IsoXmlTag("OthrKeyXchgTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherKeyExchangeType { get; init; } 
    
    /// <summary>
    /// Contains information pertaining to a key exchange. 
    /// ISO 8583 bit 96
    /// </summary>
    [IsoId("_LKnqP4v6EeumSPwlS1PkxQ")]
    [DisplayName("Key Exchange Data")]
    [IsoXmlTag("KeyXchgData")]
    public KeyExchangeData1? KeyExchangeData { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_LKnqQYv6EeumSPwlS1PkxQ")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_LKnqQ4v6EeumSPwlS1PkxQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
