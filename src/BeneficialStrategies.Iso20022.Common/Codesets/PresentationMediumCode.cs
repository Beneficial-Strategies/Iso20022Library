// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the presentation medium.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oH14wHyeEeGWJuGCfvwOsQ")]
[Description(@"Specifies the presentation medium.")]
[Derivations(typeof(PresentationMedium1Code), typeof(PresentationMedium2Code))]
public enum PresentationMediumCode
{
    /// <summary>
    /// Presentation is made on paper.
    /// Encoded/decoded by serializers as &quot;PAPR&quot;.
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_FoZMkHyfEeGWJuGCfvwOsQ")]
    [Description(@"Presentation is made on paper.")]
    Paper,

    /// <summary>
    /// Presentation is made electronically.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_M637sHyfEeGWJuGCfvwOsQ")]
    [Description(@"Presentation is made electronically.")]
    Electronic,

    /// <summary>
    /// Presentation is made on paper and/or electronically.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_TXGYQHyfEeGWJuGCfvwOsQ")]
    [Description(@"Presentation is made on paper and/or electronically.")]
    PaperElectronic,

    /// <summary>
    /// Biometric medium.
    /// Encoded/decoded by serializers as &quot;BIOM&quot;.
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_NnSYYXyLEemHsOqJOzMVfg")]
    [Description(@"Biometric medium.")]
    Biometric,
}
