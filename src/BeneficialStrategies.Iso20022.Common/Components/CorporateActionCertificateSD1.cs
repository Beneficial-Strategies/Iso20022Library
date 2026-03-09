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
/// Certificate information provided for a given corporate action instruction.
/// </summary>
[IsoId("_OBTl0MViEeeprYdSN88o0Q")]
[DisplayName("Corporate Action Certificate SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionCertificateSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionCertificateSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionCertificateSD1( System.String reqCertificateNumber )
    {
        CertificateNumber = reqCertificateNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification or serial number that is assigned and affixed by an issuer or transfer agent to each securities certificate.
    /// </summary>
    [IsoId("_HsduNMVjEeeprYdSN88o0Q")]
    [DisplayName("Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertNb")]
    #endif
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max15AlphaNumericText)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15AlphaNumericText CertificateNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CertificateNumber { get; init; } 
    #else
    public System.String CertificateNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Additional identifier assigned by DTC.
    /// </summary>
    [IsoId("_kj2zcMVnEeeprYdSN88o0Q")]
    [DisplayName("Certificate Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertSeqNb")]
    #endif
    [IsoXmlTag("CertSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max15AlphaNumericText)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15AlphaNumericText? CertificateSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificateSequenceNumber { get; init; } 
    #else
    public System.String? CertificateSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Registration name of the beneficial holder.
    /// </summary>
    [IsoId("_uY8pQMVnEeeprYdSN88o0Q")]
    [DisplayName("Certificate Registration Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertRegnNm")]
    #endif
    [IsoXmlTag("CertRegnNm")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax30Text? CertificateRegistrationName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificateRegistrationName { get; init; } 
    #else
    public System.String? CertificateRegistrationName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
