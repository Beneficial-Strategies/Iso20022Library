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
/// Tangible output or service produced by human or mechanical effort, or by a natural process for purposes of specifying a product.
/// </summary>
[IsoId("_KKpZccNUEeWGDrnsYu2p6g")]
[DisplayName("Trade Product")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeProduct2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the product.
    /// </summary>
    [IsoId("_KXJkYcNUEeWGDrnsYu2p6g")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductIdentifier2Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductIdentifier2Choice_? Identification { get; init; } 
    #else
    public ProductIdentifier2Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a product.
    /// </summary>
    [IsoId("_KXJkY8NUEeWGDrnsYu2p6g")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_KXJkZcNUEeWGDrnsYu2p6g")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Country of origin of the product.
    /// </summary>
    [IsoId("_KXJkZ8NUEeWGDrnsYu2p6g")]
    [DisplayName("Country Of Origin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfOrgn")]
    #endif
    [IsoXmlTag("CtryOfOrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCodeAndName1? CountryOfOrigin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CountryCodeAndName1? CountryOfOrigin { get; init; } 
    #else
    public CountryCodeAndName1? CountryOfOrigin { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the characteristic of a product.
    /// </summary>
    [IsoId("_KXJkacNUEeWGDrnsYu2p6g")]
    [DisplayName("Product Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctChrtcs")]
    #endif
    [IsoXmlTag("PdctChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductCharacteristics3? ProductCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductCharacteristics3? ProductCharacteristics { get; init; } 
    #else
    public ProductCharacteristics3? ProductCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Category of the product.
    /// </summary>
    [IsoId("_KXJka8NUEeWGDrnsYu2p6g")]
    [DisplayName("Product Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCtgy")]
    #endif
    [IsoXmlTag("PdctCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductCategory1Choice_? ProductCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductCategory1Choice_? ProductCategory { get; init; } 
    #else
    public ProductCategory1Choice_? ProductCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Unique global serial identifier for this product instance.
    /// </summary>
    [IsoId("_KXJkbcNUEeWGDrnsYu2p6g")]
    [DisplayName("Global Serial Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GblSrlIdr")]
    #endif
    [IsoXmlTag("GblSrlIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? GlobalSerialIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GlobalSerialIdentifier { get; init; } 
    #else
    public System.String? GlobalSerialIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
