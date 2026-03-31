// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status of settlement of an instruction expressed as a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WfglwMX-EeiSF9q-coWegA")]
[Description(@"Provides the status of settlement of an instruction expressed as a code.")]
[DerivedFrom(typeof(SecuritiesSettlementStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesSettlementStatus3Code>))]
#endif
public enum SecuritiesSettlementStatus3Code
{
    /// <summary>
    /// Instruction is pending. Settlement at the instructed settlement date is still possible.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_YKVI0cX-EeiSF9q-coWegA")]
    [Description(
        @"Instruction is pending. Settlement at the instructed settlement date is still possible."
    )]
    Pending = SecuritiesSettlementStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full settlement.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_YSXqgcX-EeiSF9q-coWegA")]
    [Description(@"Full settlement.")]
    Settled = SecuritiesSettlementStatusCode.Settled, // same ordinal as derivation source for type conversions
}
