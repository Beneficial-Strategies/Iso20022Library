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
/// Parameters to communicate with a host.
/// </summary>
[IsoId("_ghX0oQ0WEeqUVL7sB4m7NA")]
[DisplayName("Network Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetworkParameters7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Network addresses of the host.
    /// </summary>
    [IsoId("_gsopcQ0WEeqUVL7sB4m7NA")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    public ValueList<NetworkParameters9> Address { get; init; } = new ValueList<NetworkParameters9>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _gsopcQ0WEeqUVL7sB4m7NA
    
    /// <summary>
    /// User name identifying the client.
    /// </summary>
    [IsoId("_gsopcw0WEeqUVL7sB4m7NA")]
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
    [IsoId("_gsopdQ0WEeqUVL7sB4m7NA")]
    [DisplayName("Access Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccsCd")]
    #endif
    [IsoXmlTag("AccsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Binary? AccessCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? AccessCode { get; init; } 
    #else
    public System.Byte[]? AccessCode { get; set; } 
    #endif
    
    /// <summary>
    /// X.509 Certificate required to authenticate the server.
    /// </summary>
    [IsoId("_gsopdw0WEeqUVL7sB4m7NA")]
    [DisplayName("Server Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvrCert")]
    #endif
    [IsoXmlTag("SvrCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? ServerCertificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ServerCertificate { get; init; } 
    #else
    public System.Byte[]? ServerCertificate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the X.509 Certificates required to authenticate the server, for instance a digest of the certificate.
    /// </summary>
    [IsoId("_gsopeQ0WEeqUVL7sB4m7NA")]
    [DisplayName("Server Certificate Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvrCertIdr")]
    #endif
    [IsoXmlTag("SvrCertIdr")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? ServerCertificateIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ServerCertificateIdentifier { get; init; } 
    #else
    public System.Byte[]? ServerCertificateIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// X.509 Certificate required to authenticate the client.
    /// </summary>
    [IsoId("_gspQgQ0WEeqUVL7sB4m7NA")]
    [DisplayName("Client Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntCert")]
    #endif
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? ClientCertificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ClientCertificate { get; init; } 
    #else
    public System.Byte[]? ClientCertificate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the set of security elements to access the host.
    /// </summary>
    [IsoId("_gspQgw0WEeqUVL7sB4m7NA")]
    [DisplayName("Security Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyPrfl")]
    #endif
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecurityProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecurityProfile { get; init; } 
    #else
    public System.String? SecurityProfile { get; set; } 
    #endif
    
    
    #nullable disable
    
}
