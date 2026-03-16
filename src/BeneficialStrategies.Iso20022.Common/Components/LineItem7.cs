// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Commercial details of a trade transaction between a buyer and a seller.
/// </summary>
[IsoId("_SrZNRdp-Ed-ak6NoX_4Aeg_956811526")]
[DisplayName("Line Item")]
public record LineItem7
{
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_SrZNRtp-Ed-ak6NoX_4Aeg_956812066")]
    [DisplayName("Goods Description")]
    [IsoXmlTag("GoodsDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? GoodsDescription { get; init; }

    /// <summary>
    /// Indicates whether or not partial shipments are allowed.
    /// </summary>
    [IsoId("_SrZNR9p-Ed-ak6NoX_4Aeg_956811543")]
    [DisplayName("Partial Shipment")]
    [IsoXmlTag("PrtlShipmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartialShipment { get; init; }

    /// <summary>
    /// Indicates whether or not transshipment of goods is allowed.
    /// </summary>
    [IsoId("_SrZNSNp-Ed-ak6NoX_4Aeg_956811603")]
    [DisplayName("Trans Shipment")]
    [IsoXmlTag("TrnsShipmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransShipment { get; init; }

    /// <summary>
    /// Specifies an earliest shipment date and a latest shipment date.
    /// </summary>
    [IsoId("_SrZNSdp-Ed-ak6NoX_4Aeg_-2001820232")]
    [DisplayName("Shipment Date Range")]
    [IsoXmlTag("ShipmntDtRg")]
    public ShipmentDateRange1? ShipmentDateRange { get; init; }

    /// <summary>
    /// Goods or services that are purchased.
    /// </summary>
    [IsoId("_SrZNStp-Ed-ak6NoX_4Aeg_956812180")]
    [DisplayName("Line Item Details")]
    [IsoXmlTag("LineItmDtls")]
    public ValueList<LineItemDetails7> LineItemDetails { get; init; } = [];

    // ID for the above is _SrZNStp-Ed-ak6NoX_4Aeg_956812180

    /// <summary>
    /// Specifies the total amount of all line items (incl. their adjustments).
    /// </summary>
    [IsoId("_Sri-QNp-Ed-ak6NoX_4Aeg_956811646")]
    [DisplayName("Line Items Total Amount")]
    [IsoXmlTag("LineItmsTtlAmt")]
    public required CurrencyAndAmount LineItemsTotalAmount { get; init; }

    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_Sri-Qdp-Ed-ak6NoX_4Aeg_956813187")]
    [DisplayName("Routing Summary")]
    [IsoXmlTag("RtgSummry")]
    public TransportMeans1? RoutingSummary { get; init; }

    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    [IsoId("_Sri-Qtp-Ed-ak6NoX_4Aeg_956812257")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms1? Incoterms { get; init; }

    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_Sri-Q9p-Ed-ak6NoX_4Aeg_956812997")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment3? Adjustment { get; init; }

    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_Sri-RNp-Ed-ak6NoX_4Aeg_956812919")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge12? FreightCharges { get; init; }

    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_Sri-Rdp-Ed-ak6NoX_4Aeg_956812577")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax13? Tax { get; init; }

    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    [IsoId("_Sri-Rtp-Ed-ak6NoX_4Aeg_956811698")]
    [DisplayName("Total Net Amount")]
    [IsoXmlTag("TtlNetAmt")]
    public required CurrencyAndAmount TotalNetAmount { get; init; }

    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_Sri-R9p-Ed-ak6NoX_4Aeg_956813507")]
    [DisplayName("Buyer Defined Information")]
    [IsoXmlTag("BuyrDfndInf")]
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; }

    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_Sri-SNp-Ed-ak6NoX_4Aeg_956813092")]
    [DisplayName("Seller Defined Information")]
    [IsoXmlTag("SellrDfndInf")]
    public UserDefinedInformation1? SellerDefinedInformation { get; init; }
}
