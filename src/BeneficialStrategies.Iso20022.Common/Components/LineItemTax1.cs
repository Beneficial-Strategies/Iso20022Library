// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
/// </summary>
[IsoId("_S0j3MQEcEeCQm6a_G2yO_w_1452898168")]
[DisplayName("Line Item Tax")]
public record LineItemTax1
{
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_S0toIAEcEeCQm6a_G2yO_w_525289040")]
    [DisplayName("Calculated Amount")]
    [IsoXmlTag("ClctdAmt")]
    public CurrencyAndAmount? CalculatedAmount { get; init; }

    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_S0toIQEcEeCQm6a_G2yO_w_698047193")]
    [DisplayName("Type Code")]
    [IsoXmlTag("TpCd")]
    public TaxTypeFormat1Choice_? TypeCode { get; init; }

    /// <summary>
    /// Date of the tax point date when this tax, levy or duty becomes applicable.
    /// </summary>
    [IsoId("_S0toIgEcEeCQm6a_G2yO_w_1128406293")]
    [DisplayName("Tax Point Date")]
    [IsoXmlTag("TaxPtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TaxPointDate { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of this tax, levy or duty.
    /// </summary>
    [IsoId("_S0toIwEcEeCQm6a_G2yO_w_-316336554")]
    [DisplayName("Calculated Rate")]
    [IsoXmlTag("ClctdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CalculatedRate { get; init; }

    /// <summary>
    /// Code specifying the category to which this tax, levy or duty applies, such as codes for &apos;exempt from tax&apos;, &apos;standard rate&apos;, &quot;free export item - tax not charged&apos;.
    /// </summary>
    [IsoId("_S0toJAEcEeCQm6a_G2yO_w_-344611001")]
    [DisplayName("Category Code")]
    [IsoXmlTag("CtgyCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? CategoryCode { get; init; }

    /// <summary>
    /// Category name, expressed as text, of the tax, levy or duty.
    /// </summary>
    [IsoId("_S0toJQEcEeCQm6a_G2yO_w_-1190517937")]
    [DisplayName("Category Name")]
    [IsoXmlTag("CtgyNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CategoryName { get; init; }
}
