// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Attributes of certificate extensions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xXLcMI4TEeW6h7rGyYlyTg")]
[Description(@"Attributes of certificate extensions.")]
[DerivedFrom(typeof(AttributeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AttributeType2Code>))]
#endif
public enum AttributeType2Code
{
    /// <summary>
    /// Email address of the certificate subject.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_56IUsY4TEeW6h7rGyYlyTg")]
    [Description(@"Email address of the certificate subject.")]
    EmailAddress = AttributeTypeCode.EmailAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Password by which an entity may request certificate revocation.
    /// Encoded/decoded by serializers as &quot;CHLG&quot;.
    /// </summary>
    [EnumMember(Value = "CHLG")]
    [IsoId("_6f_a044TEeW6h7rGyYlyTg")]
    [Description(@"Password by which an entity may request certificate revocation.")]
    ChallengePassword = AttributeTypeCode.ChallengePassword, // same ordinal as derivation source for type conversions
}
