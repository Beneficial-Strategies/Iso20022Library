// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of items the cash-in cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CjsMwIqgEeS4a4abTJTSSw")]
[Description(@"Type of items the cash-in cassette.")]
[Derivations(typeof(ATMNoteType1Code), typeof(ATMNoteType2Code))]
public enum ATMNoteTypeCode
{
    /// <summary>
    /// All fit bank note types.
    /// Encoded/decoded by serializers as &quot;ALLT&quot;.
    /// </summary>
    [EnumMember(Value = "ALLT")]
    [IsoId("_GGMqMIqgEeS4a4abTJTSSw")]
    [Description(@"All fit bank note types.")]
    All,

    /// <summary>
    /// Detected counterfeit notes.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_IqGxYIqgEeS4a4abTJTSSw")]
    [Description(@"Detected counterfeit notes.")]
    Counterfeit,

    /// <summary>
    /// All types of fit bank notes specified in an individual list.
    /// Encoded/decoded by serializers as &quot;IDVD&quot;.
    /// </summary>
    [EnumMember(Value = "IDVD")]
    [IsoId("_LepVkIqgEeS4a4abTJTSSw")]
    [Description(@"All types of fit bank notes specified in an individual list.")]
    Individual,

    /// <summary>
    /// Suspected counterfeit notes.
    /// Encoded/decoded by serializers as &quot;SCNT&quot;.
    /// </summary>
    [EnumMember(Value = "SCNT")]
    [IsoId("_N3-kcIqgEeS4a4abTJTSSw")]
    [Description(@"Suspected counterfeit notes.")]
    SuspectedCounterfeit,

    /// <summary>
    /// Unfit bank notes (unacceptable quality).
    /// Encoded/decoded by serializers as &quot;UNFT&quot;.
    /// </summary>
    [EnumMember(Value = "UNFT")]
    [IsoId("_Q3BIcIqgEeS4a4abTJTSSw")]
    [Description(@"Unfit bank notes (unacceptable quality).")]
    Unfit,

    /// <summary>
    /// Fit bank notes.
    /// Encoded/decoded by serializers as &quot;FITN&quot;.
    /// </summary>
    [EnumMember(Value = "FITN")]
    [IsoId("_K5jPAIqhEeS4a4abTJTSSw")]
    [Description(@"Fit bank notes.")]
    Fit,

    /// <summary>
    /// Fit and unfit bank notes, if fitness cannot be determined.
    /// Encoded/decoded by serializers as &quot;FITU&quot;.
    /// </summary>
    [EnumMember(Value = "FITU")]
    [IsoId("_OmVCwIqhEeS4a4abTJTSSw")]
    [Description(@"Fit and unfit bank notes, if fitness cannot be determined.")]
    FitAndUnfit,

    /// <summary>
    /// Notes stained by dye pack.
    /// Encoded/decoded by serializers as &quot;NTRL&quot;.
    /// </summary>
    [EnumMember(Value = "NTRL")]
    [IsoId("_RZ4vgIqhEeS4a4abTJTSSw")]
    [Description(@"Notes stained by dye pack.")]
    Neutralised,

    /// <summary>
    /// Suspect notes.
    /// Encoded/decoded by serializers as &quot;SPCT&quot;.
    /// </summary>
    [EnumMember(Value = "SPCT")]
    [IsoId("_T9gi0IqhEeS4a4abTJTSSw")]
    [Description(@"Suspect notes.")]
    Suspect,

    /// <summary>
    /// Unrecognised notes.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_XNiJIIqhEeS4a4abTJTSSw")]
    [Description(@"Unrecognised notes.")]
    Unrecognised,
}
