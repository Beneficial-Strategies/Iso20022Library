// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of execution of the call feature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha1jvmliEeGaMcKyqKNRfQ_1930331494")]
[Description(@"Defines the type of execution of the call feature.")]
[DerivedFrom(typeof(CallTypeCode))]
public enum CallType1Code
{
    /// <summary>
    /// Type of execution of the call feature is a lottery.
    /// Encoded/decoded by serializers as &quot;LOTT&quot;.
    /// </summary>
    [EnumMember(Value = "LOTT")]
    [IsoId("_ha1jv2liEeGaMcKyqKNRfQ_1557320145")]
    [Description(@"Type of execution of the call feature is a lottery.")]
    Lottery = CallTypeCode.Lottery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of execution of the call feature is pro-rata.
    /// Encoded/decoded by serializers as &quot;PRTA&quot;.
    /// </summary>
    [EnumMember(Value = "PRTA")]
    [IsoId("_ha1jwGliEeGaMcKyqKNRfQ_-906723982")]
    [Description(@"Type of execution of the call feature is pro-rata.")]
    ProRata = CallTypeCode.ProRata, // same ordinal as derivation source for type conversions
    
}
