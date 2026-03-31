// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a time frame.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EKEEgDccEeidBoT_PugKiA")]
[Description(@"Specifies a time frame.")]
[Derivations(typeof(TimeFrame1Code), typeof(TimeFrame2Code))]
public enum TimeFrameCode
{
    /// <summary>
    /// Less than one year.
    /// Encoded/decoded by serializers as &quot;VSHT&quot;.
    /// </summary>
    [EnumMember(Value = "VSHT")]
    [IsoId("_M-z3oDccEeidBoT_PugKiA")]
    [Description(@"Less than one year.")]
    VeryShortTerm,

    /// <summary>
    /// Greater than or equal to one year.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_REf6oDccEeidBoT_PugKiA")]
    [Description(@"Greater than or equal to one year.")]
    ShortTerm,

    /// <summary>
    /// Greater than or equal to three years.
    /// Encoded/decoded by serializers as &quot;MEDM&quot;.
    /// </summary>
    [EnumMember(Value = "MEDM")]
    [IsoId("_WWEh8DccEeidBoT_PugKiA")]
    [Description(@"Greater than or equal to three years.")]
    MediumTerm,

    /// <summary>
    /// Greater than five years.
    /// Encoded/decoded by serializers as &quot;LONG&quot;.
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_ZR0hYDccEeidBoT_PugKiA")]
    [Description(@"Greater than five years.")]
    LongTerm,

    /// <summary>
    /// Time frame is neutral.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_bgDTgDccEeidBoT_PugKiA")]
    [Description(@"Time frame is neutral.")]
    Neutral,

    /// <summary>
    /// Hold to maturity.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_3DJ9wIELEeiw-daIkkmMqQ")]
    [Description(@"Hold to maturity.")]
    Hold,
}
