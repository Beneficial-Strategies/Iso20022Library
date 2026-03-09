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
/// The discount amount that is attached to an item as a rebate.
/// </summary>
[IsoId("_ifYlkNxOEeioifFt1dhnJA")]
[DisplayName("Sale Item Rebate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleItemRebate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SaleItemRebate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SaleItemRebate1( Product6 reqSaleItem )
    {
        SaleItem = reqSaleItem;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data of the Sale item.
    /// </summary>
    [IsoId("_qEsKENxOEeioifFt1dhnJA")]
    [DisplayName("Sale Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleItm")]
    #endif
    [IsoXmlTag("SaleItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Product6 SaleItem { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Product6 SaleItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product6 SaleItem { get; init; } 
    #else
    public Product6 SaleItem { get; set; } 
    #endif
    
    /// <summary>
    /// Short text to qualify a rebate on an line item.
    /// </summary>
    [IsoId("_uhRqINxOEeioifFt1dhnJA")]
    [DisplayName("Rebate Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RbtLabl")]
    #endif
    [IsoXmlTag("RbtLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RebateLabel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RebateLabel { get; init; } 
    #else
    public System.String? RebateLabel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
