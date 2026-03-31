// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zt3Kddp-Ed-ak6NoX_4Aeg_1265326126")]
[Description(@"Specifies the reason why the instruction is in repair.")]
[DerivedFrom(typeof(RepairReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RepairReason3Code>))]
#endif
public enum RepairReason3Code
{
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Zt3Kdtp-Ed-ak6NoX_4Aeg_1265326437")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate = RepairReasonCode.SettlementDate, // same ordinal as derivation source for type conversions
}
