// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tangible output or service produced by human or mechanical effort, or by a natural process for purposes of specifying a product.
/// </summary>
[IsoId("_KKpZccNUEeWGDrnsYu2p6g")]
[DisplayName("Trade Product")]
public partial record TradeProduct2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the product.
    /// </summary>
    [IsoId("_KXJkYcNUEeWGDrnsYu2p6g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ProductIdentifier2Choice_? Identification { get; init; } 
    
    /// <summary>
    /// Name of a product.
    /// </summary>
    [IsoId("_KXJkY8NUEeWGDrnsYu2p6g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_KXJkZcNUEeWGDrnsYu2p6g")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    /// <summary>
    /// Country of origin of the product.
    /// </summary>
    [IsoId("_KXJkZ8NUEeWGDrnsYu2p6g")]
    [DisplayName("Country Of Origin")]
    [IsoXmlTag("CtryOfOrgn")]
    public CountryCodeAndName1? CountryOfOrigin { get; init; } 
    
    /// <summary>
    /// Identifies the characteristic of a product.
    /// </summary>
    [IsoId("_KXJkacNUEeWGDrnsYu2p6g")]
    [DisplayName("Product Characteristics")]
    [IsoXmlTag("PdctChrtcs")]
    public ProductCharacteristics3? ProductCharacteristics { get; init; } 
    
    /// <summary>
    /// Category of the product.
    /// </summary>
    [IsoId("_KXJka8NUEeWGDrnsYu2p6g")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public ProductCategory1Choice_? ProductCategory { get; init; } 
    
    /// <summary>
    /// Unique global serial identifier for this product instance.
    /// </summary>
    [IsoId("_KXJkbcNUEeWGDrnsYu2p6g")]
    [DisplayName("Global Serial Identifier")]
    [IsoXmlTag("GblSrlIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? GlobalSerialIdentifier { get; init; } 
    
    
    #nullable disable
    
}
