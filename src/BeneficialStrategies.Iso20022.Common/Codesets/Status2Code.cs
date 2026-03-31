// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQWvF9p-Ed-ak6NoX_4Aeg_-539683866")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Status2Code>))]
#endif
public enum Status2Code
{
    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ZQggENp-Ed-ak6NoX_4Aeg_-539683848")]
    [Description(@"Processing has been completed.")]
    Completed = StatusCode.Completed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ZQggEdp-Ed-ak6NoX_4Aeg_-475958869")]
    [Description(@"Instruction is pending.")]
    Pending = StatusCode.Pending, // same ordinal as derivation source for type conversions
}
