// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the list of codes applicable to embedded option types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GrbbsIcQEeu4rpsqTt37Pg")]
[Description(@"Specifies the list of codes applicable to embedded option types.")]
[DerivedFrom(typeof(EmbeddedTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EmbeddedType1Code>))]
#endif
public enum EmbeddedType1Code
{
    /// <summary>
    /// Option can be cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_LgjXkYcQEeu4rpsqTt37Pg")]
    [Description(@"Option can be cancelled.")]
    Cancellable = EmbeddedTypeCode.Cancellable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option can be extended.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_Ll808YcQEeu4rpsqTt37Pg")]
    [Description(@"Option can be extended.")]
    Extendible = EmbeddedTypeCode.Extendible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option can be early terminated.
    /// Encoded/decoded by serializers as &quot;OPET&quot;.
    /// </summary>
    [EnumMember(Value = "OPET")]
    [IsoId("_LzfhsYcQEeu4rpsqTt37Pg")]
    [Description(@"Option can be early terminated.")]
    OptionalEarlyTermination = EmbeddedTypeCode.OptionalEarlyTermination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option type is other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_L5WSEYcQEeu4rpsqTt37Pg")]
    [Description(@"Option type is other.")]
    Other = EmbeddedTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option must be early terminated.
    /// Encoded/decoded by serializers as &quot;MDET&quot;.
    /// </summary>
    [EnumMember(Value = "MDET")]
    [IsoId("_r1K6MZibEeyBPr8ozNGJLg")]
    [Description(@"Option must be early terminated.")]
    MandatoryEarlyTermination = EmbeddedTypeCode.MandatoryEarlyTermination, // same ordinal as derivation source for type conversions
}
