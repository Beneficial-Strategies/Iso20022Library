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
[IsoId("_Sx2PAefIEeKNfc-Rw_dPYg")]
[DisplayName("Line Item Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItemDetails10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LineItemDetails10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LineItemDetails10( System.String reqLineItemIdentification,Quantity9 reqQuantity,CurrencyAndAmount reqTotalAmount )
    {
        LineItemIdentification = reqLineItemIdentification;
        Quantity = reqQuantity;
        TotalAmount = reqTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a line item.
    /// </summary>
    [IsoId("_TPud0efIEeKNfc-Rw_dPYg")]
    [DisplayName("Line Item Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItmId")]
    #endif
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text LineItemIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LineItemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LineItemIdentification { get; init; } 
    #else
    public System.String LineItemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the quantity of goods on a line in a trade transaction.
    /// </summary>
    [IsoId("_TPud0-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity9 Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity9 Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity9 Quantity { get; init; } 
    #else
    public Quantity9 Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Variance allowed in the quantity of goods.
    /// </summary>
    [IsoId("_TPud1efIEeKNfc-Rw_dPYg")]
    [DisplayName("Quantity Tolerance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyTlrnce")]
    #endif
    [IsoXmlTag("QtyTlrnce")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PercentageTolerance1? QuantityTolerance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PercentageTolerance1? QuantityTolerance { get; init; } 
    #else
    public PercentageTolerance1? QuantityTolerance { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_TPud1-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPric")]
    #endif
    [IsoXmlTag("UnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitPrice18? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPrice18? UnitPrice { get; init; } 
    #else
    public UnitPrice18? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Variance allowed on a price.
    /// </summary>
    [IsoId("_TPud2efIEeKNfc-Rw_dPYg")]
    [DisplayName("Price Tolerance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricTlrnce")]
    #endif
    [IsoXmlTag("PricTlrnce")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PercentageTolerance1? PriceTolerance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PercentageTolerance1? PriceTolerance { get; init; } 
    #else
    public PercentageTolerance1? PriceTolerance { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    [IsoId("_TPud2-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Product Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctNm")]
    #endif
    [IsoXmlTag("PdctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ProductName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductName { get; init; } 
    #else
    public System.String? ProductName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the product of the corresponding line item.
    /// </summary>
    [IsoId("_TPud3efIEeKNfc-Rw_dPYg")]
    [DisplayName("Product Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctIdr")]
    #endif
    [IsoXmlTag("PdctIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductIdentifier2Choice_? ProductIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductIdentifier2Choice_? ProductIdentifier { get; init; } 
    #else
    public ProductIdentifier2Choice_? ProductIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the characteristics of a product.
    /// </summary>
    [IsoId("_TPud3-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Product Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctChrtcs")]
    #endif
    [IsoXmlTag("PdctChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductCharacteristics1Choice_? ProductCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductCharacteristics1Choice_? ProductCharacteristics { get; init; } 
    #else
    public ProductCharacteristics1Choice_? ProductCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the category of product.
    /// </summary>
    [IsoId("_TPud4efIEeKNfc-Rw_dPYg")]
    [DisplayName("Product Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCtgy")]
    #endif
    [IsoXmlTag("PdctCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductCategory1Choice_? ProductCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductCategory1Choice_? ProductCategory { get; init; } 
    #else
    public ProductCategory1Choice_? ProductCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Country from which the product originates.
    /// </summary>
    [IsoId("_TPud4-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Product Origin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctOrgn")]
    #endif
    [IsoXmlTag("PdctOrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? ProductOrigin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ProductOrigin { get; init; } 
    #else
    public string? ProductOrigin { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the shipment schedule for the goods.
    /// </summary>
    [IsoId("_TPud5efIEeKNfc-Rw_dPYg")]
    [DisplayName("Shipment Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipmntSchdl")]
    #endif
    [IsoXmlTag("ShipmntSchdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; } 
    #else
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_TPud5-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Routing Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtgSummry")]
    #endif
    [IsoXmlTag("RtgSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportMeans5? RoutingSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportMeans5? RoutingSummary { get; init; } 
    #else
    public TransportMeans5? RoutingSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_TPvE4-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adjstmnt")]
    #endif
    [IsoXmlTag("Adjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment7? Adjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment7? Adjustment { get; init; } 
    #else
    public Adjustment7? Adjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_TPvE5efIEeKNfc-Rw_dPYg")]
    [DisplayName("Freight Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrghtChrgs")]
    #endif
    [IsoXmlTag("FrghtChrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge24? FreightCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge24? FreightCharges { get; init; } 
    #else
    public Charge24? FreightCharges { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_TPvE5-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax23? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax23? Tax { get; init; } 
    #else
    public Tax23? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the line item after adjustments have been applied.
    /// </summary>
    [IsoId("_TPvE6efIEeKNfc-Rw_dPYg")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount TotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount TotalAmount { get; init; } 
    #else
    public CurrencyAndAmount TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    [IsoId("_TPvE4efIEeKNfc-Rw_dPYg")]
    [DisplayName("Incoterms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incotrms")]
    #endif
    [IsoXmlTag("Incotrms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Incoterms4? Incoterms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms4? Incoterms { get; init; } 
    #else
    public Incoterms4? Incoterms { get; set; } 
    #endif
    
    
    #nullable disable
    
}
