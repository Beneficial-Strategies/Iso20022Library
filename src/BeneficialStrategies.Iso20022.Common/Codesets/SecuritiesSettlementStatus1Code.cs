// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status of settlement of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFx2xdp-Ed-ak6NoX_4Aeg_1485379028")]
[Description(@"Provides the status of settlement of an instruction.")]
[DerivedFrom(typeof(SecuritiesSettlementStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesSettlementStatus1Code>))]
#endif
public enum SecuritiesSettlementStatus1Code
{
    /// <summary>
    /// Instruction is pending. Settlement at the instructed settlement date is still possible.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZFx2xtp-Ed-ak6NoX_4Aeg_1558336292")]
    [Description(
        @"Instruction is pending. Settlement at the instructed settlement date is still possible."
    )]
    Pending = SecuritiesSettlementStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is failing. Settlement at the instructed settlement date is no longer possible.
    /// Encoded/decoded by serializers as &quot;PENF&quot;.
    /// </summary>
    [EnumMember(Value = "PENF")]
    [IsoId("_ZFx2x9p-Ed-ak6NoX_4Aeg_1570340511")]
    [Description(
        @"Instruction is failing. Settlement at the instructed settlement date is no longer possible."
    )]
    Failing = SecuritiesSettlementStatusCode.Failing, // same ordinal as derivation source for type conversions
}
