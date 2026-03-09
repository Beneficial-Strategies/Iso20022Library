// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of identifier of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZVuXR9p-Ed-ak6NoX_4Aeg_1808391573")]
[Description(@"Specifies the type of identifier of a product.")]
[DerivedFrom(typeof(ProductIdentifierCode))]
public enum ProductIdentifier2Code
{
    /// <summary>
    /// Product identifier assigned by the buyer.
    /// Encoded/decoded by serializers as &quot;BINR&quot;.
    /// </summary>
    [EnumMember(Value = "BINR")]
    [IsoId("_ZVuXSNp-Ed-ak6NoX_4Aeg_1808391590")]
    [Description(@"Product identifier assigned by the buyer.")]
    BuyersItemNumber = ProductIdentifierCode.BuyersItemNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A code to identify a product based on applicable commercial conditions.
    /// Encoded/decoded by serializers as &quot;COMD&quot;.
    /// </summary>
    [EnumMember(Value = "COMD")]
    [IsoId("_ZVuXSdp-Ed-ak6NoX_4Aeg_1808391591")]
    [Description(@"A code to identify a product based on applicable commercial conditions.")]
    CommercialDescriptionCodeName = ProductIdentifierCode.CommercialDescriptionCodeName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The unique EAN (European Article Number) code.
    /// Encoded/decoded by serializers as &quot;EANC&quot;.
    /// </summary>
    [EnumMember(Value = "EANC")]
    [IsoId("_ZV3hMNp-Ed-ak6NoX_4Aeg_1808391608")]
    [Description(@"The unique EAN (European Article Number) code.")]
    EAN = ProductIdentifierCode.EAN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Classification of goods as developed by the Customs Cooperation council.
    /// Encoded/decoded by serializers as &quot;HRTR&quot;.
    /// </summary>
    [EnumMember(Value = "HRTR")]
    [IsoId("_ZV3hMdp-Ed-ak6NoX_4Aeg_1808391609")]
    [Description(@"Classification of goods as developed by the Customs Cooperation council.")]
    HarmonizedTariffCodeName = ProductIdentifierCode.HarmonizedTariffCodeName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product identifier as assigned by the manufacturer.
    /// Encoded/decoded by serializers as &quot;MANI&quot;.
    /// </summary>
    [EnumMember(Value = "MANI")]
    [IsoId("_ZV3hMtp-Ed-ak6NoX_4Aeg_1808391850")]
    [Description(@"Product identifier as assigned by the manufacturer.")]
    ManufacturersItemNumber = ProductIdentifierCode.ManufacturersItemNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reference number assigned by the manufacturer to differentiate variations in similar products in a class or group.
    /// Encoded/decoded by serializers as &quot;MODL&quot;.
    /// </summary>
    [EnumMember(Value = "MODL")]
    [IsoId("_ZV3hM9p-Ed-ak6NoX_4Aeg_1808391867")]
    [Description(@"Reference number assigned by the manufacturer to differentiate variations in similar products in a class or group.")]
    ModelNumber = ProductIdentifierCode.ModelNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reference assigned by the manufacturer to a product part.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZV3hNNp-Ed-ak6NoX_4Aeg_1808391868")]
    [Description(@"Reference assigned by the manufacturer to a product part.")]
    PartNumber = ProductIdentifierCode.PartNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product identifier used by the retail industry.
    /// Encoded/decoded by serializers as &quot;QOTA&quot;.
    /// </summary>
    [EnumMember(Value = "QOTA")]
    [IsoId("_ZV3hNdp-Ed-ak6NoX_4Aeg_1808391885")]
    [Description(@"Product identifier used by the retail industry.")]
    QuotaCategory = ProductIdentifierCode.QuotaCategory, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the style of a product.
    /// Encoded/decoded by serializers as &quot;STYL&quot;.
    /// </summary>
    [EnumMember(Value = "STYL")]
    [IsoId("_ZV3hNtp-Ed-ak6NoX_4Aeg_1808391886")]
    [Description(@"Identification of the style of a product.")]
    StyleNumber = ProductIdentifierCode.StyleNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned to an article by the supplier of that article.
    /// Encoded/decoded by serializers as &quot;SUPI&quot;.
    /// </summary>
    [EnumMember(Value = "SUPI")]
    [IsoId("_ZV3hN9p-Ed-ak6NoX_4Aeg_-2058986456")]
    [Description(@"Number assigned to an article by the supplier of that article.")]
    SuppliersItemNumber = ProductIdentifierCode.SuppliersItemNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned to a manufacturer&apos;s product by the Product Code Council.
    /// Encoded/decoded by serializers as &quot;UPCC&quot;.
    /// </summary>
    [EnumMember(Value = "UPCC")]
    [IsoId("_ZV3hONp-Ed-ak6NoX_4Aeg_-2016505606")]
    [Description(@"Number assigned to a manufacturer's product by the Product Code Council.")]
    UniversalProductCode = ProductIdentifierCode.UniversalProductCode, // same ordinal as derivation source for type conversions
    
}
