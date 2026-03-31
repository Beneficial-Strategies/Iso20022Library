// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Settlement Instruction Generation Code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__wk5ZdojEeC60axPepSq7g_1768123996")]
[Description(@"Settlement Instruction Generation Code.")]
[DerivedFrom(typeof(SettlementInstructionGenerationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementInstructionGeneration1Code>))]
#endif
public enum SettlementInstructionGeneration1Code
{
    /// <summary>
    /// Specifies if the ETC service provider is to generate a settlement instruction.
    /// Encoded/decoded by serializers as &quot;GENS&quot;.
    /// </summary>
    [EnumMember(Value = "GENS")]
    [IsoId("__wk5ZtojEeC60axPepSq7g_899535056")]
    [Description(@"Specifies if the ETC service provider is to generate a settlement instruction.")]
    InstructionGenerationByETCProvider =
        SettlementInstructionGenerationCode.InstructionGenerationByETCProvider, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies if the ETC service provider is not to generate a settlement instruction where a previous agreement to do so exists.
    /// Encoded/decoded by serializers as &quot;NOGE&quot;.
    /// </summary>
    [EnumMember(Value = "NOGE")]
    [IsoId("__wuqYNojEeC60axPepSq7g_710317607")]
    [Description(
        @"Specifies if the ETC service provider is not to generate a settlement instruction where a previous agreement to do so exists."
    )]
    NotInstructionGenerationByETCProvider =
        SettlementInstructionGenerationCode.NotInstructionGenerationByETCProvider, // same ordinal as derivation source for type conversions
}
