// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the validation of a signature used to sign the file.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8982sMmKEeWAGphE2LvqeA")]
[Description(@"Specifies the validation of a signature used to sign the file.")]
[DerivedFrom(typeof(ValidationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Validation1Code>))]
#endif
public enum Validation1Code
{
    /// <summary>
    /// Validation of the signature is successful.
    /// Encoded/decoded by serializers as &quot;OKAY&quot;.
    /// </summary>
    [EnumMember(Value = "OKAY")]
    [IsoId("_-T5V8smKEeWAGphE2LvqeA")]
    [Description(@"Validation of the signature is successful.")]
    ValidationSuccessful = ValidationCode.ValidationSuccessful, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation of the signature is unknown or not yet executed.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_-VFBscmKEeWAGphE2LvqeA")]
    [Description(@"Validation of the signature is unknown or not yet executed.")]
    ValidationUnkonwn = ValidationCode.ValidationUnkonwn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation of the signature has failed.
    /// Encoded/decoded by serializers as &quot;NTOK&quot;.
    /// </summary>
    [EnumMember(Value = "NTOK")]
    [IsoId("_UqKgocnIEeWI4cSIO9foRA")]
    [Description(@"Validation of the signature has failed.")]
    ValidationFailed = ValidationCode.ValidationFailed, // same ordinal as derivation source for type conversions
}
