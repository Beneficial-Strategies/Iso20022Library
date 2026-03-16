// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tangible output or service produced by human or mechanical effort, or by a natural process for purposes of specifying a product.
/// </summary>
[IsoId("_S5ezcgEcEeCQm6a_G2yO_w_-1364356663")]
[DisplayName("Trade Product")]
public record TradeProduct1
{
    /// <summary>
    /// Identification of the product.
    /// </summary>
    [IsoId("_S5ezcwEcEeCQm6a_G2yO_w_1472957533")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<ProductIdentifier2Choice_> Identification { get; init; } = [];

    /// <summary>
    /// Name of a product.
    /// </summary>
    [IsoId("_S5ezdAEcEeCQm6a_G2yO_w_504353995")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_S5n9UAEcEeCQm6a_G2yO_w_52675725")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; }

    /// <summary>
    /// Country of origin of the product.
    /// </summary>
    [IsoId("_S5n9UQEcEeCQm6a_G2yO_w_-691201196")]
    [DisplayName("Country Of Origin")]
    [IsoXmlTag("CtryOfOrgn")]
    public ValueList<CountryCodeAndName1> CountryOfOrigin { get; init; } = [];

    /// <summary>
    /// Identifies the characteristic of a product.
    /// </summary>
    [IsoId("_S5n9UgEcEeCQm6a_G2yO_w_-598061413")]
    [DisplayName("Product Characteristics")]
    [IsoXmlTag("PdctChrtcs")]
    public ValueList<ProductCharacteristics2> ProductCharacteristics { get; init; } = [];

    /// <summary>
    /// Category of the product.
    /// </summary>
    [IsoId("_S5n9UwEcEeCQm6a_G2yO_w_1809446636")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public ValueList<ProductCategory1Choice_> ProductCategory { get; init; } = [];

    /// <summary>
    /// Unique global serial identifier for this product instance.
    /// </summary>
    [IsoId("_S5n9VAEcEeCQm6a_G2yO_w_-1551749202")]
    [DisplayName("Global Serial Identifier")]
    [IsoXmlTag("GblSrlIdr")]
    public SimpleValueList<IsoMax35Text> GlobalSerialIdentifier { get; init; } = [];
}
