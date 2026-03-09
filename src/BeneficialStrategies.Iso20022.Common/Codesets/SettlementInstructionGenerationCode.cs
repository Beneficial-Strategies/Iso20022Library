// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the ETC service provider is to generate a settlement instruction or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__wuqYdojEeC60axPepSq7g_-1147396921")]
[Description(@"Specifies if the ETC service provider is to generate a settlement instruction or not.")]
[Derivations(typeof(SettlementInstructionGeneration1Code))]
public enum SettlementInstructionGenerationCode
{
    /// <summary>
    /// Specifies if the ETC service provider is to generate a settlement instruction.
    /// Encoded/decoded by serializers as &quot;GENS&quot;.
    /// </summary>
    [EnumMember(Value = "GENS")]
    [IsoId("__wuqYtojEeC60axPepSq7g_1870680241")]
    [Description(@"Specifies if the ETC service provider is to generate a settlement instruction.")]
    InstructionGenerationByETCProvider,
    
    /// <summary>
    /// Specifies if the ETC service provider is not to generate a settlement instruction where a previous agreement to do so exists.
    /// Encoded/decoded by serializers as &quot;NOGE&quot;.
    /// </summary>
    [EnumMember(Value = "NOGE")]
    [IsoId("__wuqY9ojEeC60axPepSq7g_-2120429518")]
    [Description(@"Specifies if the ETC service provider is not to generate a settlement instruction where a previous agreement to do so exists.")]
    NotInstructionGenerationByETCProvider,
    
}
