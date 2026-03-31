// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for which the key has been stopped.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_x-5LMItDEeSxlKlAGYErFg")]
[Description(@"Reason for which the key has been stopped.")]
[DerivedFrom(typeof(FailureReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FailureReason6Code>))]
#endif
public enum FailureReason6Code
{
    /// <summary>
    /// Key is compromised.
    /// Encoded/decoded by serializers as &quot;CMPR&quot;.
    /// </summary>
    [EnumMember(Value = "CMPR")]
    [IsoId("_6MpPwYtDEeSxlKlAGYErFg")]
    [Description(@"Key is compromised.")]
    Compromised = FailureReasonCode.Compromised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key has expired.
    /// Encoded/decoded by serializers as &quot;EXPR&quot;.
    /// </summary>
    [EnumMember(Value = "EXPR")]
    [IsoId("_6XX5EYtDEeSxlKlAGYErFg")]
    [Description(@"Key has expired.")]
    Expired = FailureReasonCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key check value is incorrect.
    /// Encoded/decoded by serializers as &quot;KCVE&quot;.
    /// </summary>
    [EnumMember(Value = "KCVE")]
    [IsoId("_7HWkgYtDEeSxlKlAGYErFg")]
    [Description(@"Key check value is incorrect.")]
    InvalidKCV = FailureReasonCode.InvalidKCV, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Error during the key download in the security device.
    /// Encoded/decoded by serializers as &quot;KLOD&quot;.
    /// </summary>
    [EnumMember(Value = "KLOD")]
    [IsoId("_7N6fgYtDEeSxlKlAGYErFg")]
    [Description(@"Error during the key download in the security device.")]
    KeyLoadError = FailureReasonCode.KeyLoadError, // same ordinal as derivation source for type conversions
}
