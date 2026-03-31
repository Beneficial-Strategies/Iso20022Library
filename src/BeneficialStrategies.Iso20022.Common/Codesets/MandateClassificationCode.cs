// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of direct debit amount, such as fixed or variable.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zmsM1mVQEeacpJ-gG9kyUQ")]
[Description(@"Specifies the type of direct debit amount, such as fixed or variable.")]
[Derivations(typeof(MandateClassification1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MandateClassificationCode>))]
#endif
public enum MandateClassificationCode
{
    /// <summary>
    /// Direct debit amount is fixed.
    /// Encoded/decoded by serializers as &quot;FIXE&quot;.
    /// </summary>
    [EnumMember(Value = "FIXE")]
    [IsoId("_zmsM2GVQEeacpJ-gG9kyUQ")]
    [Description(@"Direct debit amount is fixed.")]
    Fixed,

    /// <summary>
    /// Direct debit amount is variable.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_zmsM22VQEeacpJ-gG9kyUQ")]
    [Description(@"Direct debit amount is variable.")]
    Variable,

    /// <summary>
    /// Direct debit amount is based on usage.
    /// Encoded/decoded by serializers as &quot;USGB&quot;.
    /// </summary>
    [EnumMember(Value = "USGB")]
    [IsoId("_KVQPcGVREeacpJ-gG9kyUQ")]
    [Description(@"Direct debit amount is based on usage.")]
    UsageBased,
}
