// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key exchange activity transaction.
/// </summary>
[IsoId("_LFWIoIv6EeumSPwlS1PkxQ")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction133
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction133 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction133( CardServiceType5Code reqKeyExchangeFunction,TransactionIdentification12 reqTransactionIdentification )
    {
        KeyExchangeFunction = reqKeyExchangeFunction;
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of key exchange function being performed.
    /// </summary>
    [IsoId("_LKnqMYv6EeumSPwlS1PkxQ")]
    [DisplayName("Key Exchange Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyXchgFctn")]
    #endif
    [IsoXmlTag("KeyXchgFctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardServiceType5Code KeyExchangeFunction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardServiceType5Code KeyExchangeFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardServiceType5Code KeyExchangeFunction { get; init; } 
    #else
    public CardServiceType5Code KeyExchangeFunction { get; set; } 
    #endif
    
    /// <summary>
    /// Other key exchange function being performed.
    /// </summary>
    [IsoId("_LKnqM4v6EeumSPwlS1PkxQ")]
    [DisplayName("Other Key Exchange Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrKeyXchgFctn")]
    #endif
    [IsoXmlTag("OthrKeyXchgFctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherKeyExchangeFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherKeyExchangeFunction { get; init; } 
    #else
    public System.String? OtherKeyExchangeFunction { get; set; } 
    #endif
    
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_uMxA98sJEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO8583MessageReasonCode? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? MessageReason { get; init; } 
    #else
    public string? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate reason to send a message.
    /// </summary>
    [IsoId("_LKnqN4v6EeumSPwlS1PkxQ")]
    [DisplayName("Alternate Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnMsgRsn")]
    #endif
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AlternateMessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternateMessageReason { get; init; } 
    #else
    public System.String? AlternateMessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_LKnqOYv6EeumSPwlS1PkxQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification12 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification12 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the type of key being exchanged.
    /// </summary>
    [IsoId("_LKnqO4v6EeumSPwlS1PkxQ")]
    [DisplayName("Key Exchange Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyXchgTp")]
    #endif
    [IsoXmlTag("KeyXchgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KeyType1Code? KeyExchangeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KeyType1Code? KeyExchangeType { get; init; } 
    #else
    public KeyType1Code? KeyExchangeType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of key being exchanged.
    /// </summary>
    [IsoId("_LKnqPYv6EeumSPwlS1PkxQ")]
    [DisplayName("Other Key Exchange Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrKeyXchgTp")]
    #endif
    [IsoXmlTag("OthrKeyXchgTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherKeyExchangeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherKeyExchangeType { get; init; } 
    #else
    public System.String? OtherKeyExchangeType { get; set; } 
    #endif
    
    /// <summary>
    /// Contains information pertaining to a key exchange. 
    /// ISO 8583 bit 96
    /// </summary>
    [IsoId("_LKnqP4v6EeumSPwlS1PkxQ")]
    [DisplayName("Key Exchange Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyXchgData")]
    #endif
    [IsoXmlTag("KeyXchgData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KeyExchangeData1? KeyExchangeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KeyExchangeData1? KeyExchangeData { get; init; } 
    #else
    public KeyExchangeData1? KeyExchangeData { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_LKnqQYv6EeumSPwlS1PkxQ")]
    [DisplayName("Additional Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFee")]
    #endif
    [IsoXmlTag("AddtlFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee2? AdditionalFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee2? AdditionalFee { get; init; } 
    #else
    public AdditionalFee2? AdditionalFee { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_LKnqQ4v6EeumSPwlS1PkxQ")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
