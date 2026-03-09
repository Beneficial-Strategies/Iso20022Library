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
/// Commercial details of a trade transaction between a buyer and a seller.
/// </summary>
[IsoId("_SrZNRdp-Ed-ak6NoX_4Aeg_956811526")]
[DisplayName("Line Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItem7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LineItem7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LineItem7( System.String reqPartialShipment,CurrencyAndAmount reqLineItemsTotalAmount,CurrencyAndAmount reqTotalNetAmount )
    {
        PartialShipment = reqPartialShipment;
        LineItemsTotalAmount = reqLineItemsTotalAmount;
        TotalNetAmount = reqTotalNetAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_SrZNRtp-Ed-ak6NoX_4Aeg_956812066")]
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
    /// Indicates whether or not partial shipments are allowed.
    /// </summary>
    [IsoId("_SrZNR9p-Ed-ak6NoX_4Aeg_956811543")]
    [DisplayName("Partial Shipment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlShipmnt")]
    #endif
    [IsoXmlTag("PrtlShipmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PartialShipment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PartialShipment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PartialShipment { get; init; } 
    #else
    public System.String PartialShipment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not transshipment of goods is allowed.
    /// </summary>
    [IsoId("_SrZNSNp-Ed-ak6NoX_4Aeg_956811603")]
    [DisplayName("Trans Shipment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsShipmnt")]
    #endif
    [IsoXmlTag("TrnsShipmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TransShipment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransShipment { get; init; } 
    #else
    public System.String? TransShipment { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies an earliest shipment date and a latest shipment date.
    /// </summary>
    [IsoId("_SrZNSdp-Ed-ak6NoX_4Aeg_-2001820232")]
    [DisplayName("Shipment Date Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipmntDtRg")]
    #endif
    [IsoXmlTag("ShipmntDtRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShipmentDateRange1? ShipmentDateRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShipmentDateRange1? ShipmentDateRange { get; init; } 
    #else
    public ShipmentDateRange1? ShipmentDateRange { get; set; } 
    #endif
    
    /// <summary>
    /// Goods or services that are purchased.
    /// </summary>
    [IsoId("_SrZNStp-Ed-ak6NoX_4Aeg_956812180")]
    [DisplayName("Line Item Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItmDtls")]
    #endif
    [IsoXmlTag("LineItmDtls")]
    public ValueList<LineItemDetails7> LineItemDetails { get; init; } = new ValueList<LineItemDetails7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SrZNStp-Ed-ak6NoX_4Aeg_956812180
    
    /// <summary>
    /// Specifies the total amount of all line items (incl. their adjustments).
    /// </summary>
    [IsoId("_Sri-QNp-Ed-ak6NoX_4Aeg_956811646")]
    [DisplayName("Line Items Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItmsTtlAmt")]
    #endif
    [IsoXmlTag("LineItmsTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount LineItemsTotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount LineItemsTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount LineItemsTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount LineItemsTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_Sri-Qdp-Ed-ak6NoX_4Aeg_956813187")]
    [DisplayName("Routing Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtgSummry")]
    #endif
    [IsoXmlTag("RtgSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportMeans1? RoutingSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportMeans1? RoutingSummary { get; init; } 
    #else
    public TransportMeans1? RoutingSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    [IsoId("_Sri-Qtp-Ed-ak6NoX_4Aeg_956812257")]
    [DisplayName("Incoterms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incotrms")]
    #endif
    [IsoXmlTag("Incotrms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Incoterms1? Incoterms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms1? Incoterms { get; init; } 
    #else
    public Incoterms1? Incoterms { get; set; } 
    #endif
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_Sri-Q9p-Ed-ak6NoX_4Aeg_956812997")]
    [DisplayName("Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adjstmnt")]
    #endif
    [IsoXmlTag("Adjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment3? Adjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment3? Adjustment { get; init; } 
    #else
    public Adjustment3? Adjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_Sri-RNp-Ed-ak6NoX_4Aeg_956812919")]
    [DisplayName("Freight Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrghtChrgs")]
    #endif
    [IsoXmlTag("FrghtChrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge12? FreightCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge12? FreightCharges { get; init; } 
    #else
    public Charge12? FreightCharges { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_Sri-Rdp-Ed-ak6NoX_4Aeg_956812577")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax13? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax13? Tax { get; init; } 
    #else
    public Tax13? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    [IsoId("_Sri-Rtp-Ed-ak6NoX_4Aeg_956811698")]
    [DisplayName("Total Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNetAmt")]
    #endif
    [IsoXmlTag("TtlNetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount TotalNetAmount { get; init; } 
    #else
    public CurrencyAndAmount TotalNetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_Sri-R9p-Ed-ak6NoX_4Aeg_956813507")]
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
    [IsoId("_Sri-SNp-Ed-ak6NoX_4Aeg_956813092")]
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
