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
/// Security parameters of the ATM for the initiated key download.
/// </summary>
[IsoId("_dfs4IbToEeeQy4o2AayYHg")]
[DisplayName("Security Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityParameters9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Cryptographic key used to protect the key download.
    /// </summary>
    [IsoId("_doTagbToEeeQy4o2AayYHg")]
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
    [IsoId("_doTag7ToEeeQy4o2AayYHg")]
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
    
    /// <summary>
    /// Ordered certificate chain of the asymmetric key encryption key, starting with the ATM certificate.
    /// </summary>
    [IsoId("_doTahbToEeeQy4o2AayYHg")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Certificate { get; init; } 
    #else
    public System.Byte[]? Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Random value from the ATM to avoid message replay.
    /// </summary>
    [IsoId("_doTah7ToEeeQy4o2AayYHg")]
    [DisplayName("ATM Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMChllng")]
    #endif
    [IsoXmlTag("ATMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? ATMChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ATMChallenge { get; init; } 
    #else
    public System.Byte[]? ATMChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Requested key for downloading, depending on the key hierarchy used by the host.
    /// </summary>
    [IsoId("_doTaibToEeeQy4o2AayYHg")]
    [DisplayName("Requested Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdKey")]
    #endif
    [IsoXmlTag("ReqdKey")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RequestedKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequestedKey { get; init; } 
    #else
    public System.String? RequestedKey { get; set; } 
    #endif
    
    
    #nullable disable
    
}
