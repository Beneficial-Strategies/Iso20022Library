// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the verification process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bABW4Eq_Eeenp6hmNprBHg")]
[Description(@"Result of the verification process.")]
[DerivedFrom(typeof(VerificationCode))]
public enum Verification2Code
{
    /// <summary>
    /// Verification failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_1vp8AX0mEemfrNOe0zHQyg")]
    [Description(@"Verification failed.")]
    Failed = VerificationCode.Failed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further action required.
    /// Encoded/decoded by serializers as &quot;FUTA&quot;.
    /// </summary>
    [EnumMember(Value = "FUTA")]
    [IsoId("_1vp8A30mEemfrNOe0zHQyg")]
    [Description(@"Further action required.")]
    FurtherAction = VerificationCode.FurtherAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information required to perform the verification was missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_1vp8BX0mEemfrNOe0zHQyg")]
    [Description(@"Information required to perform the verification was missing.")]
    Missing = VerificationCode.Missing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification has not been performed.
    /// Encoded/decoded by serializers as &quot;NOVF&quot;.
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_1vp8B30mEemfrNOe0zHQyg")]
    [Description(@"Verification has not been performed.")]
    NotPerformed = VerificationCode.NotPerformed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other result of verification defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_1vp8CX0mEemfrNOe0zHQyg")]
    [Description(@"Other result of verification defined at national level.")]
    OtherNational = VerificationCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other result of verification defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_1vp8C30mEemfrNOe0zHQyg")]
    [Description(@"Other result of verification defined at private level.")]
    OtherPrivate = VerificationCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification was partially successful.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_1vp8DX0mEemfrNOe0zHQyg")]
    [Description(@"Verification was partially successful.")]
    PartialMatch = VerificationCode.PartialMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification was successful.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_1vp8D30mEemfrNOe0zHQyg")]
    [Description(@"Verification was successful.")]
    Successful = VerificationCode.Successful, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Device or entity to perform the verification was unavailable.
    /// Encoded/decoded by serializers as &quot;ERRR&quot;.
    /// </summary>
    [EnumMember(Value = "ERRR")]
    [IsoId("_1vp8EX0mEemfrNOe0zHQyg")]
    [Description(@"Device or entity to perform the verification was unavailable.")]
    TechnicalError = VerificationCode.TechnicalError, // same ordinal as derivation source for type conversions
}
