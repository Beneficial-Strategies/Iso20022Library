// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of demand for payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__XQC0HyXEeGWJuGCfvwOsQ")]
[Description(@"Specifies the type of demand for payment.")]
[DerivedFrom(typeof(DemandTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DemandType1Code>))]
#endif
public enum DemandType1Code
{
    /// <summary>
    /// Pay only.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_hAxXJnyYEeGWJuGCfvwOsQ")]
    [Description(@"Pay only.")]
    PayOnly = DemandTypeCode.PayOnly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pay or extend.
    /// Encoded/decoded by serializers as &quot;PAEX&quot;.
    /// </summary>
    [EnumMember(Value = "PAEX")]
    [IsoId("_hJ3BtnyYEeGWJuGCfvwOsQ")]
    [Description(@"Pay or extend.")]
    PayOrExtend = DemandTypeCode.PayOrExtend, // same ordinal as derivation source for type conversions
}
