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
/// Information used to identify a product.
/// </summary>
[IsoId("_TRPsXdp-Ed-ak6NoX_4Aeg_-1876396278")]
[DisplayName("Product Identifier")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProductIdentifier2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProductIdentifier2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProductIdentifier2( ProductIdentifier2Code reqType,System.String reqIdentifier )
    {
        Type = reqType;
        Identifier = reqIdentifier;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of product identifier by means of a code.
    /// </summary>
    [IsoId("_TRZdUNp-Ed-ak6NoX_4Aeg_-1876396252")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProductIdentifier2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProductIdentifier2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductIdentifier2Code Type { get; init; } 
    #else
    public ProductIdentifier2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the product identifier.
    /// </summary>
    [IsoId("_TRZdUdp-Ed-ak6NoX_4Aeg_-1876396236")]
    [DisplayName("Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Idr")]
    #endif
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identifier { get; init; } 
    #else
    public System.String Identifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
