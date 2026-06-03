// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Item purchased with the transaction.
/// </summary>
[IsoId("_JazOkVXhEfC0lMwgjvMClw")]
[DisplayName("Sale Item5")]
public record SaleItem5
{
    /// <summary>
    /// Contains the product type of the sale line item.
    /// </summary>
    [IsoId("_JdVlMFXhEfC0lMwgjvMClw")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    public IsoMax35Text? ProductType { get; init; }

    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_JdVlMlXhEfC0lMwgjvMClw")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    public IsoMax70Text? ProductCode { get; init; }

    /// <summary>
    /// Contains a list of codes used to identify a product.
    /// </summary>
    [IsoId("_JdVlNFXhEfC0lMwgjvMClw")]
    [DisplayName("Product Code Type")]
    [IsoXmlTag("PdctCdTp")]
    public ProductCodeType1Code? ProductCodeType { get; init; }

    /// <summary>
    /// Additional code related to the product.
    /// </summary>
    [IsoId("_JdVlNlXhEfC0lMwgjvMClw")]
    [DisplayName("Additional Product Code")]
    [IsoXmlTag("AddtlPdctCd")]
    public IsoMax70Text? AdditionalProductCode { get; init; }

    /// <summary>
    /// Additional type of codification used to identify a product.
    /// </summary>
    [IsoId("_JdVlOFXhEfC0lMwgjvMClw")]
    [DisplayName("Additional Product Code Type")]
    [IsoXmlTag("AddtlPdctCdTp")]
    public IsoMax35Text? AdditionalProductCodeType { get; init; }

    /// <summary>
    /// Code discriminator between a product code and its format to uniquely identify a specific product.
    /// </summary>
    [IsoId("_JdVlOlXhEfC0lMwgjvMClw")]
    [DisplayName("Product Code Modifier")]
    [IsoXmlTag("PdctCdModfr")]
    public IsoDecimalNumber? ProductCodeModifier { get; init; }

    /// <summary>
    /// Description of the product or item.
    /// </summary>
    [IsoId("_JdVlPFXhEfC0lMwgjvMClw")]
    [DisplayName("Product Description")]
    [IsoXmlTag("PdctDesc")]
    public IsoMax140Text? ProductDescription { get; init; }

    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_JdVlPlXhEfC0lMwgjvMClw")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_JdVlQFXhEfC0lMwgjvMClw")]
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    public IsoMax35Text? OtherUnitOfMeasure { get; init; }

    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_JdVlQlXhEfC0lMwgjvMClw")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    public IsoDecimalNumber? ProductQuantity { get; init; }

    /// <summary>
    /// Original, non-adjusted cost of one unit of the product or service before discounts and taxes.
    /// </summary>
    [IsoId("_JdVlRFXhEfC0lMwgjvMClw")]
    [DisplayName("Non Adjusted Unit Price")]
    [IsoXmlTag("NonAdjstdUnitPric")]
    public ImpliedCurrencyAndAmount? NonAdjustedUnitPrice { get; init; }

    /// <summary>
    /// Original, non-adjusted total cost of a product or service before discounts and taxes.
    /// </summary>
    [IsoId("_JdVlRlXhEfC0lMwgjvMClw")]
    [DisplayName("Non Adjusted Total Amount")]
    [IsoXmlTag("NonAdjstdTtlAmt")]
    public ImpliedCurrencyAndAmount? NonAdjustedTotalAmount { get; init; }

    /// <summary>
    /// Adjustment made to the original price.
    /// </summary>
    [IsoId("_JdVlSFXhEfC0lMwgjvMClw")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public ValueList<Adjustment14> Adjustment { get; init; } = [];

    /// <summary>
    /// Total cost of the line item amount, inclusive adjustments and exclusive of taxes.
    /// </summary>
    [IsoId("_JdVlSlXhEfC0lMwgjvMClw")]
    [DisplayName("Adjusted Amount")]
    [IsoXmlTag("AdjstdAmt")]
    public ImpliedCurrencyAndAmount? AdjustedAmount { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_JdVlTFXhEfC0lMwgjvMClw")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    [IsoId("_JdVlTlXhEfC0lMwgjvMClw")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Taxes applying to the good or item.
    /// </summary>
    [IsoId("_JdVlUFXhEfC0lMwgjvMClw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Total cost of the line item, inclusive of all applicable adjustments and taxes.
    /// </summary>
    [IsoId("_JdVlUlXhEfC0lMwgjvMClw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }
}
