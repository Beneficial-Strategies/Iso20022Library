// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if the deal price is excluding or including the accrued interest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__215cNojEeC60axPepSq7g_96023160")]
[Description(@"Indicates if the deal price is excluding or including the accrued interest.")]
[DerivedFrom(typeof(InterestTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InterestType2Code>))]
#endif
public enum InterestType2Code
{
    /// <summary>
    /// Indicates deal price including accrued interest.
    /// Encoded/decoded by serializers as &quot;CINT&quot;.
    /// </summary>
    [EnumMember(Value = "CINT")]
    [IsoId("__215cdojEeC60axPepSq7g_717130324")]
    [Description(@"Indicates deal price including accrued interest.")]
    CumInterest = InterestTypeCode.CumInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates deal price excluding accrued interest.
    /// Encoded/decoded by serializers as &quot;XINT&quot;.
    /// </summary>
    [EnumMember(Value = "XINT")]
    [IsoId("__215ctojEeC60axPepSq7g_1303077350")]
    [Description(@"Indicates deal price excluding accrued interest.")]
    ExInterest = InterestTypeCode.ExInterest, // same ordinal as derivation source for type conversions
}
