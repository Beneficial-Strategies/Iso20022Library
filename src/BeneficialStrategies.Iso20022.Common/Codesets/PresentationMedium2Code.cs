// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Presentation medium type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcK2AFzGEeeDqe2giKl0eQ")]
[Description(@"Presentation medium type.")]
[DerivedFrom(typeof(PresentationMediumCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PresentationMedium2Code>))]
#endif
public enum PresentationMedium2Code
{
    /// <summary>
    /// Biometric medium.
    /// Encoded/decoded by serializers as &quot;BIOM&quot;.
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_NnVqMX0kEemfrNOe0zHQyg")]
    [Description(@"Biometric medium.")]
    Biometric = PresentationMediumCode.Biometric, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Presentation is made electronically.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_NnVqM30kEemfrNOe0zHQyg")]
    [Description(@"Presentation is made electronically.")]
    Electronic = PresentationMediumCode.Electronic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Presentation is made on paper.
    /// Encoded/decoded by serializers as &quot;PAPR&quot;.
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_NnVqNX0kEemfrNOe0zHQyg")]
    [Description(@"Presentation is made on paper.")]
    Paper = PresentationMediumCode.Paper, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Presentation is made on paper and/or electronically.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_NnVqN30kEemfrNOe0zHQyg")]
    [Description(@"Presentation is made on paper and/or electronically.")]
    PaperElectronic = PresentationMediumCode.PaperElectronic, // same ordinal as derivation source for type conversions
}
