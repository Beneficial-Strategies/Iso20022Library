// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Grains Oil Seeds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2EcYgA2eEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Grains Oil Seeds.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType1Code
{
    /// <summary>
    /// Commodity attribute of type feed wheat.
    /// Encoded/decoded by serializers as &quot;FWHT&quot;.
    /// </summary>
    [EnumMember(Value = "FWHT")]
    [IsoId("_96wFSSY7EeWAO6hFQSFUmw")]
    [Description(@"Commodity attribute of type feed wheat.")]
    FeedWheat = AssetClassDetailedSubProductTypeCode.FeedWheat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type soybeans.
    /// Encoded/decoded by serializers as &quot;SOYB&quot;.
    /// </summary>
    [EnumMember(Value = "SOYB")]
    [IsoId("_96wFSiY7EeWAO6hFQSFUmw")]
    [Description(@"Commodity attribute of type soybeans.")]
    Soybeans = AssetClassDetailedSubProductTypeCode.Soybeans, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type rapeseed.
    /// Encoded/decoded by serializers as &quot;RPSD&quot;.
    /// </summary>
    [EnumMember(Value = "RPSD")]
    [IsoId("_96wFRyY7EeWAO6hFQSFUmw")]
    [Description(@"Commodity attribute of type rapeseed.")]
    Rapeseed = AssetClassDetailedSubProductTypeCode.Rapeseed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_96wFSyY7EeWAO6hFQSFUmw")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type maize.
    /// Encoded/decoded by serializers as &quot;CORN&quot;.
    /// </summary>
    [EnumMember(Value = "CORN")]
    [IsoId("_96wFSCY7EeWAO6hFQSFUmw")]
    [Description(@"Commodity attribute of type maize.")]
    Maize = AssetClassDetailedSubProductTypeCode.Maize, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type rice.
    /// Encoded/decoded by serializers as &quot;RICE&quot;.
    /// </summary>
    [EnumMember(Value = "RICE")]
    [IsoId("_C5a1AfwfEeW4Wthd0Ze_kA")]
    [Description(@"Commodity attribute of type rice.")]
    Rice = AssetClassDetailedSubProductTypeCode.Rice, // same ordinal as derivation source for type conversions
}
