// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a time frame.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fFUKADccEeidBoT_PugKiA")]
[Description(@"Specifies a time frame.")]
[DerivedFrom(typeof(TimeFrameCode))]
public enum TimeFrame1Code
{
    /// <summary>
    /// Greater than five years.
    /// Encoded/decoded by serializers as &quot;LONG&quot;.
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_gS0e8TccEeidBoT_PugKiA")]
    [Description(@"Greater than five years.")]
    LongTerm = TimeFrameCode.LongTerm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Greater than or equal to three years.
    /// Encoded/decoded by serializers as &quot;MEDM&quot;.
    /// </summary>
    [EnumMember(Value = "MEDM")]
    [IsoId("_gWZXYTccEeidBoT_PugKiA")]
    [Description(@"Greater than or equal to three years.")]
    MediumTerm = TimeFrameCode.MediumTerm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Time frame is neutral.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_gatPoTccEeidBoT_PugKiA")]
    [Description(@"Time frame is neutral.")]
    Neutral = TimeFrameCode.Neutral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Greater than or equal to one year.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_gfBu8TccEeidBoT_PugKiA")]
    [Description(@"Greater than or equal to one year.")]
    ShortTerm = TimeFrameCode.ShortTerm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Less than one year.
    /// Encoded/decoded by serializers as &quot;VSHT&quot;.
    /// </summary>
    [EnumMember(Value = "VSHT")]
    [IsoId("_gjL2MTccEeidBoT_PugKiA")]
    [Description(@"Less than one year.")]
    VeryShortTerm = TimeFrameCode.VeryShortTerm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Hold to maturity.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_FlJAgYEMEeiw-daIkkmMqQ")]
    [Description(@"Hold to maturity.")]
    Hold = TimeFrameCode.Hold, // same ordinal as derivation source for type conversions
    
}
