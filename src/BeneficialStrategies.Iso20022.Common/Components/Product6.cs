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
[IsoId("_h7v3oduLEeiB5uLfkg9ZJA")]
[DisplayName("Product")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Product6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Product6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Product6( System.String reqProductCode,ImpliedCurrencyAndAmount reqProductAmount )
    {
        ProductCode = reqProductCode;
        ProductAmount = reqProductAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the item inside the purchase transaction.
    /// </summary>
    [IsoId("_iGZocduLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPgduLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPg9uLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPhduLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPh9uLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPiduLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPi9uLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPjduLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPj9uLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPkduLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPk9uLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPlduLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPl9uLEeiB5uLfkg9ZJA")]
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
    [IsoId("_iGaPmduLEeiB5uLfkg9ZJA")]
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
    
    /// <summary>
    /// Commercial or distribution channel associated to the line item.
    /// </summary>
    [IsoId("_us2yoNuLEeiB5uLfkg9ZJA")]
    [DisplayName("Sale Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleChanl")]
    #endif
    [IsoXmlTag("SaleChanl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SaleChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleChannel { get; init; } 
    #else
    public System.String? SaleChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the line item.
    /// </summary>
    [IsoId("_yg2osNuLEeiB5uLfkg9ZJA")]
    [DisplayName("Additional Product Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPdctDesc")]
    #endif
    [IsoXmlTag("AddtlPdctDesc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AdditionalProductDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalProductDescription { get; init; } 
    #else
    public System.String? AdditionalProductDescription { get; set; } 
    #endif
    
    
    #nullable disable
    
}
