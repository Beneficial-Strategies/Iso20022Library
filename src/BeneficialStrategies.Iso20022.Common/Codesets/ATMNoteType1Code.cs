// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of items the cash-in cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UVOUsIqgEeS4a4abTJTSSw")]
[Description(@"Type of items the cash-in cassette.")]
[DerivedFrom(typeof(ATMNoteTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMNoteType1Code>))]
#endif
public enum ATMNoteType1Code
{
    /// <summary>
    /// All fit bank note types.
    /// Encoded/decoded by serializers as &quot;ALLT&quot;.
    /// </summary>
    [EnumMember(Value = "ALLT")]
    [IsoId("_V2iWcYqgEeS4a4abTJTSSw")]
    [Description(@"All fit bank note types.")]
    All = ATMNoteTypeCode.All, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Detected counterfeit notes.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_V7mcoYqgEeS4a4abTJTSSw")]
    [Description(@"Detected counterfeit notes.")]
    Counterfeit = ATMNoteTypeCode.Counterfeit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All types of fit bank notes specified in an individual list.
    /// Encoded/decoded by serializers as &quot;IDVD&quot;.
    /// </summary>
    [EnumMember(Value = "IDVD")]
    [IsoId("_WAqi0YqgEeS4a4abTJTSSw")]
    [Description(@"All types of fit bank notes specified in an individual list.")]
    Individual = ATMNoteTypeCode.Individual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspected counterfeit notes.
    /// Encoded/decoded by serializers as &quot;SCNT&quot;.
    /// </summary>
    [EnumMember(Value = "SCNT")]
    [IsoId("_WHEs0YqgEeS4a4abTJTSSw")]
    [Description(@"Suspected counterfeit notes.")]
    SuspectedCounterfeit = ATMNoteTypeCode.SuspectedCounterfeit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unfit bank notes (unacceptable quality).
    /// Encoded/decoded by serializers as &quot;UNFT&quot;.
    /// </summary>
    [EnumMember(Value = "UNFT")]
    [IsoId("_WNL74YqgEeS4a4abTJTSSw")]
    [Description(@"Unfit bank notes (unacceptable quality).")]
    Unfit = ATMNoteTypeCode.Unfit, // same ordinal as derivation source for type conversions
}
