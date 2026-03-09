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
/// Specifies the amount for a digital token identifier.
/// </summary>
[IsoId("_NxPbgANiEe2-vqzwMUAewg")]
[DisplayName("Digital Token Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DigitalTokenAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DigitalTokenAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DigitalTokenAmount1( System.UInt64 reqUnit )
    {
        Unit = reqUnit;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the digital token identifier (DTI).
    /// </summary>
    [IsoId("_XQvb0ANiEe2-vqzwMUAewg")]
    [DisplayName("Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Idr")]
    #endif
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.DTI2021Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDTI2021Identifier? Identifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identifier { get; init; } 
    #else
    public System.String? Identifier { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of digital tokens expressed as a number, for example, a number of blockchain tokens.
    /// </summary>
    [IsoId("_dmVr8QNiEe2-vqzwMUAewg")]
    [DisplayName("Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Unit")]
    #endif
    [IsoXmlTag("Unit")]
    [IsoSimpleType(IsoSimpleType.Max30DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax30DecimalNumber Unit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Unit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Unit { get; init; } 
    #else
    public System.UInt64 Unit { get; set; } 
    #endif
    
    /// <summary>
    /// Provides a description of the digital token identifier.
    /// </summary>
    [IsoId("_FY9sgANjEe2-vqzwMUAewg")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax30Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
