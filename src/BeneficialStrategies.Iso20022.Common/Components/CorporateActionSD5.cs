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
/// Contains details about called certificates.
/// </summary>
[IsoId("_1VdexDL3EeKU9IrkkToqcw_-1325892976")]
[DisplayName("Corporate Action SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionSD5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionSD5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionSD5( System.String reqCertificateNumber,System.UInt64 reqCertificateCalledAmount )
    {
        CertificateNumber = reqCertificateNumber;
        CertificateCalledAmount = reqCertificateCalledAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification or serial number that is assigned and affixed by an issuer or transfer agent to each securities certificate.
    /// </summary>
    [IsoId("_1VdexTL3EeKU9IrkkToqcw_1892750447")]
    [DisplayName("Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertNb")]
    #endif
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText CertificateNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CertificateNumber { get; init; } 
    #else
    public System.String CertificateNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Principal amount (for debt issues) or number of shares (for equity issues) that has been called for redemption for a particular certificate number.
    /// </summary>
    [IsoId("_1VmosDL3EeKU9IrkkToqcw_1945798532")]
    [DisplayName("Certificate Called Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertClldAmt")]
    #endif
    [IsoXmlTag("CertClldAmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber CertificateCalledAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 CertificateCalledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 CertificateCalledAmount { get; init; } 
    #else
    public System.UInt64 CertificateCalledAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
