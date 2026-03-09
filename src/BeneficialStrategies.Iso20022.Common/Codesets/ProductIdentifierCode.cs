// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of identifier of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZV3hOdp-Ed-ak6NoX_4Aeg_1219289935")]
[Description(@"Specifies the type of identifier of a product.")]
[Derivations(typeof(ProductIdentifier2Code))]
public enum ProductIdentifierCode
{
    /// <summary>
    /// Product identifier assigned by the buyer.
    /// Encoded/decoded by serializers as &quot;BINR&quot;.
    /// </summary>
    [EnumMember(Value = "BINR")]
    [IsoId("_ZWBSMNp-Ed-ak6NoX_4Aeg_1324571761")]
    [Description(@"Product identifier assigned by the buyer.")]
    BuyersItemNumber,
    
    /// <summary>
    /// A code to identify a product based on applicable commercial conditions.
    /// Encoded/decoded by serializers as &quot;COMD&quot;.
    /// </summary>
    [EnumMember(Value = "COMD")]
    [IsoId("_ZWBSMdp-Ed-ak6NoX_4Aeg_1362437144")]
    [Description(@"A code to identify a product based on applicable commercial conditions.")]
    CommercialDescriptionCodeName,
    
    /// <summary>
    /// The unique EAN (European Article Number) code.
    /// Encoded/decoded by serializers as &quot;EANC&quot;.
    /// </summary>
    [EnumMember(Value = "EANC")]
    [IsoId("_ZWBSMtp-Ed-ak6NoX_4Aeg_1363358278")]
    [Description(@"The unique EAN (European Article Number) code.")]
    EAN,
    
    /// <summary>
    /// Classification of goods as developed by the Customs Cooperation council.
    /// Encoded/decoded by serializers as &quot;HRTR&quot;.
    /// </summary>
    [EnumMember(Value = "HRTR")]
    [IsoId("_ZWBSM9p-Ed-ak6NoX_4Aeg_1363359641")]
    [Description(@"Classification of goods as developed by the Customs Cooperation council.")]
    HarmonizedTariffCodeName,
    
    /// <summary>
    /// Product identifier as assigned by the manufacturer.
    /// Encoded/decoded by serializers as &quot;MANI&quot;.
    /// </summary>
    [EnumMember(Value = "MANI")]
    [IsoId("_ZWBSNNp-Ed-ak6NoX_4Aeg_1363361086")]
    [Description(@"Product identifier as assigned by the manufacturer.")]
    ManufacturersItemNumber,
    
    /// <summary>
    /// Reference number assigned by the manufacturer to differentiate variations in similar products in a class or group.
    /// Encoded/decoded by serializers as &quot;MODL&quot;.
    /// </summary>
    [EnumMember(Value = "MODL")]
    [IsoId("_ZWBSNdp-Ed-ak6NoX_4Aeg_1364282208")]
    [Description(@"Reference number assigned by the manufacturer to differentiate variations in similar products in a class or group.")]
    ModelNumber,
    
    /// <summary>
    /// Reference assigned by the manufacturer to a product part.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZWBSNtp-Ed-ak6NoX_4Aeg_1364283678")]
    [Description(@"Reference assigned by the manufacturer to a product part.")]
    PartNumber,
    
    /// <summary>
    /// Product identifier used by the retail industry.
    /// Encoded/decoded by serializers as &quot;QOTA&quot;.
    /// </summary>
    [EnumMember(Value = "QOTA")]
    [IsoId("_ZWBSN9p-Ed-ak6NoX_4Aeg_1364285059")]
    [Description(@"Product identifier used by the retail industry.")]
    QuotaCategory,
    
    /// <summary>
    /// Identification of the style of a product.
    /// Encoded/decoded by serializers as &quot;STYL&quot;.
    /// </summary>
    [EnumMember(Value = "STYL")]
    [IsoId("_ZWBSONp-Ed-ak6NoX_4Aeg_1780791760")]
    [Description(@"Identification of the style of a product.")]
    StyleNumber,
    
    /// <summary>
    /// Number assigned to an article by the supplier of that article.
    /// Encoded/decoded by serializers as &quot;SUPI&quot;.
    /// </summary>
    [EnumMember(Value = "SUPI")]
    [IsoId("_ZWBSOdp-Ed-ak6NoX_4Aeg_-155980102")]
    [Description(@"Number assigned to an article by the supplier of that article.")]
    SuppliersItemNumber,
    
    /// <summary>
    /// Number assigned to a manufacturer&apos;s product by the Product Code Council.
    /// Encoded/decoded by serializers as &quot;UPCC&quot;.
    /// </summary>
    [EnumMember(Value = "UPCC")]
    [IsoId("_ZWKcINp-Ed-ak6NoX_4Aeg_-155980059")]
    [Description(@"Number assigned to a manufacturer's product by the Product Code Council.")]
    UniversalProductCode,
    
}
