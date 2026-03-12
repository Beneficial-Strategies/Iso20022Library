// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Commercial details of a trade transaction between a buyer and a seller.
/// </summary>
[IsoId("_KK1ZcQgHEeSeS5xdjFfOTw")]
[DisplayName("Line Item")]
public partial record LineItem13
{
    #nullable enable
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_KiCYWQgHEeSeS5xdjFfOTw")]
    [DisplayName("Goods And Or Services Description")]
    [IsoXmlTag("GoodsAndOrSvcsDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? GoodsAndOrServicesDescription { get; init; } 
    
    /// <summary>
    /// Indicates whether or not partial shipments are allowed.
    /// </summary>
    [IsoId("_KiCYWwgHEeSeS5xdjFfOTw")]
    [DisplayName("Partial Shipment")]
    [IsoXmlTag("PrtlShipmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartialShipment { get; init; } 
    
    /// <summary>
    /// Indicates whether or not transshipment of goods is allowed.
    /// </summary>
    [IsoId("_KiCYXQgHEeSeS5xdjFfOTw")]
    [DisplayName("Trans Shipment")]
    [IsoXmlTag("TrnsShipmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransShipment { get; init; } 
    
    /// <summary>
    /// Specifies an earliest shipment date and a latest shipment date.
    /// </summary>
    [IsoId("_KiCYXwgHEeSeS5xdjFfOTw")]
    [DisplayName("Shipment Date Range")]
    [IsoXmlTag("ShipmntDtRg")]
    public ShipmentDateRange1? ShipmentDateRange { get; init; } 
    
    /// <summary>
    /// Goods or services that are purchased.
    /// </summary>
    [IsoId("_KiCYYQgHEeSeS5xdjFfOTw")]
    [DisplayName("Line Item Details")]
    [IsoXmlTag("LineItmDtls")]
    public ValueList<LineItemDetails13> LineItemDetails { get; init; } = new ValueList<LineItemDetails13>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _KiCYYQgHEeSeS5xdjFfOTw
    
    /// <summary>
    /// Specifies the total amount of all line items (incl. their adjustments).
    /// </summary>
    [IsoId("_KiCYYwgHEeSeS5xdjFfOTw")]
    [DisplayName("Line Items Total Amount")]
    [IsoXmlTag("LineItmsTtlAmt")]
    public required CurrencyAndAmount LineItemsTotalAmount { get; init; } 
    
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_KiCYZQgHEeSeS5xdjFfOTw")]
    [DisplayName("Routing Summary")]
    [IsoXmlTag("RtgSummry")]
    public TransportMeans5? RoutingSummary { get; init; } 
    
    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    [IsoId("_KiCYZwgHEeSeS5xdjFfOTw")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms4? Incoterms { get; init; } 
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_KiCYaQgHEeSeS5xdjFfOTw")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment7? Adjustment { get; init; } 
    
    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_KiCYawgHEeSeS5xdjFfOTw")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge24? FreightCharges { get; init; } 
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_KiCYbQgHEeSeS5xdjFfOTw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax23? Tax { get; init; } 
    
    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    [IsoId("_KiCYbwgHEeSeS5xdjFfOTw")]
    [DisplayName("Total Net Amount")]
    [IsoXmlTag("TtlNetAmt")]
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_KiCYcQgHEeSeS5xdjFfOTw")]
    [DisplayName("Buyer Defined Information")]
    [IsoXmlTag("BuyrDfndInf")]
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_KiCYcwgHEeSeS5xdjFfOTw")]
    [DisplayName("Seller Defined Information")]
    [IsoXmlTag("SellrDfndInf")]
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    
    
    #nullable disable
    
}
