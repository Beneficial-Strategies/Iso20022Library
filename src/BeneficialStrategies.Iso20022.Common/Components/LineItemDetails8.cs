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
/// Calculation of the current situation of a line item as a result of the submission of a commercial dataset.
/// </summary>
[IsoId("_SscWJdp-Ed-ak6NoX_4Aeg_245671612")]
[DisplayName("Line Item Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItemDetails8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LineItemDetails8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LineItemDetails8( System.String reqLineItemIdentification,Quantity4 reqOrderedQuantity,Quantity4 reqAcceptedQuantity,Quantity4 reqOutstandingQuantity,Quantity4 reqPendingQuantity,CurrencyAndAmount reqOrderedAmount,CurrencyAndAmount reqAcceptedAmount,CurrencyAndAmount reqOutstandingAmount,CurrencyAndAmount reqPendingAmount )
    {
        LineItemIdentification = reqLineItemIdentification;
        OrderedQuantity = reqOrderedQuantity;
        AcceptedQuantity = reqAcceptedQuantity;
        OutstandingQuantity = reqOutstandingQuantity;
        PendingQuantity = reqPendingQuantity;
        OrderedAmount = reqOrderedAmount;
        AcceptedAmount = reqAcceptedAmount;
        OutstandingAmount = reqOutstandingAmount;
        PendingAmount = reqPendingAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential number assigned to a line item.
    /// </summary>
    [IsoId("_SscWJtp-Ed-ak6NoX_4Aeg_245671614")]
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
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    [IsoId("_SscWJ9p-Ed-ak6NoX_4Aeg_245671666")]
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
    [IsoId("_SscWKNp-Ed-ak6NoX_4Aeg_246592345")]
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
    /// Identifies the characteristic of a product.
    /// </summary>
    [IsoId("_SscWKdp-Ed-ak6NoX_4Aeg_246592654")]
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
    [IsoId("_SscWKtp-Ed-ak6NoX_4Aeg_246592623")]
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
    /// Quantity ordered for a line as indicated in the baseline.
    /// </summary>
    [IsoId("_SslgENp-Ed-ak6NoX_4Aeg_246592114")]
    [DisplayName("Ordered Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrdQty")]
    #endif
    [IsoXmlTag("OrdrdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity4 OrderedQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity4 OrderedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity4 OrderedQuantity { get; init; } 
    #else
    public Quantity4 OrderedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity accepted by data set submission.
    /// </summary>
    [IsoId("_SslgEdp-Ed-ak6NoX_4Aeg_246592131")]
    [DisplayName("Accepted Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptdQty")]
    #endif
    [IsoXmlTag("AccptdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity4 AcceptedQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity4 AcceptedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity4 AcceptedQuantity { get; init; } 
    #else
    public Quantity4 AcceptedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the ordered quantity and the accepted one.
    /// </summary>
    [IsoId("_SslgEtp-Ed-ak6NoX_4Aeg_246592223")]
    [DisplayName("Outstanding Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngQty")]
    #endif
    [IsoXmlTag("OutsdngQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity4 OutstandingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity4 OutstandingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity4 OutstandingQuantity { get; init; } 
    #else
    public Quantity4 OutstandingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of a product for which a mismatched data set has been submitted and has not yet been accepted or rejected.
    /// </summary>
    [IsoId("_SslgE9p-Ed-ak6NoX_4Aeg_246592192")]
    [DisplayName("Pending Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgQty")]
    #endif
    [IsoXmlTag("PdgQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity4 PendingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity4 PendingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity4 PendingQuantity { get; init; } 
    #else
    public Quantity4 PendingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Variance allowed on the quantity of goods.
    /// </summary>
    [IsoId("_SslgFNp-Ed-ak6NoX_4Aeg_-1627859997")]
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
    /// Price multiplied by the ordered quantity for a line as indicated in the baseline.
    /// </summary>
    [IsoId("_SslgFdp-Ed-ak6NoX_4Aeg_245671944")]
    [DisplayName("Ordered Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrdAmt")]
    #endif
    [IsoXmlTag("OrdrdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount OrderedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount OrderedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount OrderedAmount { get; init; } 
    #else
    public CurrencyAndAmount OrderedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Price multiplied by the accepted quantity for a line.
    /// </summary>
    [IsoId("_SslgFtp-Ed-ak6NoX_4Aeg_245671975")]
    [DisplayName("Accepted Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptdAmt")]
    #endif
    [IsoXmlTag("AccptdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount AcceptedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount AcceptedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount AcceptedAmount { get; init; } 
    #else
    public CurrencyAndAmount AcceptedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Price multiplied by the outstanding quantity for a line.
    /// </summary>
    [IsoId("_SslgF9p-Ed-ak6NoX_4Aeg_245672067")]
    [DisplayName("Outstanding Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngAmt")]
    #endif
    [IsoXmlTag("OutsdngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount OutstandingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount OutstandingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount OutstandingAmount { get; init; } 
    #else
    public CurrencyAndAmount OutstandingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Price multiplied by the pending quantity for a line.
    /// </summary>
    [IsoId("_SslgGNp-Ed-ak6NoX_4Aeg_245672036")]
    [DisplayName("Pending Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgAmt")]
    #endif
    [IsoXmlTag("PdgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount PendingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount PendingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount PendingAmount { get; init; } 
    #else
    public CurrencyAndAmount PendingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_SsvRENp-Ed-ak6NoX_4Aeg_246592315")]
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
    
    
    #nullable disable
    
}
