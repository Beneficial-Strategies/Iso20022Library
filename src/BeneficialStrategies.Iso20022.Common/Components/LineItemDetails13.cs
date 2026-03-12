// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Goods or services that are part of a commercial trade agreement.
/// </summary>
[IsoId("_krToMTcjEeSaC-PiOaz_KQ")]
[DisplayName("Line Item Details")]
public partial record LineItemDetails13
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a line item.
    /// </summary>
    [IsoId("_lCOTYTcjEeSaC-PiOaz_KQ")]
    [DisplayName("Line Item Identification")]
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text LineItemIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the quantity of goods on a line in a trade transaction.
    /// </summary>
    [IsoId("_lCOTYzcjEeSaC-PiOaz_KQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity9 Quantity { get; init; } 
    
    /// <summary>
    /// Variance allowed in the quantity of goods.
    /// </summary>
    [IsoId("_lCOTZTcjEeSaC-PiOaz_KQ")]
    [DisplayName("Quantity Tolerance")]
    [IsoXmlTag("QtyTlrnce")]
    public PercentageTolerance1? QuantityTolerance { get; init; } 
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_lCOTZzcjEeSaC-PiOaz_KQ")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public UnitPrice18? UnitPrice { get; init; } 
    
    /// <summary>
    /// Variance allowed on a price.
    /// </summary>
    [IsoId("_lCOTaTcjEeSaC-PiOaz_KQ")]
    [DisplayName("Price Tolerance")]
    [IsoXmlTag("PricTlrnce")]
    public PercentageTolerance1? PriceTolerance { get; init; } 
    
    /// <summary>
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    [IsoId("_lCOTazcjEeSaC-PiOaz_KQ")]
    [DisplayName("Product Name")]
    [IsoXmlTag("PdctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ProductName { get; init; } 
    
    /// <summary>
    /// Identifies the product of the corresponding line item.
    /// </summary>
    [IsoId("_lCOTbTcjEeSaC-PiOaz_KQ")]
    [DisplayName("Product Identifier")]
    [IsoXmlTag("PdctIdr")]
    public ProductIdentifier2Choice_? ProductIdentifier { get; init; } 
    
    /// <summary>
    /// Identifies the characteristics of a product.
    /// </summary>
    [IsoId("_lCOTbzcjEeSaC-PiOaz_KQ")]
    [DisplayName("Product Characteristics")]
    [IsoXmlTag("PdctChrtcs")]
    public ProductCharacteristics1Choice_? ProductCharacteristics { get; init; } 
    
    /// <summary>
    /// Identifies the category of product.
    /// </summary>
    [IsoId("_lCOTcTcjEeSaC-PiOaz_KQ")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public ProductCategory1Choice_? ProductCategory { get; init; } 
    
    /// <summary>
    /// Country from which the product originates.
    /// </summary>
    [IsoId("_lCOTczcjEeSaC-PiOaz_KQ")]
    [DisplayName("Product Origin")]
    [IsoXmlTag("PdctOrgn")]
    public CountryCode? ProductOrigin { get; init; } 
    
    /// <summary>
    /// Specifies the shipment schedule for the goods.
    /// </summary>
    [IsoId("_lCOTdTcjEeSaC-PiOaz_KQ")]
    [DisplayName("Shipment Schedule")]
    [IsoXmlTag("ShipmntSchdl")]
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; } 
    
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_lCOTdzcjEeSaC-PiOaz_KQ")]
    [DisplayName("Routing Summary")]
    [IsoXmlTag("RtgSummry")]
    public TransportMeans5? RoutingSummary { get; init; } 
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_lCOTeTcjEeSaC-PiOaz_KQ")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment7? Adjustment { get; init; } 
    
    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_lCOTezcjEeSaC-PiOaz_KQ")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge24? FreightCharges { get; init; } 
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_lCOTfTcjEeSaC-PiOaz_KQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax23? Tax { get; init; } 
    
    /// <summary>
    /// Total amount of the line item after adjustments have been applied.
    /// </summary>
    [IsoId("_lCOTfzcjEeSaC-PiOaz_KQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required CurrencyAndAmount TotalAmount { get; init; } 
    
    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    [IsoId("_lCOTgTcjEeSaC-PiOaz_KQ")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms4? Incoterms { get; init; } 
    
    
    #nullable disable
    
}
