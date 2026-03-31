// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7_v2oGaxEeWZev0W8F756g")]
[Description(
    @"Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction."
)]
[DerivedFrom(typeof(ProcessingPositionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProcessingPosition5Code>))]
#endif
public enum ProcessingPosition5Code
{
    /// <summary>
    /// Specifies that the transactions/instructions are linked for information purposes only.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_-jjQIWaxEeWZev0W8F756g")]
    [Description(
        @"Specifies that the transactions/instructions are linked for information purposes only."
    )]
    Information = ProcessingPositionCode.Information, // same ordinal as derivation source for type conversions
}
