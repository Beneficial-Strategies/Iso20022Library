// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of integration of the POI terminal in the sale environment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3eb_cFDdEeu8Rss-tto59A")]
[Description(@"Indicates the type of integration of the POI terminal in the sale environment.")]
[DerivedFrom(typeof(LocationCategoryV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LocationCategory4Code>))]
#endif
public enum LocationCategory4Code
{
    /// <summary>
    /// Aboard is used when the sale is done in a vehicle (e.g a bus, train, ship, airplane,
    /// taxi, etc).
    /// Encoded/decoded by serializers as &quot;ABRD&quot;.
    /// </summary>
    [EnumMember(Value = "ABRD")]
    [IsoId("_nvDDhFDfEeu8Rss-tto59A")]
    [Description(
        @"Aboard is used when the sale is done in a vehicle (e.g a bus, train, ship, airplane,|taxi, etc)."
    )]
    Aboard = LocationCategoryV2Code.Aboard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Nomadic is used when the merchant is traveling to different locations (e.g fair or
    /// sport events, home delivery, food truck).
    /// Encoded/decoded by serializers as &quot;NMDC&quot;.
    /// </summary>
    [EnumMember(Value = "NMDC")]
    [IsoId("_nvMNcFDfEeu8Rss-tto59A")]
    [Description(
        @"Nomadic is used when the merchant is traveling to different locations (e.g fair or|sport events, home delivery, food truck)."
    )]
    Nomadic = LocationCategoryV2Code.Nomadic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fixed location, for example in a shop.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_nvMNcVDfEeu8Rss-tto59A")]
    [Description(@"Fixed location, for example in a shop.")]
    PhysicalShop = LocationCategoryV2Code.PhysicalShop, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Virtual Shop is used for any ecommerce solution.
    /// Encoded/decoded by serializers as &quot;VIRT&quot;.
    /// </summary>
    [EnumMember(Value = "VIRT")]
    [IsoId("_nvMNclDfEeu8Rss-tto59A")]
    [Description(@"Virtual Shop is used for any ecommerce solution.")]
    VirtualShop = LocationCategoryV2Code.VirtualShop, // same ordinal as derivation source for type conversions
}
