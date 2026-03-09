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
/// Defines commodity sub-product attributes of an energy derivative of type electricity.
/// </summary>
[IsoId("_T2uWkU8SEe2PGo0mhYCh1g")]
[DisplayName("Energy Commodity Electricity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EnergyCommodityElectricity2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EnergyCommodityElectricity2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EnergyCommodityElectricity2( AssetClassProductType2Code reqBaseProduct )
    {
        BaseProduct = reqBaseProduct;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_T3lSMU8SEe2PGo0mhYCh1g")]
    [DisplayName("Base Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BasePdct")]
    #endif
    [IsoXmlTag("BasePdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassProductType2Code BaseProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AssetClassProductType2Code BaseProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassProductType2Code BaseProduct { get; init; } 
    #else
    public AssetClassProductType2Code BaseProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_T3lSM08SEe2PGo0mhYCh1g")]
    [DisplayName("Sub Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPdct")]
    #endif
    [IsoXmlTag("SubPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassSubProductType6Code? SubProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassSubProductType6Code? SubProduct { get; init; } 
    #else
    public AssetClassSubProductType6Code? SubProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    [IsoId("_T3lSNU8SEe2PGo0mhYCh1g")]
    [DisplayName("Additional Sub Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSubPdct")]
    #endif
    [IsoXmlTag("AddtlSubPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassDetailedSubProductType5Code? AdditionalSubProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassDetailedSubProductType5Code? AdditionalSubProduct { get; init; } 
    #else
    public AssetClassDetailedSubProductType5Code? AdditionalSubProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}
