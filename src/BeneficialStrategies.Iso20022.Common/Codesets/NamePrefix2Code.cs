// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the terms used to formally address a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ODhzcHRmEeiH1ZOt2UD8vQ")]
[Description(@"Specifies the terms used to formally address a person.")]
[DerivedFrom(typeof(NamePrefixCode))]
public enum NamePrefix2Code
{
    /// <summary>
    /// Title of the person is Doctor or Dr.
    /// Encoded/decoded by serializers as &quot;DOCT&quot;.
    /// </summary>
    [EnumMember(Value = "DOCT")]
    [IsoId("_SmTbEXRmEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is Doctor or Dr.")]
    Doctor = NamePrefixCode.Doctor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Title of the person is Madam.
    /// Encoded/decoded by serializers as &quot;MADM&quot;.
    /// </summary>
    [EnumMember(Value = "MADM")]
    [IsoId("_SseUgXRmEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is Madam.")]
    Madam = NamePrefixCode.Madam, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Title of the person is Miss.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_SzqhoXRmEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is Miss.")]
    Miss = NamePrefixCode.Miss, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Title of the person is Mister or Mr.
    /// Encoded/decoded by serializers as &quot;MIST&quot;.
    /// </summary>
    [EnumMember(Value = "MIST")]
    [IsoId("_S6p6cXRmEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is Mister or Mr.")]
    Mister = NamePrefixCode.Mister, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Title of the person is gender neutral (Mx).
    /// Encoded/decoded by serializers as &quot;MIKS&quot;.
    /// </summary>
    [EnumMember(Value = "MIKS")]
    [IsoId("_TCckgXRmEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is gender neutral (Mx).")]
    GenderNeutral = NamePrefixCode.GenderNeutral, // same ordinal as derivation source for type conversions
    
}
