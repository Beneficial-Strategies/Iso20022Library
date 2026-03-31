// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Electricity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_76AdsA2eEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Electricity.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassDetailedSubProductType5Code>))]
#endif
public enum AssetClassDetailedSubProductType5Code
{
    /// <summary>
    /// Commodity attribute of type base load.
    /// Encoded/decoded by serializers as &quot;BSLD&quot;.
    /// </summary>
    [EnumMember(Value = "BSLD")]
    [IsoId("_q8_4EQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type base load.")]
    BaseLoad = AssetClassDetailedSubProductTypeCode.BaseLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type financial transmission rights.
    /// Encoded/decoded by serializers as &quot;FITR&quot;.
    /// </summary>
    [EnumMember(Value = "FITR")]
    [IsoId("_sAsJsQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type financial transmission rights.")]
    FinancialTransmissionRights = AssetClassDetailedSubProductTypeCode.FinancialTransmissionRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type peak load.
    /// Encoded/decoded by serializers as &quot;PKLD&quot;.
    /// </summary>
    [EnumMember(Value = "PKLD")]
    [IsoId("_ueY7MQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type peak load.")]
    PeakLoad = AssetClassDetailedSubProductTypeCode.PeakLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type off-peak.
    /// Encoded/decoded by serializers as &quot;OFFP&quot;.
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_Vb9FgWs3EeW9oI9ZdgWHPQ")]
    [Description(@"Commodity attribute of type off-peak.")]
    OffPeak = AssetClassDetailedSubProductTypeCode.OffPeak, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_WDhb0ms3EeW9oI9ZdgWHPQ")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
}
