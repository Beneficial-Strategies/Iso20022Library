// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the charateristics of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZVRrVtp-Ed-ak6NoX_4Aeg_1283559943")]
[Description(@"Specifies the charateristics of a product.")]
[DerivedFrom(typeof(ProductCharacteristicsCode))]
public enum ProductCharacteristics1Code
{
    /// <summary>
    /// Detailed product information as assigned by the buyer.
    /// Encoded/decoded by serializers as &quot;BISP&quot;.
    /// </summary>
    [EnumMember(Value = "BISP")]
    [IsoId("_ZVRrV9p-Ed-ak6NoX_4Aeg_1337126065")]
    [Description(@"Detailed product information as assigned by the buyer.")]
    BuyersItemSpecification = ProductCharacteristicsCode.BuyersItemSpecification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unique identifier affixed by manufacturer to a chassis for identification purposes.
    /// Encoded/decoded by serializers as &quot;CHNR&quot;.
    /// </summary>
    [EnumMember(Value = "CHNR")]
    [IsoId("_ZVRrWNp-Ed-ak6NoX_4Aeg_1337126747")]
    [Description(
        @"Unique identifier affixed by manufacturer to a chassis for identification purposes."
    )]
    ChassisNumber = ProductCharacteristicsCode.ChassisNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indication of the product colour.
    /// Encoded/decoded by serializers as &quot;CLOR&quot;.
    /// </summary>
    [EnumMember(Value = "CLOR")]
    [IsoId("_ZVa1QNp-Ed-ak6NoX_4Aeg_1337127090")]
    [Description(@"Indication of the product colour.")]
    Colour = ProductCharacteristicsCode.Colour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The total of the volume used for combustion inside the cylinders of an engine. This is expressed in cubic centimetres.
    /// Encoded/decoded by serializers as &quot;EDSP&quot;.
    /// </summary>
    [EnumMember(Value = "EDSP")]
    [IsoId("_ZVa1Qdp-Ed-ak6NoX_4Aeg_1337127305")]
    [Description(
        @"The total of the volume used for combustion inside the cylinders of an engine. This is expressed in cubic centimetres."
    )]
    EngineDisplacement = ProductCharacteristicsCode.EngineDisplacement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unique identifier affixed by manufacturer to an engine for identification purposes.
    /// Encoded/decoded by serializers as &quot;ENNR&quot;.
    /// </summary>
    [EnumMember(Value = "ENNR")]
    [IsoId("_ZVa1Qtp-Ed-ak6NoX_4Aeg_1337127600")]
    [Description(
        @"Unique identifier affixed by manufacturer to an engine for identification purposes."
    )]
    EngineNumber = ProductCharacteristicsCode.EngineNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifier of a sub-category of a product such as size, colour, etc.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_ZVa1Q9p-Ed-ak6NoX_4Aeg_1338047709")]
    [Description(@"Identifier of a sub-category of a product such as size, colour, etc.")]
    Option = ProductCharacteristicsCode.Option, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code assigned to the product describing how it will be stored.
    /// Encoded/decoded by serializers as &quot;ORCR&quot;.
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("_ZVa1RNp-Ed-ak6NoX_4Aeg_1338047822")]
    [Description(@"Code assigned to the product describing how it will be stored.")]
    OriginCriterion = ProductCharacteristicsCode.OriginCriterion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage by volume.
    /// Encoded/decoded by serializers as &quot;PCTV&quot;.
    /// </summary>
    [EnumMember(Value = "PCTV")]
    [IsoId("_ZVa1Rdp-Ed-ak6NoX_4Aeg_1338048194")]
    [Description(@"Percentage by volume.")]
    PercentageByVolume = ProductCharacteristicsCode.PercentageByVolume, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Detailed product information as assigned by the seller.
    /// Encoded/decoded by serializers as &quot;SISP&quot;.
    /// </summary>
    [EnumMember(Value = "SISP")]
    [IsoId("_ZVa1Rtp-Ed-ak6NoX_4Aeg_1338048615")]
    [Description(@"Detailed product information as assigned by the seller.")]
    SellersItemSpecification = ProductCharacteristicsCode.SellersItemSpecification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indication of the product size.
    /// Encoded/decoded by serializers as &quot;SIZE&quot;.
    /// </summary>
    [EnumMember(Value = "SIZE")]
    [IsoId("_ZVa1R9p-Ed-ak6NoX_4Aeg_1338048890")]
    [Description(@"Indication of the product size.")]
    Size = ProductCharacteristicsCode.Size, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Range of product sizes.
    /// Encoded/decoded by serializers as &quot;SZRG&quot;.
    /// </summary>
    [EnumMember(Value = "SZRG")]
    [IsoId("_ZVa1SNp-Ed-ak6NoX_4Aeg_1338049587")]
    [Description(@"Range of product sizes.")]
    SizeRange = ProductCharacteristicsCode.SizeRange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Special remarks about a product.
    /// Encoded/decoded by serializers as &quot;SPRM&quot;.
    /// </summary>
    [EnumMember(Value = "SPRM")]
    [IsoId("_ZVa1Sdp-Ed-ak6NoX_4Aeg_1338050227")]
    [Description(@"Special remarks about a product.")]
    SpecialRemarks = ProductCharacteristicsCode.SpecialRemarks, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code assigned to the product describing how it will be stored.
    /// Encoded/decoded by serializers as &quot;STOR&quot;.
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_ZVkmQNp-Ed-ak6NoX_4Aeg_1338050578")]
    [Description(@"Code assigned to the product describing how it will be stored.")]
    StorageCode = ProductCharacteristicsCode.StorageCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The identification number which uniquely distinguishes one vehicle from another through the lifespan of the vehicle.
    /// Encoded/decoded by serializers as &quot;VINR&quot;.
    /// </summary>
    [EnumMember(Value = "VINR")]
    [IsoId("_ZVkmQdp-Ed-ak6NoX_4Aeg_1338051148")]
    [Description(
        @"The identification number which uniquely distinguishes one vehicle from another through the lifespan of the vehicle."
    )]
    VehicleIdentificationNumber = ProductCharacteristicsCode.VehicleIdentificationNumber, // same ordinal as derivation source for type conversions
}
