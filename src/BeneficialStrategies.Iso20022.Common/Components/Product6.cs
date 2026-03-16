// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Purchased item.
/// </summary>
[IsoId("_h7v3oduLEeiB5uLfkg9ZJA")]
[DisplayName("Product")]
public record Product6
{
    /// <summary>
    /// Identification of the item inside the purchase transaction.
    /// </summary>
    [IsoId("_iGZocduLEeiB5uLfkg9ZJA")]
    [DisplayName("Item Identification")]
    [IsoXmlTag("ItmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ItemIdentification { get; init; }

    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_iGaPgduLEeiB5uLfkg9ZJA")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text ProductCode { get; init; }

    /// <summary>
    /// Additional product code related to the product.
    /// </summary>
    [IsoId("_iGaPg9uLEeiB5uLfkg9ZJA")]
    [DisplayName("Additional Product Code")]
    [IsoXmlTag("AddtlPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalProductCode { get; init; }

    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_iGaPhduLEeiB5uLfkg9ZJA")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure6Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Product quantity.
    /// </summary>
    [IsoId("_iGaPh9uLEeiB5uLfkg9ZJA")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductQuantity { get; init; }

    /// <summary>
    /// Price per unit of product.
    /// </summary>
    [IsoId("_iGaPiduLEeiB5uLfkg9ZJA")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; }

    /// <summary>
    /// Sign of the unit price.
    /// </summary>
    [IsoId("_iGaPi9uLEeiB5uLfkg9ZJA")]
    [DisplayName("Unit Price Sign")]
    [IsoXmlTag("UnitPricSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? UnitPriceSign { get; init; }

    /// <summary>
    /// Monetary value of purchased product.
    /// </summary>
    [IsoId("_iGaPjduLEeiB5uLfkg9ZJA")]
    [DisplayName("Product Amount")]
    [IsoXmlTag("PdctAmt")]
    public required ImpliedCurrencyAndAmount ProductAmount { get; init; }

    /// <summary>
    /// Sign of the product amount.
    /// </summary>
    [IsoId("_iGaPj9uLEeiB5uLfkg9ZJA")]
    [DisplayName("Product Amount Sign")]
    [IsoXmlTag("PdctAmtSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? ProductAmountSign { get; init; }

    /// <summary>
    /// Value added tax amount of the item included in the product amount.
    /// </summary>
    [IsoId("_iGaPkduLEeiB5uLfkg9ZJA")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public ImpliedCurrencyAndAmount? ValueAddedTax { get; init; }

    /// <summary>
    /// Information on tax paid on the product.
    /// </summary>
    [IsoId("_iGaPk9uLEeiB5uLfkg9ZJA")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxType { get; init; }

    /// <summary>
    /// Description of the product or item.
    /// </summary>
    [IsoId("_iGaPlduLEeiB5uLfkg9ZJA")]
    [DisplayName("Product Description")]
    [IsoXmlTag("PdctDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ProductDescription { get; init; }

    /// <summary>
    /// Location of the delivery of the item, for instance pump number or parking bay.
    /// </summary>
    [IsoId("_iGaPl9uLEeiB5uLfkg9ZJA")]
    [DisplayName("Delivery Location")]
    [IsoXmlTag("DlvryLctn")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? DeliveryLocation { get; init; }

    /// <summary>
    /// Identify the method of delivery or distribution of the item.
    /// </summary>
    [IsoId("_iGaPmduLEeiB5uLfkg9ZJA")]
    [DisplayName("Delivery Service")]
    [IsoXmlTag("DlvrySvc")]
    public AttendanceContext2Code? DeliveryService { get; init; }

    /// <summary>
    /// Commercial or distribution channel associated to the line item.
    /// </summary>
    [IsoId("_us2yoNuLEeiB5uLfkg9ZJA")]
    [DisplayName("Sale Channel")]
    [IsoXmlTag("SaleChanl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SaleChannel { get; init; }

    /// <summary>
    /// Additional information related to the line item.
    /// </summary>
    [IsoId("_yg2osNuLEeiB5uLfkg9ZJA")]
    [DisplayName("Additional Product Description")]
    [IsoXmlTag("AddtlPdctDesc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalProductDescription { get; init; }
}
