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
/// Identifies the implementation specification to which the ISO 20022 message conforms.
/// </summary>
[IsoId("_6Pu8gMieEei73Ywzx0CAAg")]
[DisplayName("Implementation Specification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ImplementationSpecification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ImplementationSpecification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ImplementationSpecification1( System.String reqRegistry,System.String reqIdentification )
    {
        Registry = reqRegistry;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the implementation specification registry in which the implementation specification of the ISO 20022 message is maintained.
    /// For example, &quot;MyStandards&quot;.
    /// </summary>
    [IsoId("_Dr2RoMifEei73Ywzx0CAAg")]
    [DisplayName("Registry")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Regy")]
    #endif
    [IsoXmlTag("Regy")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Registry { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Registry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Registry { get; init; } 
    #else
    public System.String Registry { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier which unambiguously identifies, within the implementation specification registry, the implementation specification to which the ISO 20022 message is compliant. This can be done via a URN. It can also contain a version number or date.
    /// For instance, &quot;2018-01-01 – Version 2&quot; or &quot;urn:uuid:6e8bc430-9c3a-11d9-9669-0800200c9a66&quot;.
    /// </summary>
    [IsoId("_GKeQMMifEei73Ywzx0CAAg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2048Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
