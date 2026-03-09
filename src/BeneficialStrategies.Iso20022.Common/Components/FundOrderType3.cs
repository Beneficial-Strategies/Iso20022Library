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
/// Specifies the category of the investment fund order.
/// </summary>
[IsoId("_TSu6Etp-Ed-ak6NoX_4Aeg_1141291305")]
[DisplayName("Fund Order Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundOrderType3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundOrderType3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundOrderType3( FundOrderType4Code reqOrderType,System.String reqExtendedOrderType )
    {
        OrderType = reqOrderType;
        ExtendedOrderType = reqExtendedOrderType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_TSu6E9p-Ed-ak6NoX_4Aeg_1141291307")]
    [DisplayName("Order Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrTp")]
    #endif
    [IsoXmlTag("OrdrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FundOrderType4Code OrderType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FundOrderType4Code OrderType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundOrderType4Code OrderType { get; init; } 
    #else
    public FundOrderType4Code OrderType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_TSu6FNp-Ed-ak6NoX_4Aeg_1141291995")]
    [DisplayName("Extended Order Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedOrdrTp")]
    #endif
    [IsoXmlTag("XtndedOrdrTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedOrderType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedOrderType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedOrderType { get; init; } 
    #else
    public System.String ExtendedOrderType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
