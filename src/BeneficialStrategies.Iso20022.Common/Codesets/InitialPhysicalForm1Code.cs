// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the physical form of the securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hblKnGliEeGaMcKyqKNRfQ_-1870538349")]
[Description(@"Indicates the physical form of the securities.")]
[DerivedFrom(typeof(InitialPhysicalFormCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InitialPhysicalForm1Code>))]
#endif
public enum InitialPhysicalForm1Code
{
    /// <summary>
    /// Initial Physical Form is GT.
    /// Encoded/decoded by serializers as &quot;GTGT&quot;.
    /// </summary>
    [EnumMember(Value = "GTGT")]
    [IsoId("_hblKnWliEeGaMcKyqKNRfQ_-933244343")]
    [Description(@"Initial Physical Form is GT.")]
    GT = InitialPhysicalFormCode.GT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Initial Physical Form is GP.
    /// Encoded/decoded by serializers as &quot;GPGP&quot;.
    /// </summary>
    [EnumMember(Value = "GPGP")]
    [IsoId("_hblKnmliEeGaMcKyqKNRfQ_1809811702")]
    [Description(@"Initial Physical Form is GP.")]
    GP = InitialPhysicalFormCode.GP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Initial Physical Form is definitive.
    /// Encoded/decoded by serializers as &quot;DERN&quot;.
    /// </summary>
    [EnumMember(Value = "DERN")]
    [IsoId("_hblKn2liEeGaMcKyqKNRfQ_-2031068325")]
    [Description(@"Initial Physical Form is definitive.")]
    Definitive = InitialPhysicalFormCode.Definitive, // same ordinal as derivation source for type conversions
}
