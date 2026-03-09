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
/// Identification of constituents for a basket of indexes.
/// </summary>
[IsoId("_muRycVo2Ee23K4GXSpBSeg")]
[DisplayName("Custom Basket")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomBasket4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the structurer of the customer basket.
    /// </summary>
    [IsoId("_mv1RoVo2Ee23K4GXSpBSeg")]
    [DisplayName("Structurer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Strr")]
    #endif
    [IsoXmlTag("Strr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? Structurer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Structurer { get; init; } 
    #else
    public System.String? Structurer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the custom basket assigned by the structurer allowing to link the constituents of the basket of indexes.
    /// </summary>
    [IsoId("_mv1Ro1o2Ee23K4GXSpBSeg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the underliers that represent the constituents of a custom basket.
    /// </summary>
    [IsoId("_mv1RpVo2Ee23K4GXSpBSeg")]
    [DisplayName("Constituents")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnsttnts")]
    #endif
    [IsoXmlTag("Cnsttnts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BasketConstituents3? Constituents { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BasketConstituents3? Constituents { get; init; } 
    #else
    public BasketConstituents3? Constituents { get; set; } 
    #endif
    
    
    #nullable disable
    
}
