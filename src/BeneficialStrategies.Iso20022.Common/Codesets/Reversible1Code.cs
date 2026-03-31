// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the possibility to terminate the securitiesc lending contract either by the borrower or lender before the expiration date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__v1ShtojEeC60axPepSq7g_1110549094")]
[Description(
    @"Indicates the possibility to terminate the securitiesc lending contract either by the borrower or lender before the expiration date."
)]
[DerivedFrom(typeof(ReversibleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Reversible1Code>))]
#endif
public enum Reversible1Code
{
    /// <summary>
    /// Securities lending contract can be ended by the borrower before the expiration date.
    /// Encoded/decoded by serializers as &quot;REVL&quot;.
    /// </summary>
    [EnumMember(Value = "REVL")]
    [IsoId("__v_DgNojEeC60axPepSq7g_-721289092")]
    [Description(
        @"Securities lending contract can be ended by the borrower before the expiration date."
    )]
    Reversible = ReversibleCode.Reversible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities lending contract can not be ended by the borrower before the expiration date.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("__v_DgdojEeC60axPepSq7g_745859671")]
    [Description(
        @"Securities lending contract can not be ended by the borrower before the expiration date."
    )]
    Fixed = ReversibleCode.Fixed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities lending contract can be ended by the lender before the expiration date.
    /// Encoded/decoded by serializers as &quot;CABK&quot;.
    /// </summary>
    [EnumMember(Value = "CABK")]
    [IsoId("__v_DgtojEeC60axPepSq7g_589215960")]
    [Description(
        @"Securities lending contract can be ended by the lender before the expiration date."
    )]
    CallBack = ReversibleCode.CallBack, // same ordinal as derivation source for type conversions
}
