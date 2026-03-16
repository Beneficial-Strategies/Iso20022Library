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
[IsoId("_nxeDkefIEeKNfc-Rw_dPYg")]
[DisplayName("Line Item")]
public record LineItem11
{
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_oNFomefIEeKNfc-Rw_dPYg")]
    [DisplayName("Goods Description")]
    [IsoXmlTag("GoodsDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? GoodsDescription { get; init; }

    /// <summary>
    /// Indicates whether or not partial shipments are allowed.
    /// </summary>
    [IsoId("_oNFom-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Partial Shipment")]
    [IsoXmlTag("PrtlShipmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartialShipment { get; init; }

    /// <summary>
    /// Indicates whether or not transshipment of goods is allowed.
    /// </summary>
    [IsoId("_oNFonefIEeKNfc-Rw_dPYg")]
    [DisplayName("Trans Shipment")]
    [IsoXmlTag("TrnsShipmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransShipment { get; init; }

    /// <summary>
    /// Specifies an earliest shipment date and a latest shipment date.
    /// </summary>
    [IsoId("_oNFon-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Shipment Date Range")]
    [IsoXmlTag("ShipmntDtRg")]
    public ShipmentDateRange1? ShipmentDateRange { get; init; }

    /// <summary>
    /// Goods or services that are purchased.
    /// </summary>
    [IsoId("_oNFooefIEeKNfc-Rw_dPYg")]
    [DisplayName("Line Item Details")]
    [IsoXmlTag("LineItmDtls")]
    public ValueList<LineItemDetails10> LineItemDetails { get; init; } = [];

    // ID for the above is _oNFooefIEeKNfc-Rw_dPYg

    /// <summary>
    /// Specifies the total amount of all line items (incl. their adjustments).
    /// </summary>
    [IsoId("_oNFoo-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Line Items Total Amount")]
    [IsoXmlTag("LineItmsTtlAmt")]
    public required CurrencyAndAmount LineItemsTotalAmount { get; init; }

    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_oNFopefIEeKNfc-Rw_dPYg")]
    [DisplayName("Routing Summary")]
    [IsoXmlTag("RtgSummry")]
    public TransportMeans5? RoutingSummary { get; init; }

    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    [IsoId("_oNFop-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms4? Incoterms { get; init; }

    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_oNFoqefIEeKNfc-Rw_dPYg")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public ValueList<Adjustment7> Adjustment { get; init; } = [];

    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_oNFoq-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge24? FreightCharges { get; init; }

    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_oNForefIEeKNfc-Rw_dPYg")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax23> Tax { get; init; } = [];

    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    [IsoId("_oNFor-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Total Net Amount")]
    [IsoXmlTag("TtlNetAmt")]
    public required CurrencyAndAmount TotalNetAmount { get; init; }

    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_oNFosefIEeKNfc-Rw_dPYg")]
    [DisplayName("Buyer Defined Information")]
    [IsoXmlTag("BuyrDfndInf")]
    public ValueList<UserDefinedInformation1> BuyerDefinedInformation { get; init; } = [];

    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_oNFos-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Seller Defined Information")]
    [IsoXmlTag("SellrDfndInf")]
    public ValueList<UserDefinedInformation1> SellerDefinedInformation { get; init; } = [];
}
