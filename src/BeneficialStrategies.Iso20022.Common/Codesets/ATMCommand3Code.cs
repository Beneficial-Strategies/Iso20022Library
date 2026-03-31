// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of command performed by the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jy47gItvEeSLQutgI1Ulfw")]
[Description(@"Type of command performed by the ATM.")]
[DerivedFrom(typeof(ATMCommandCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMCommand3Code>))]
#endif
public enum ATMCommand3Code
{
    /// <summary>
    /// Provide the ATM counters, resetting those that are applicable.
    /// Encoded/decoded by serializers as &quot;ABAL&quot;.
    /// </summary>
    [EnumMember(Value = "ABAL")]
    [IsoId("_pwUjQYtvEeSLQutgI1Ulfw")]
    [Description(@"Provide the ATM counters, resetting those that are applicable.")]
    ATMBalance = ATMCommandCode.ATMBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;CCNT&quot;.
    /// </summary>
    [EnumMember(Value = "CCNT")]
    [IsoId("_qQqQM4tvEeSLQutgI1Ulfw")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry = ATMCommandCode.CountersInquiry, // same ordinal as derivation source for type conversions
}
