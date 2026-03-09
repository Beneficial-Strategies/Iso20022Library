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
/// Reference of the transaction, that is the underlying payment instruction or statement entry.
/// </summary>
[IsoId("_R-PXcdLnEeSDLevdaFPXHw")]
[DisplayName("Certificate Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CertificateReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CertificateReference1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CertificateReference1( CertificateIdentification1 reqIdentification,System.DateOnly reqDate )
    {
        Identification = reqIdentification;
        Date = reqDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the underlying payment instruction or statement entry.
    /// </summary>
    [IsoId("_ehnYcNLnEeSDLevdaFPXHw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CertificateIdentification1 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CertificateIdentification1 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificateIdentification1 Identification { get; init; } 
    #else
    public CertificateIdentification1 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the underlying payment instruction or statement entry.
    /// </summary>
    [IsoId("_iisoQNLnEeSDLevdaFPXHw")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly Date { get; init; } 
    #else
    public System.DateOnly Date { get; set; } 
    #endif
    
    
    #nullable disable
    
}
