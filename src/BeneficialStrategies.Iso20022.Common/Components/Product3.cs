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
[IsoId("_zAYo0Y-LEeWGMsAOtoswqg")]
[DisplayName("Product")]
public record Product3
{
    /// <summary>
    /// Identification of the item inside the purchase transaction.
    /// </summary>
    [IsoId("__WDIgI-MEeWGMsAOtoswqg")]
    [DisplayName("Item Identification")]
    [IsoXmlTag("ItmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ItemIdentification { get; init; }

    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_zRqmEY-LEeWGMsAOtoswqg")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text ProductCode { get; init; }

    /// <summary>
    /// Additional product code related to the product.
    /// </summary>
    [IsoId("_8KYRIJVHEeWu36UkS2TkoQ")]
    [DisplayName("Additional Product Code")]
    [IsoXmlTag("AddtlPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalProductCode { get; init; }

    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_zRqmE4-LEeWGMsAOtoswqg")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure6Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Product quantity.
    /// </summary>
    [IsoId("_zRqmFY-LEeWGMsAOtoswqg")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductQuantity { get; init; }

    /// <summary>
    /// Price per unit of product.
    /// </summary>
    [IsoId("_zRqmF4-LEeWGMsAOtoswqg")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; }

    /// <summary>
    /// Sign of the unit price.
    /// </summary>
    [IsoId("_Fgg6EJVIEeWu36UkS2TkoQ")]
    [DisplayName("Unit Price Sign")]
    [IsoXmlTag("UnitPricSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? UnitPriceSign { get; init; }

    /// <summary>
    /// Monetary value of purchased product.
    /// </summary>
    [IsoId("_zRqmGY-LEeWGMsAOtoswqg")]
    [DisplayName("Product Amount")]
    [IsoXmlTag("PdctAmt")]
    public required ImpliedCurrencyAndAmount ProductAmount { get; init; }

    /// <summary>
    /// Sign of the product amount.
    /// </summary>
    [IsoId("_Ku5DcJVIEeWu36UkS2TkoQ")]
    [DisplayName("Product Amount Sign")]
    [IsoXmlTag("PdctAmtSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? ProductAmountSign { get; init; }

    /// <summary>
    /// Value added tax amount of the item included in the product amount.
    /// </summary>
    [IsoId("_PtY9wJVIEeWu36UkS2TkoQ")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public ImpliedCurrencyAndAmount? ValueAddedTax { get; init; }

    /// <summary>
    /// Information on tax paid on the product.
    /// </summary>
    [IsoId("_zRqmG4-LEeWGMsAOtoswqg")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxType { get; init; }

    /// <summary>
    /// Description of the product or item.
    /// </summary>
    [IsoId("_zRqmHY-LEeWGMsAOtoswqg")]
    [DisplayName("Product Description")]
    [IsoXmlTag("PdctDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ProductDescription { get; init; }

    /// <summary>
    /// Location of the delivery of the item, for instance pump number or parking bay.
    /// </summary>
    [IsoId("_zMVksI-MEeWGMsAOtoswqg")]
    [DisplayName("Delivery Location")]
    [IsoXmlTag("DlvryLctn")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? DeliveryLocation { get; init; }

    /// <summary>
    /// Identify the method of delivery or distribution of the item.
    /// </summary>
    [IsoId("_oiwfYJVJEeWu36UkS2TkoQ")]
    [DisplayName("Delivery Service")]
    [IsoXmlTag("DlvrySvc")]
    public AttendanceContext2Code? DeliveryService { get; init; }
}
