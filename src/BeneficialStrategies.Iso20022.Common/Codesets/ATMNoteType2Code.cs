// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of notes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_d5H3YIqhEeS4a4abTJTSSw")]
[Description(@"Type of notes.")]
[DerivedFrom(typeof(ATMNoteTypeCode))]
public enum ATMNoteType2Code
{
    /// <summary>
    /// Detected counterfeit notes.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_lznowYqhEeS4a4abTJTSSw")]
    [Description(@"Detected counterfeit notes.")]
    Counterfeit = ATMNoteTypeCode.Counterfeit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fit bank notes.
    /// Encoded/decoded by serializers as &quot;FITN&quot;.
    /// </summary>
    [EnumMember(Value = "FITN")]
    [IsoId("_l5u30YqhEeS4a4abTJTSSw")]
    [Description(@"Fit bank notes.")]
    Fit = ATMNoteTypeCode.Fit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fit and unfit bank notes, if fitness cannot be determined.
    /// Encoded/decoded by serializers as &quot;FITU&quot;.
    /// </summary>
    [EnumMember(Value = "FITU")]
    [IsoId("_mBByoYqhEeS4a4abTJTSSw")]
    [Description(@"Fit and unfit bank notes, if fitness cannot be determined.")]
    FitAndUnfit = ATMNoteTypeCode.FitAndUnfit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notes stained by dye pack.
    /// Encoded/decoded by serializers as &quot;NTRL&quot;.
    /// </summary>
    [EnumMember(Value = "NTRL")]
    [IsoId("_m4m64YqhEeS4a4abTJTSSw")]
    [Description(@"Notes stained by dye pack.")]
    Neutralised = ATMNoteTypeCode.Neutralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Suspect notes.
    /// Encoded/decoded by serializers as &quot;SPCT&quot;.
    /// </summary>
    [EnumMember(Value = "SPCT")]
    [IsoId("_m_dw0YqhEeS4a4abTJTSSw")]
    [Description(@"Suspect notes.")]
    Suspect = ATMNoteTypeCode.Suspect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unfit bank notes (unacceptable quality).
    /// Encoded/decoded by serializers as &quot;UNFT&quot;.
    /// </summary>
    [EnumMember(Value = "UNFT")]
    [IsoId("_nI29YYqhEeS4a4abTJTSSw")]
    [Description(@"Unfit bank notes (unacceptable quality).")]
    Unfit = ATMNoteTypeCode.Unfit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised notes.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_nPaRUYqhEeS4a4abTJTSSw")]
    [Description(@"Unrecognised notes.")]
    Unrecognised = ATMNoteTypeCode.Unrecognised, // same ordinal as derivation source for type conversions
    
}
