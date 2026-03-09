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
[IsoId("_ZtxdcVWXEeeiG_nL4vgKnQ")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction100
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction100 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction100( CardServiceType5Code reqKeyExchangeFunction,TransactionIdentification12 reqTransactionIdentification )
    {
        KeyExchangeFunction = reqKeyExchangeFunction;
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of key exchange function being performed.
    /// </summary>
    [IsoId("_Z5FVkVWXEeeiG_nL4vgKnQ")]
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
    [IsoId("_Z5FVk1WXEeeiG_nL4vgKnQ")]
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
    /// Reason to send a key exchange message.
    /// ISO 8583:1993/2003 bit 25.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_Z5FVmVWXEeeiG_nL4vgKnQ")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4NumericText? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageReason { get; init; } 
    #else
    public System.String? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate reason to send a message.
    /// </summary>
    [IsoId("_Z5FVm1WXEeeiG_nL4vgKnQ")]
    [DisplayName("Alternate Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnMsgRsn")]
    #endif
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternateMessageReason { get; init; } 
    #else
    public System.String? AlternateMessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_Z5FVl1WXEeeiG_nL4vgKnQ")]
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
    [IsoId("__lvs8P8aEeic54G0fOJNMg")]
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
    [IsoId("_4oO2Uf8cEeic54G0fOJNMg")]
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
    [IsoId("_JiNvMf7xEeic54G0fOJNMg")]
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
    [IsoId("_55egQvF9EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFees")]
    #endif
    [IsoXmlTag("AddtlFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee1? AdditionalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee1? AdditionalFees { get; init; } 
    #else
    public AdditionalFee1? AdditionalFees { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_dWsFMRqnEeqH1IQNpbVpEw")]
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
