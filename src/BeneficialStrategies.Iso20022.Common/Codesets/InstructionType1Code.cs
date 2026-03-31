// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the action that the TSU must take on a baseline.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aYn-tdp-Ed-ak6NoX_4Aeg_-377371572")]
[Description(@"Specifies the action that the TSU must take on a baseline.")]
[DerivedFrom(typeof(InstructionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InstructionType1Code>))]
#endif
public enum InstructionType1Code
{
    /// <summary>
    /// Instruction to lodge a baseline.
    /// Encoded/decoded by serializers as &quot;LODG&quot;.
    /// </summary>
    [EnumMember(Value = "LODG")]
    [IsoId("_aYn-ttp-Ed-ak6NoX_4Aeg_-8888673")]
    [Description(@"Instruction to lodge a baseline.")]
    Lodge = InstructionTypeCode.Lodge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction to push full baseline information to the correspondent.
    /// Encoded/decoded by serializers as &quot;FPTR&quot;.
    /// </summary>
    [EnumMember(Value = "FPTR")]
    [IsoId("_aYn-t9p-Ed-ak6NoX_4Aeg_-8888613")]
    [Description(@"Instruction to push full baseline information to the correspondent.")]
    FullPushThrough = InstructionTypeCode.FullPushThrough, // same ordinal as derivation source for type conversions
}
