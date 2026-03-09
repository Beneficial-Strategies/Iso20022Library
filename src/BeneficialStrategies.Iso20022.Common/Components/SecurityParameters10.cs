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
/// Security parameters of the host downloading the key.
/// </summary>
[IsoId("_usm58bTxEeeQy4o2AayYHg")]
[DisplayName("Security Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityParameters10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Random value from the host.
    /// </summary>
    [IsoId("_u1uZsbTxEeeQy4o2AayYHg")]
    [DisplayName("Host Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstChllng")]
    #endif
    [IsoXmlTag("HstChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? HostChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? HostChallenge { get; init; } 
    #else
    public System.Byte[]? HostChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Cryptographic key used to store in the ATM.
    /// </summary>
    [IsoId("_u1uZs7TxEeeQy4o2AayYHg")]
    [DisplayName("Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Key")]
    #endif
    [IsoXmlTag("Key")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKey12? Key { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKey12? Key { get; init; } 
    #else
    public CryptographicKey12? Key { get; set; } 
    #endif
    
    /// <summary>
    /// Element containing the signature.
    /// </summary>
    [IsoId("_u1uZtbTxEeeQy4o2AayYHg")]
    [DisplayName("Signature Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgntrChc")]
    #endif
    [IsoXmlTag("SgntrChc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMSignature2Choice_? SignatureChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSignature2Choice_? SignatureChoice { get; init; } 
    #else
    public ATMSignature2Choice_? SignatureChoice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
