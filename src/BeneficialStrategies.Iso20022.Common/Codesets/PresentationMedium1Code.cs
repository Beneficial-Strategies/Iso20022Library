// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the presentation medium.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gd2zIHyfEeGWJuGCfvwOsQ")]
[Description(@"Specifies the presentation medium.")]
[DerivedFrom(typeof(PresentationMediumCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PresentationMedium1Code>))]
#endif
public enum PresentationMedium1Code
{
    /// <summary>
    /// Presentation is made on paper and/or electronically.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_nvSZZnyfEeGWJuGCfvwOsQ")]
    [Description(@"Presentation is made on paper and/or electronically.")]
    PaperElectronic = PresentationMediumCode.PaperElectronic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Presentation is made electronically.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_n3yOFnyfEeGWJuGCfvwOsQ")]
    [Description(@"Presentation is made electronically.")]
    Electronic = PresentationMediumCode.Electronic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Presentation is made on paper.
    /// Encoded/decoded by serializers as &quot;PAPR&quot;.
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_n_Yq5nyfEeGWJuGCfvwOsQ")]
    [Description(@"Presentation is made on paper.")]
    Paper = PresentationMediumCode.Paper, // same ordinal as derivation source for type conversions
}
