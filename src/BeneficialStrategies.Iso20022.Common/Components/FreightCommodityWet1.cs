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
/// Defines commodity sub-product attributes of a freight derivative of type wet.
/// </summary>
[IsoId("_zyaAIFrcEeWN79Bl6BUd3g")]
[DisplayName("Freight Commodity Wet")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FreightCommodityWet1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FreightCommodityWet1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FreightCommodityWet1( AssetClassProductType4Code reqBaseProduct,AssetClassSubProductType32Code reqSubProduct )
    {
        BaseProduct = reqBaseProduct;
        SubProduct = reqSubProduct;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_4K64gFrcEeWN79Bl6BUd3g")]
    [DisplayName("Base Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BasePdct")]
    #endif
    [IsoXmlTag("BasePdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassProductType4Code BaseProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AssetClassProductType4Code BaseProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassProductType4Code BaseProduct { get; init; } 
    #else
    public AssetClassProductType4Code BaseProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_gTfT4FrdEeWN79Bl6BUd3g")]
    [DisplayName("Sub Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPdct")]
    #endif
    [IsoXmlTag("SubPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassSubProductType32Code SubProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AssetClassSubProductType32Code SubProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassSubProductType32Code SubProduct { get; init; } 
    #else
    public AssetClassSubProductType32Code SubProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    [IsoId("_xu1wcFrdEeWN79Bl6BUd3g")]
    [DisplayName("Additional Sub Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSubPdct")]
    #endif
    [IsoXmlTag("AddtlSubPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassDetailedSubProductType12Code? AdditionalSubProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassDetailedSubProductType12Code? AdditionalSubProduct { get; init; } 
    #else
    public AssetClassDetailedSubProductType12Code? AdditionalSubProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}
