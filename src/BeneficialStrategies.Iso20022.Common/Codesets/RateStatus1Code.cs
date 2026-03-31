// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZY_ts9p-Ed-ak6NoX_4Aeg_1472885519")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RateStatus1Code>))]
#endif
public enum RateStatus1Code
{
    /// <summary>
    /// Rate is actual.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_ZY_ttNp-Ed-ak6NoX_4Aeg_1472885768")]
    [Description(@"Rate is actual.")]
    ActualRate = RateStatusCode.ActualRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate is indicative.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_ZY_ttdp-Ed-ak6NoX_4Aeg_1472885797")]
    [Description(@"Rate is indicative.")]
    IndicativeRate = RateStatusCode.IndicativeRate, // same ordinal as derivation source for type conversions
}
