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
/// Key exchange transaction.
/// </summary>
[IsoId("_lhtygXvREeS2PZh7wUMQog")]
[DisplayName("Card Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransaction14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransaction14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransaction14( CardServiceType3Code reqKeyExchangeType,System.DateTime reqInitiatorDateTime,ResponseType2 reqTransactionResponse )
    {
        KeyExchangeType = reqKeyExchangeType;
        InitiatorDateTime = reqInitiatorDateTime;
        TransactionResponse = reqTransactionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of key exchange.
    /// </summary>
    [IsoId("_Y34voISiEeScnfYByhaIWA")]
    [DisplayName("Key Exchange Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyXchgTp")]
    #endif
    [IsoXmlTag("KeyXchgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardServiceType3Code KeyExchangeType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardServiceType3Code KeyExchangeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardServiceType3Code KeyExchangeType { get; init; } 
    #else
    public CardServiceType3Code KeyExchangeType { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the transaction.
    /// </summary>
    [IsoId("_eXsAMISiEeScnfYByhaIWA")]
    [DisplayName("Initiator Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitrDtTm")]
    #endif
    [IsoXmlTag("InitrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime InitiatorDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime InitiatorDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime InitiatorDateTime { get; init; } 
    #else
    public System.DateTime InitiatorDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Key that has been verified.
    /// </summary>
    [IsoId("__taDUHvREeS2PZh7wUMQog")]
    [DisplayName("Key Verification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyVrfctn")]
    #endif
    [IsoXmlTag("KeyVrfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KEKIdentifier3? KeyVerification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KEKIdentifier3? KeyVerification { get; init; } 
    #else
    public KEKIdentifier3? KeyVerification { get; set; } 
    #endif
    
    /// <summary>
    /// Created key to be stored.
    /// </summary>
    [IsoId("_lurQd3vREeS2PZh7wUMQog")]
    [DisplayName("Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Key")]
    #endif
    [IsoXmlTag("Key")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKey6? Key { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKey6? Key { get; init; } 
    #else
    public CryptographicKey6? Key { get; set; } 
    #endif
    
    /// <summary>
    /// Response to the key exchange request.
    /// </summary>
    [IsoId("_mCKVQIO1EeSWSLYdc10LRg")]
    [DisplayName("Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRspn")]
    #endif
    [IsoXmlTag("TxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType2 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType2 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType2 TransactionResponse { get; init; } 
    #else
    public ResponseType2 TransactionResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
