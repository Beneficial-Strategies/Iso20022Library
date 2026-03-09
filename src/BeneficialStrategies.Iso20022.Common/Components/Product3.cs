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
/// Purchased item.
/// </summary>
[IsoId("_zAYo0Y-LEeWGMsAOtoswqg")]
[DisplayName("Product")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Product3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Product3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Product3( System.String reqProductCode,ImpliedCurrencyAndAmount reqProductAmount )
    {
        ProductCode = reqProductCode;
        ProductAmount = reqProductAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the item inside the purchase transaction.
    /// </summary>
    [IsoId("__WDIgI-MEeWGMsAOtoswqg")]
    [DisplayName("Item Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmId")]
    #endif
    [IsoXmlTag("ItmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ItemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ItemIdentification { get; init; } 
    #else
    public System.String? ItemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_zRqmEY-LEeWGMsAOtoswqg")]
    [DisplayName("Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCd")]
    #endif
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text ProductCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProductCode { get; init; } 
    #else
    public System.String ProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Additional product code related to the product.
    /// </summary>
    [IsoId("_8KYRIJVHEeWu36UkS2TkoQ")]
    [DisplayName("Additional Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPdctCd")]
    #endif
    [IsoXmlTag("AddtlPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalProductCode { get; init; } 
    #else
    public System.String? AdditionalProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_zRqmE4-LEeWGMsAOtoswqg")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure6Code? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure6Code? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure6Code? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Product quantity.
    /// </summary>
    [IsoId("_zRqmFY-LEeWGMsAOtoswqg")]
    [DisplayName("Product Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctQty")]
    #endif
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ProductQuantity { get; init; } 
    #else
    public System.UInt64? ProductQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Price per unit of product.
    /// </summary>
    [IsoId("_zRqmF4-LEeWGMsAOtoswqg")]
    [DisplayName("Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPric")]
    #endif
    [IsoXmlTag("UnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Sign of the unit price.
    /// </summary>
    [IsoId("_Fgg6EJVIEeWu36UkS2TkoQ")]
    [DisplayName("Unit Price Sign")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPricSgn")]
    #endif
    [IsoXmlTag("UnitPricSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPlusOrMinusIndicator? UnitPriceSign { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnitPriceSign { get; init; } 
    #else
    public System.String? UnitPriceSign { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of purchased product.
    /// </summary>
    [IsoId("_zRqmGY-LEeWGMsAOtoswqg")]
    [DisplayName("Product Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctAmt")]
    #endif
    [IsoXmlTag("PdctAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount ProductAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount ProductAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount ProductAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount ProductAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Sign of the product amount.
    /// </summary>
    [IsoId("_Ku5DcJVIEeWu36UkS2TkoQ")]
    [DisplayName("Product Amount Sign")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctAmtSgn")]
    #endif
    [IsoXmlTag("PdctAmtSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPlusOrMinusIndicator? ProductAmountSign { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductAmountSign { get; init; } 
    #else
    public System.String? ProductAmountSign { get; set; } 
    #endif
    
    /// <summary>
    /// Value added tax amount of the item included in the product amount.
    /// </summary>
    [IsoId("_PtY9wJVIEeWu36UkS2TkoQ")]
    [DisplayName("Value Added Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValAddedTax")]
    #endif
    [IsoXmlTag("ValAddedTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? ValueAddedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? ValueAddedTax { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? ValueAddedTax { get; set; } 
    #endif
    
    /// <summary>
    /// Information on tax paid on the product.
    /// </summary>
    [IsoId("_zRqmG4-LEeWGMsAOtoswqg")]
    [DisplayName("Tax Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTp")]
    #endif
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TaxType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxType { get; init; } 
    #else
    public System.String? TaxType { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the product or item.
    /// </summary>
    [IsoId("_zRqmHY-LEeWGMsAOtoswqg")]
    [DisplayName("Product Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctDesc")]
    #endif
    [IsoXmlTag("PdctDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ProductDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductDescription { get; init; } 
    #else
    public System.String? ProductDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the delivery of the item, for instance pump number or parking bay.
    /// </summary>
    [IsoId("_zMVksI-MEeWGMsAOtoswqg")]
    [DisplayName("Delivery Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryLctn")]
    #endif
    [IsoXmlTag("DlvryLctn")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? DeliveryLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeliveryLocation { get; init; } 
    #else
    public System.String? DeliveryLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Identify the method of delivery or distribution of the item.
    /// </summary>
    [IsoId("_oiwfYJVJEeWu36UkS2TkoQ")]
    [DisplayName("Delivery Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrySvc")]
    #endif
    [IsoXmlTag("DlvrySvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AttendanceContext2Code? DeliveryService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AttendanceContext2Code? DeliveryService { get; init; } 
    #else
    public AttendanceContext2Code? DeliveryService { get; set; } 
    #endif
    
    
    #nullable disable
    
}
