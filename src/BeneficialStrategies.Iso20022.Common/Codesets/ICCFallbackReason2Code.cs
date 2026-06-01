// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A code that provides the reason of ICC fallback.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QV-Q8Sd-EfCJ9IDAfAjwLA")]
[Description(@"A code that provides the reason of ICC fallback.")]
[DerivedFrom(typeof(ICCFallbackReasonCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ICCFallbackReason2Code>))]
public enum ICCFallbackReason2Code
{
    /// <summary>
    /// Choosing incorrect IC application.
    /// Encoded/decoded by serializers as &quot;CIIA&quot;.
    /// </summary>
    [EnumMember(Value = "CIIA")]
    [IsoId("_QYYEsSd-EfCJ9IDAfAjwLA")]
    [Description(@"Choosing incorrect IC application.")]
    ChoosingIncorrectICApplication = ICCFallbackReasonCode.ChoosingIncorrectICApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Error during IC app processing.
    /// Encoded/decoded by serializers as &quot;EDIP&quot;.
    /// </summary>
    [EnumMember(Value = "EDIP")]
    [IsoId("_QYYEsyd-EfCJ9IDAfAjwLA")]
    [Description(@"Error during IC app processing.")]
    ErrorDuringICAppProcessing = ICCFallbackReasonCode.ErrorDuringICAppProcessing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal error reading IC data.
    /// Encoded/decoded by serializers as &quot;TERI&quot;.
    /// </summary>
    [EnumMember(Value = "TERI")]
    [IsoId("_QYYEuSd-EfCJ9IDAfAjwLA")]
    [Description(@"Terminal error reading IC data.")]
    TerminalErrorReadingICData = ICCFallbackReasonCode.TerminalErrorReadingICData, // same ordinal as derivation source for type conversions
}
