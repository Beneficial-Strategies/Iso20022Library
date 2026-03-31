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
[IsoId("_hblKoGliEeGaMcKyqKNRfQ_-773946621")]
[Description(@"Indicates the physical form of the securities.")]
[DerivedFrom(typeof(InitialPhysicalFormCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InitialPhysicalForm2Code>))]
#endif
public enum InitialPhysicalForm2Code
{
    /// <summary>
    /// Initial Physical Form is GP.
    /// Encoded/decoded by serializers as &quot;GPGP&quot;.
    /// </summary>
    [EnumMember(Value = "GPGP")]
    [IsoId("_hbu7kGliEeGaMcKyqKNRfQ_1457267840")]
    [Description(@"Initial Physical Form is GP.")]
    GP = InitialPhysicalFormCode.GP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Initial Physical Form is definitive.
    /// Encoded/decoded by serializers as &quot;DERN&quot;.
    /// </summary>
    [EnumMember(Value = "DERN")]
    [IsoId("_hbu7kWliEeGaMcKyqKNRfQ_-428414513")]
    [Description(@"Initial Physical Form is definitive.")]
    Definitive = InitialPhysicalFormCode.Definitive, // same ordinal as derivation source for type conversions
}
