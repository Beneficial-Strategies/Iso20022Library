// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies unrealised gain and loss.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m59_YPNBEeCuA5Tr22BnwA_1987531471")]
[Description(@"Specifies unrealised gain and loss.")]
[DerivedFrom(typeof(UnrealisedCode))]
public enum Unrealised1Code
{
    /// <summary>
    /// Unrealised gain.
    /// Encoded/decoded by serializers as &quot;GAIN&quot;.
    /// </summary>
    [EnumMember(Value = "GAIN")]
    [IsoId("_m59_YfNBEeCuA5Tr22BnwA_1098512688")]
    [Description(@"Unrealised gain.")]
    Gain = UnrealisedCode.Gain, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrealised loss.
    /// Encoded/decoded by serializers as &quot;LOSS&quot;.
    /// </summary>
    [EnumMember(Value = "LOSS")]
    [IsoId("_m59_YvNBEeCuA5Tr22BnwA_-1551187173")]
    [Description(@"Unrealised loss.")]
    Loss = UnrealisedCode.Loss, // same ordinal as derivation source for type conversions
    
}
