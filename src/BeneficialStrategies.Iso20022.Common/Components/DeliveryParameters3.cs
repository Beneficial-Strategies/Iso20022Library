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
/// Parameters of a physical delivery.
/// </summary>
[IsoId("_T6YI7tp-Ed-ak6NoX_4Aeg_152223563")]
[DisplayName("Delivery Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliveryParameters3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeliveryParameters3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeliveryParameters3( NameAndAddress4 reqAddress )
    {
        Address = reqAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Address for physical delivery.
    /// </summary>
    [IsoId("_T6hS0Np-Ed-ak6NoX_4Aeg_152223589")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NameAndAddress4 Address { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NameAndAddress4 Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress4 Address { get; init; } 
    #else
    public NameAndAddress4 Address { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate representing a security that is delivered.
    /// </summary>
    [IsoId("_T6hS0dp-Ed-ak6NoX_4Aeg_152223605")]
    [DisplayName("Issued Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssdCertNb")]
    #endif
    [IsoXmlTag("IssdCertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IssuedCertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuedCertificateNumber { get; init; } 
    #else
    public System.String? IssuedCertificateNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
