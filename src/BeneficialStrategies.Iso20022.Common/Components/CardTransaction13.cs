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
[IsoId("_UCtJgXvHEeSCJdwgzb6SFw")]
[DisplayName("Card Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransaction13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransaction13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransaction13( CardServiceType3Code reqKeyExchangeType,System.DateTime reqInitiatorDateTime )
    {
        KeyExchangeType = reqKeyExchangeType;
        InitiatorDateTime = reqInitiatorDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of key exchange.
    /// </summary>
    [IsoId("_lk9QkHvNEeSCJdwgzb6SFw")]
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
    [IsoId("_3_FpkHvNEeSCJdwgzb6SFw")]
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
    /// Key that must be created and sent in the response, or that must be verified.
    /// </summary>
    [IsoId("_WvATgHvOEeSCJdwgzb6SFw")]
    [DisplayName("Requested Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdKey")]
    #endif
    [IsoXmlTag("ReqdKey")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KEKIdentifier3? RequestedKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KEKIdentifier3? RequestedKey { get; init; } 
    #else
    public KEKIdentifier3? RequestedKey { get; set; } 
    #endif
    
    /// <summary>
    /// Created key to be stored.
    /// </summary>
    [IsoId("_4_COMHvOEeSCJdwgzb6SFw")]
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
    [IsoId("_saSU8IO1EeSWSLYdc10LRg")]
    [DisplayName("Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRspn")]
    #endif
    [IsoXmlTag("TxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResponseType2? TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType2? TransactionResponse { get; init; } 
    #else
    public ResponseType2? TransactionResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
