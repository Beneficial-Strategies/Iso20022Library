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
/// Goods or services that are part of a commercial trade agreement.
/// </summary>
[IsoId("_SpnEn9p-Ed-ak6NoX_4Aeg_-1297466325")]
[DisplayName("Transported Goods")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportedGoods1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportedGoods1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportedGoods1( DocumentIdentification7 reqPurchaseOrderReference )
    {
        PurchaseOrderReference = reqPurchaseOrderReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_SpnEoNp-Ed-ak6NoX_4Aeg_-2040138462")]
    [DisplayName("Purchase Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsOrdrRef")]
    #endif
    [IsoXmlTag("PurchsOrdrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #else
    public DocumentIdentification7 PurchaseOrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_Spw1kNp-Ed-ak6NoX_4Aeg_-1205114783")]
    [DisplayName("Goods Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GoodsDesc")]
    #endif
    [IsoXmlTag("GoodsDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? GoodsDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GoodsDescription { get; init; } 
    #else
    public System.String? GoodsDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_Spw1kdp-Ed-ak6NoX_4Aeg_-1285621274")]
    [DisplayName("Buyer Defined Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrDfndInf")]
    #endif
    [IsoXmlTag("BuyrDfndInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    #else
    public UserDefinedInformation1? BuyerDefinedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_Spw1ktp-Ed-ak6NoX_4Aeg_-1295781121")]
    [DisplayName("Seller Defined Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrDfndInf")]
    #endif
    [IsoXmlTag("SellrDfndInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    #else
    public UserDefinedInformation1? SellerDefinedInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
