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
/// Configuration parameters to communicate with a host.
/// </summary>
[IsoId("_K86DOH1DEeCF8NjrBemJWQ_-1777383124")]
[DisplayName("Network Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetworkParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetworkParameters1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetworkParameters1( System.String reqPrimaryAddress,System.UInt64 reqPrimaryPortNumber )
    {
        PrimaryAddress = reqPrimaryAddress;
        PrimaryPortNumber = reqPrimaryPortNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// IP address or host name of the primary host.
    /// </summary>
    [IsoId("_K9D0MH1DEeCF8NjrBemJWQ_1112033591")]
    [DisplayName("Primary Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryAdr")]
    #endif
    [IsoXmlTag("PmryAdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PrimaryAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PrimaryAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PrimaryAddress { get; init; } 
    #else
    public System.String PrimaryAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Port number of the primary host.
    /// </summary>
    [IsoId("_K9D0MX1DEeCF8NjrBemJWQ_1665134773")]
    [DisplayName("Primary Port Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryPortNb")]
    #endif
    [IsoXmlTag("PmryPortNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber PrimaryPortNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 PrimaryPortNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 PrimaryPortNumber { get; init; } 
    #else
    public System.UInt64 PrimaryPortNumber { get; set; } 
    #endif
    
    /// <summary>
    /// IP address or host name of the secondary host.
    /// </summary>
    [IsoId("_K9D0Mn1DEeCF8NjrBemJWQ_386383236")]
    [DisplayName("Secondary Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryAdr")]
    #endif
    [IsoXmlTag("ScndryAdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecondaryAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondaryAddress { get; init; } 
    #else
    public System.String? SecondaryAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Port number of the secondary host.
    /// </summary>
    [IsoId("_K9D0M31DEeCF8NjrBemJWQ_-776733232")]
    [DisplayName("Secondary Port Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryPortNb")]
    #endif
    [IsoXmlTag("ScndryPortNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SecondaryPortNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SecondaryPortNumber { get; init; } 
    #else
    public System.UInt64? SecondaryPortNumber { get; set; } 
    #endif
    
    /// <summary>
    /// User name identifying the client.
    /// </summary>
    [IsoId("_K9D0NH1DEeCF8NjrBemJWQ_434071500")]
    [DisplayName("User Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrNm")]
    #endif
    [IsoXmlTag("UsrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? UserName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UserName { get; init; } 
    #else
    public System.String? UserName { get; set; } 
    #endif
    
    /// <summary>
    /// Password authenticating the client.
    /// </summary>
    [IsoId("_K9D0NX1DEeCF8NjrBemJWQ_73749005")]
    [DisplayName("Access Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccsCd")]
    #endif
    [IsoXmlTag("AccsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccessCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccessCode { get; init; } 
    #else
    public System.String? AccessCode { get; set; } 
    #endif
    
    /// <summary>
    /// Client certificate chain.
    /// </summary>
    [IsoId("_K9D0Nn1DEeCF8NjrBemJWQ_69300385")]
    [DisplayName("Client Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntCert")]
    #endif
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? ClientCertificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ClientCertificate { get; init; } 
    #else
    public System.Byte[]? ClientCertificate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
