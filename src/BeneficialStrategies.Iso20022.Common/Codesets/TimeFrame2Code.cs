// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a time frame.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dMCBcMztEeq1WLK5fVzKiQ")]
[Description(@"Specifies a time frame.")]
[DerivedFrom(typeof(TimeFrameCode))]
public enum TimeFrame2Code
{
    /// <summary>
    /// Hold to maturity.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_ft5hQcztEeq1WLK5fVzKiQ")]
    [Description(@"Hold to maturity.")]
    Hold = TimeFrameCode.Hold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Greater than five years.
    /// Encoded/decoded by serializers as &quot;LONG&quot;.
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_f1VmAcztEeq1WLK5fVzKiQ")]
    [Description(@"Greater than five years.")]
    LongTerm = TimeFrameCode.LongTerm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Greater than or equal to three years.
    /// Encoded/decoded by serializers as &quot;MEDM&quot;.
    /// </summary>
    [EnumMember(Value = "MEDM")]
    [IsoId("_f9OWscztEeq1WLK5fVzKiQ")]
    [Description(@"Greater than or equal to three years.")]
    MediumTerm = TimeFrameCode.MediumTerm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Greater than or equal to one year.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_gHCaAcztEeq1WLK5fVzKiQ")]
    [Description(@"Greater than or equal to one year.")]
    ShortTerm = TimeFrameCode.ShortTerm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Less than one year.
    /// Encoded/decoded by serializers as &quot;VSHT&quot;.
    /// </summary>
    [EnumMember(Value = "VSHT")]
    [IsoId("_gM_4EcztEeq1WLK5fVzKiQ")]
    [Description(@"Less than one year.")]
    VeryShortTerm = TimeFrameCode.VeryShortTerm, // same ordinal as derivation source for type conversions
    
}
