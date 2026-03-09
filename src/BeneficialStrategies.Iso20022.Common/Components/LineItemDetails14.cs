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
[IsoId("_cM3m0TckEeSaC-PiOaz_KQ")]
[DisplayName("Line Item Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItemDetails14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LineItemDetails14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LineItemDetails14( System.String reqLineItemIdentification,Quantity9 reqQuantity,CurrencyAndAmount reqTotalAmount )
    {
        LineItemIdentification = reqLineItemIdentification;
        Quantity = reqQuantity;
        TotalAmount = reqTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential number assigned to a line item.
    /// </summary>
    [IsoId("_cil_MTckEeSaC-PiOaz_KQ")]
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
    /// Specifies the quantity of a product in a trade transaction.
    /// </summary>
    [IsoId("_cil_MzckEeSaC-PiOaz_KQ")]
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
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_cil_NTckEeSaC-PiOaz_KQ")]
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
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    [IsoId("_cil_NzckEeSaC-PiOaz_KQ")]
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
    [IsoId("_cil_OTckEeSaC-PiOaz_KQ")]
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
    /// Identifies the characteristics of product.
    /// </summary>
    [IsoId("_cil_OzckEeSaC-PiOaz_KQ")]
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
    [IsoId("_cil_PTckEeSaC-PiOaz_KQ")]
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
    /// Country of origin of the goods.
    /// </summary>
    [IsoId("_cil_PzckEeSaC-PiOaz_KQ")]
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
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_cil_QTckEeSaC-PiOaz_KQ")]
    [DisplayName("Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adjstmnt")]
    #endif
    [IsoXmlTag("Adjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment6? Adjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment6? Adjustment { get; init; } 
    #else
    public Adjustment6? Adjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_cil_QzckEeSaC-PiOaz_KQ")]
    [DisplayName("Freight Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrghtChrgs")]
    #endif
    [IsoXmlTag("FrghtChrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge25? FreightCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge25? FreightCharges { get; init; } 
    #else
    public Charge25? FreightCharges { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_cil_RTckEeSaC-PiOaz_KQ")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax22? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax22? Tax { get; init; } 
    #else
    public Tax22? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the line item after adjustments have been applied.
    /// </summary>
    [IsoId("_cil_RzckEeSaC-PiOaz_KQ")]
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
    
    
    #nullable disable
    
}
