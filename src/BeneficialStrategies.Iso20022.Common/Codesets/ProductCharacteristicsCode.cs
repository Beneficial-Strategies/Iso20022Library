// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the charateristics of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZVkmQtp-Ed-ak6NoX_4Aeg_-499524855")]
[Description(@"Specifies the charateristics of a product.")]
[Derivations(typeof(ProductCharacteristics1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProductCharacteristicsCode>))]
#endif
public enum ProductCharacteristicsCode
{
    /// <summary>
    /// Detailed product information as assigned by the buyer.
    /// Encoded/decoded by serializers as &quot;BISP&quot;.
    /// </summary>
    [EnumMember(Value = "BISP")]
    [IsoId("_ZVkmQ9p-Ed-ak6NoX_4Aeg_461860613")]
    [Description(@"Detailed product information as assigned by the buyer.")]
    BuyersItemSpecification,

    /// <summary>
    /// Unique identifier affixed by manufacturer to a chassis for identification purposes.
    /// Encoded/decoded by serializers as &quot;CHNR&quot;.
    /// </summary>
    [EnumMember(Value = "CHNR")]
    [IsoId("_ZVkmRNp-Ed-ak6NoX_4Aeg_542206889")]
    [Description(
        @"Unique identifier affixed by manufacturer to a chassis for identification purposes."
    )]
    ChassisNumber,

    /// <summary>
    /// Indication of the product colour.
    /// Encoded/decoded by serializers as &quot;CLOR&quot;.
    /// </summary>
    [EnumMember(Value = "CLOR")]
    [IsoId("_ZVkmRdp-Ed-ak6NoX_4Aeg_834961978")]
    [Description(@"Indication of the product colour.")]
    Colour,

    /// <summary>
    /// The total of the volume used for combustion inside the cylinders of an engine. This is expressed in cubic centimetres.
    /// Encoded/decoded by serializers as &quot;EDSP&quot;.
    /// </summary>
    [EnumMember(Value = "EDSP")]
    [IsoId("_ZVkmRtp-Ed-ak6NoX_4Aeg_949480973")]
    [Description(
        @"The total of the volume used for combustion inside the cylinders of an engine. This is expressed in cubic centimetres."
    )]
    EngineDisplacement,

    /// <summary>
    /// Unique identifier affixed by manufacturer to an engine for identification purposes.
    /// Encoded/decoded by serializers as &quot;ENNR&quot;.
    /// </summary>
    [EnumMember(Value = "ENNR")]
    [IsoId("_ZVkmR9p-Ed-ak6NoX_4Aeg_-1017884541")]
    [Description(
        @"Unique identifier affixed by manufacturer to an engine for identification purposes."
    )]
    EngineNumber,

    /// <summary>
    /// Identifier of a sub-category of a product such as size, colour, etc.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_ZVkmSNp-Ed-ak6NoX_4Aeg_-687264519")]
    [Description(@"Identifier of a sub-category of a product such as size, colour, etc.")]
    Option,

    /// <summary>
    /// Code assigned to the product describing how it will be stored.
    /// Encoded/decoded by serializers as &quot;ORCR&quot;.
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("_ZVkmSdp-Ed-ak6NoX_4Aeg_-559821323")]
    [Description(@"Code assigned to the product describing how it will be stored.")]
    OriginCriterion,

    /// <summary>
    /// Percentage by volume.
    /// Encoded/decoded by serializers as &quot;PCTV&quot;.
    /// </summary>
    [EnumMember(Value = "PCTV")]
    [IsoId("_ZVuXQNp-Ed-ak6NoX_4Aeg_-230121438")]
    [Description(@"Percentage by volume.")]
    PercentageByVolume,

    /// <summary>
    /// Detailed product information as assigned by the seller.
    /// Encoded/decoded by serializers as &quot;SISP&quot;.
    /// </summary>
    [EnumMember(Value = "SISP")]
    [IsoId("_ZVuXQdp-Ed-ak6NoX_4Aeg_-111911387")]
    [Description(@"Detailed product information as assigned by the seller.")]
    SellersItemSpecification,

    /// <summary>
    /// Indication of the product size.
    /// Encoded/decoded by serializers as &quot;SIZE&quot;.
    /// </summary>
    [EnumMember(Value = "SIZE")]
    [IsoId("_ZVuXQtp-Ed-ak6NoX_4Aeg_-27873272")]
    [Description(@"Indication of the product size.")]
    Size,

    /// <summary>
    /// Range of product sizes.
    /// Encoded/decoded by serializers as &quot;SZRG&quot;.
    /// </summary>
    [EnumMember(Value = "SZRG")]
    [IsoId("_ZVuXQ9p-Ed-ak6NoX_4Aeg_257497938")]
    [Description(@"Range of product sizes.")]
    SizeRange,

    /// <summary>
    /// Special remarks about a product.
    /// Encoded/decoded by serializers as &quot;SPRM&quot;.
    /// </summary>
    [EnumMember(Value = "SPRM")]
    [IsoId("_ZVuXRNp-Ed-ak6NoX_4Aeg_357238226")]
    [Description(@"Special remarks about a product.")]
    SpecialRemarks,

    /// <summary>
    /// Code assigned to the product describing how it will be stored.
    /// Encoded/decoded by serializers as &quot;STOR&quot;.
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_ZVuXRdp-Ed-ak6NoX_4Aeg_699863026")]
    [Description(@"Code assigned to the product describing how it will be stored.")]
    StorageCode,

    /// <summary>
    /// The identification number which uniquely distinguishes one vehicle from another through the lifespan of the vehicle.
    /// Encoded/decoded by serializers as &quot;VINR&quot;.
    /// </summary>
    [EnumMember(Value = "VINR")]
    [IsoId("_ZVuXRtp-Ed-ak6NoX_4Aeg_770975141")]
    [Description(
        @"The identification number which uniquely distinguishes one vehicle from another through the lifespan of the vehicle."
    )]
    VehicleIdentificationNumber,
}
