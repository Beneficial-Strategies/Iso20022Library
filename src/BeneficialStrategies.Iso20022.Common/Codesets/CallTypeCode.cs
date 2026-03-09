// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of execution of the call feature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha1jt2liEeGaMcKyqKNRfQ_1405973074")]
[Description(@"Defines the type of execution of the call feature.")]
[Derivations(typeof(CallType1Code))]
public enum CallTypeCode
{
    /// <summary>
    /// Type of execution of the call feature is a lottery.
    /// Encoded/decoded by serializers as &quot;LOTT&quot;.
    /// </summary>
    [EnumMember(Value = "LOTT")]
    [IsoId("_ha1juGliEeGaMcKyqKNRfQ_-1311622256")]
    [Description(@"Type of execution of the call feature is a lottery.")]
    Lottery,
    
    /// <summary>
    /// Type of execution of the call feature is pro-rata.
    /// Encoded/decoded by serializers as &quot;PRTA&quot;.
    /// </summary>
    [EnumMember(Value = "PRTA")]
    [IsoId("_ha1juWliEeGaMcKyqKNRfQ_253023576")]
    [Description(@"Type of execution of the call feature is pro-rata.")]
    ProRata,
    
}
