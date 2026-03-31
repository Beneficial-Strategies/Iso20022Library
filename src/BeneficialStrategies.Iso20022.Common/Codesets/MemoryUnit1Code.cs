// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unit of the memory size.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0NRCAAxzEeKa_56Jbsi1RQ")]
[Description(@"Unit of the memory size.")]
[DerivedFrom(typeof(MemoryUnitCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MemoryUnit1Code>))]
#endif
public enum MemoryUnit1Code
{
    /// <summary>
    /// Byte.
    /// Encoded/decoded by serializers as &quot;BYTE&quot;.
    /// </summary>
    [EnumMember(Value = "BYTE")]
    [IsoId("_1rmBMQxzEeKa_56Jbsi1RQ")]
    [Description(@"Byte.")]
    Byte = MemoryUnitCode.Byte, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exa byte.
    /// Encoded/decoded by serializers as &quot;EXAB&quot;.
    /// </summary>
    [EnumMember(Value = "EXAB")]
    [IsoId("_1yuj8wxzEeKa_56Jbsi1RQ")]
    [Description(@"Exa byte.")]
    ExaByte = MemoryUnitCode.ExaByte, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Giga byte.
    /// Encoded/decoded by serializers as &quot;GIGA&quot;.
    /// </summary>
    [EnumMember(Value = "GIGA")]
    [IsoId("_17gsgwxzEeKa_56Jbsi1RQ")]
    [Description(@"Giga byte.")]
    GigaByte = MemoryUnitCode.GigaByte, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Kilo byte.
    /// Encoded/decoded by serializers as &quot;KILO&quot;.
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_2AkLowxzEeKa_56Jbsi1RQ")]
    [Description(@"Kilo byte.")]
    KiloByte = MemoryUnitCode.KiloByte, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mega byte.
    /// Encoded/decoded by serializers as &quot;MEGA&quot;.
    /// </summary>
    [EnumMember(Value = "MEGA")]
    [IsoId("_2HQpgQxzEeKa_56Jbsi1RQ")]
    [Description(@"Mega byte.")]
    MegaByte = MemoryUnitCode.MegaByte, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Peta byte.
    /// Encoded/decoded by serializers as &quot;PETA&quot;.
    /// </summary>
    [EnumMember(Value = "PETA")]
    [IsoId("_2O_pMQxzEeKa_56Jbsi1RQ")]
    [Description(@"Peta byte.")]
    PetaByte = MemoryUnitCode.PetaByte, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tera byte.
    /// Encoded/decoded by serializers as &quot;TERA&quot;.
    /// </summary>
    [EnumMember(Value = "TERA")]
    [IsoId("_2fgxcQxzEeKa_56Jbsi1RQ")]
    [Description(@"Tera byte.")]
    TeraByte = MemoryUnitCode.TeraByte, // same ordinal as derivation source for type conversions
}
