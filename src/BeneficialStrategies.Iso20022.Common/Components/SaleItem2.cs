// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Item purchased with the transaction
/// </summary>
[IsoId("_buMzlPJxEeiJn9rM2Znz2w")]
[DisplayName("Sale Item")]
public record SaleItem2
{
    /// <summary>
    /// Contains the product type of the sale line item.
    /// </summary>
    [IsoId("_pgLVs_JxEeiJn9rM2Znz2w")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProductType { get; init; }

    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_pgLVtPJxEeiJn9rM2Znz2w")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ProductCode { get; init; }

    /// <summary>
    /// Contains a list of codes used to identify a product.
    /// </summary>
    [IsoId("_pgLVtfJxEeiJn9rM2Znz2w")]
    [DisplayName("Product Code Type")]
    [IsoXmlTag("PdctCdTp")]
    public ProductCodeType1Code? ProductCodeType { get; init; }

    /// <summary>
    /// Additional code related to the product.
    /// </summary>
    [IsoId("_1dhRefJxEeiJn9rM2Znz2w")]
    [DisplayName("Additional Product Code")]
    [IsoXmlTag("AddtlPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalProductCode { get; init; }

    /// <summary>
    /// Additional type of codification  used to identify a product.
    /// </summary>
    [IsoId("_1dhRevJxEeiJn9rM2Znz2w")]
    [DisplayName("Additional Product Code Type")]
    [IsoXmlTag("AddtlPdctCdTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalProductCodeType { get; init; }

    /// <summary>
    /// Code discriminator between a product code and its format to uniquely identify a specific product (for example, Item or pack of same items).
    /// </summary>
    [IsoId("_1dhRe_JxEeiJn9rM2Znz2w")]
    [DisplayName("Product Code Modifier")]
    [IsoXmlTag("PdctCdModfr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductCodeModifier { get; init; }

    /// <summary>
    /// Description of the product or item.
    /// </summary>
    [IsoId("_1dhRfPJxEeiJn9rM2Znz2w")]
    [DisplayName("Product Description")]
    [IsoXmlTag("PdctDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ProductDescription { get; init; }

    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_1dhRffJxEeiJn9rM2Znz2w")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_1dhRfvJxEeiJn9rM2Znz2w")]
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherUnitOfMeasure { get; init; }

    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_1dhRf_JxEeiJn9rM2Znz2w")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductQuantity { get; init; }

    /// <summary>
    /// Original, non-adjusted cost of one unit of the product or service before discounts and taxes.
    /// </summary>
    [IsoId("_1dhRgPJxEeiJn9rM2Znz2w")]
    [DisplayName("Non Adjusted Unit Price")]
    [IsoXmlTag("NonAdjstdUnitPric")]
    public ImpliedCurrencyAndAmount? NonAdjustedUnitPrice { get; init; }

    /// <summary>
    /// Original, non-adjusted total cost of a product or service before discounts and taxes.
    /// </summary>
    [IsoId("_1dhRg_JxEeiJn9rM2Znz2w")]
    [DisplayName("Non Adjusted Total Amount")]
    [IsoXmlTag("NonAdjstdTtlAmt")]
    public ImpliedCurrencyAndAmount? NonAdjustedTotalAmount { get; init; }

    /// <summary>
    /// Adjustment made to the original price.
    /// </summary>
    [IsoId("_1dhRhfJxEeiJn9rM2Znz2w")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment10? Adjustment { get; init; }

    /// <summary>
    /// Total cost of the line item amount, inclusive adjustments and exclusive of taxes.
    /// </summary>
    [IsoId("__SeLEfJ2EeiJn9rM2Znz2w")]
    [DisplayName("Adjusted Amount")]
    [IsoXmlTag("AdjstdAmt")]
    public ImpliedCurrencyAndAmount? AdjustedAmount { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_PotZsfJ3EeiJn9rM2Znz2w")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    [IsoId("_P_jMYfJ3EeiJn9rM2Znz2w")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Taxes applying to the good or item.
    /// </summary>
    [IsoId("_1dhRhPJxEeiJn9rM2Znz2w")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax33? Tax { get; init; }

    /// <summary>
    /// Total cost of the line item, inclusive of all applicable adjustments and taxes.
    /// </summary>
    [IsoId("_SjNb8fJ3EeiJn9rM2Znz2w")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }
}
