// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the energy delivery profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ohWt4BVoEeWXLoZC9OIRgg")]
[Description(@"Specifies the energy delivery profile.")]
[DerivedFrom(typeof(EnergyLoadTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EnergyLoadType1Code>))]
#endif
public enum EnergyLoadType1Code
{
    /// <summary>
    /// Base load.
    /// Encoded/decoded by serializers as &quot;BSLD&quot;.
    /// </summary>
    [EnumMember(Value = "BSLD")]
    [IsoId("_rT4f4RVoEeWXLoZC9OIRgg")]
    [Description(@"Base load.")]
    BaseLoad = EnergyLoadTypeCode.BaseLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gas day.
    /// Encoded/decoded by serializers as &quot;GASD&quot;.
    /// </summary>
    [EnumMember(Value = "GASD")]
    [IsoId("_rf7X0RVoEeWXLoZC9OIRgg")]
    [Description(@"Gas day.")]
    GasDay = EnergyLoadTypeCode.GasDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hour and block hours.
    /// Encoded/decoded by serializers as &quot;HABH&quot;.
    /// </summary>
    [EnumMember(Value = "HABH")]
    [IsoId("_rsRxwRVoEeWXLoZC9OIRgg")]
    [Description(@"Hour and block hours.")]
    HourAndBlockHours = EnergyLoadTypeCode.HourAndBlockHours, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Off-Peak.
    /// Encoded/decoded by serializers as &quot;OFFP&quot;.
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_r4VQwRVoEeWXLoZC9OIRgg")]
    [Description(@"Off-Peak.|")]
    Off_Peak = EnergyLoadTypeCode.Off_Peak, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_sEYIsRVoEeWXLoZC9OIRgg")]
    [Description(@"Other.")]
    Other = EnergyLoadTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Peak load.
    /// Encoded/decoded by serializers as &quot;PKLD&quot;.
    /// </summary>
    [EnumMember(Value = "PKLD")]
    [IsoId("_sQbnsRVoEeWXLoZC9OIRgg")]
    [Description(@"Peak load.")]
    PeakLoad = EnergyLoadTypeCode.PeakLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Shaped.
    /// Encoded/decoded by serializers as &quot;SHPD&quot;.
    /// </summary>
    [EnumMember(Value = "SHPD")]
    [IsoId("_scVVsRVoEeWXLoZC9OIRgg")]
    [Description(@"Shaped.")]
    Shaped = EnergyLoadTypeCode.Shaped, // same ordinal as derivation source for type conversions
}
