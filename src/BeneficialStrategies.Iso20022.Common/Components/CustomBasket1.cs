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
[IsoId("_EUYF4QFOEeqUa4noT3P56A")]
[DisplayName("Custom Basket")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomBasket1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomBasket1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomBasket1( System.String reqStructurer,System.String reqIdentification )
    {
        Structurer = reqStructurer;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the structurer of the customer basket.
    /// </summary>
    [IsoId("_lQQRIP5yEeqiEZtcZLwc3Q")]
    [DisplayName("Structurer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Strr")]
    #endif
    [IsoXmlTag("Strr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier Structurer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Structurer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Structurer { get; init; } 
    #else
    public System.String Structurer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the custom basket assigned by the structurer allowing to link the constituents of the basket of indexes.
    /// </summary>
    [IsoId("_EfWm0QFOEeqUa4noT3P56A")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax52Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the underliers that represent the constituents of a custom basket.
    /// </summary>
    [IsoId("_HI1KgQFOEeqUa4noT3P56A")]
    [DisplayName("Constituents")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnsttnts")]
    #endif
    [IsoXmlTag("Cnsttnts")]
    public ValueList<BasketConstituents1> Constituents { get; init; } = new ValueList<BasketConstituents1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _HI1KgQFOEeqUa4noT3P56A
    
    
    #nullable disable
    
}
