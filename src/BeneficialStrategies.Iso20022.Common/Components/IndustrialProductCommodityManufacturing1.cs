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
/// Defines commodity sub-product attributes of an industrial product derivative of type manufacturing.
/// </summary>
[IsoId("_P1GugFrgEeWN79Bl6BUd3g")]
[DisplayName("Industrial Product Commodity Manufacturing")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndustrialProductCommodityManufacturing1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndustrialProductCommodityManufacturing1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndustrialProductCommodityManufacturing1( AssetClassProductType6Code reqBaseProduct )
    {
        BaseProduct = reqBaseProduct;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_U-lw0FrgEeWN79Bl6BUd3g")]
    [DisplayName("Base Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BasePdct")]
    #endif
    [IsoXmlTag("BasePdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassProductType6Code BaseProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AssetClassProductType6Code BaseProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassProductType6Code BaseProduct { get; init; } 
    #else
    public AssetClassProductType6Code BaseProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_mT1lYFrgEeWN79Bl6BUd3g")]
    [DisplayName("Sub Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPdct")]
    #endif
    [IsoXmlTag("SubPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassSubProductType34Code? SubProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassSubProductType34Code? SubProduct { get; init; } 
    #else
    public AssetClassSubProductType34Code? SubProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}
