// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMx2otp-Ed-ak6NoX_4Aeg_-1474296543")]
[Description(
    @"Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system."
)]
[Derivations(typeof(SettlementSystemMethod1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementSystemMethodCode>))]
#endif
public enum SettlementSystemMethodCode
{
    /// <summary>
    /// Settle through the default settlement system/method. If there is a standing instruction in place for settlement through the alternate settlement system/method, then this standing instruction is to be ignored.
    /// Encoded/decoded by serializers as &quot;NSET&quot;.
    /// </summary>
    [EnumMember(Value = "NSET")]
    [IsoId("_ZMx2o9p-Ed-ak6NoX_4Aeg_-1474296533")]
    [Description(
        @"Settle through the default settlement system/method. If there is a standing instruction in place for settlement through the alternate settlement system/method, then this standing instruction is to be ignored."
    )]
    Default,

    /// <summary>
    /// Settle through the alternate settlement system/method. If there is a standing instruction in place for settlement through the default settlement system/method, then this standing instruction is to be ignored.
    /// Encoded/decoded by serializers as &quot;YSET&quot;.
    /// </summary>
    [EnumMember(Value = "YSET")]
    [IsoId("_ZMx2pNp-Ed-ak6NoX_4Aeg_-1474296525")]
    [Description(
        @"Settle through the alternate settlement system/method. If there is a standing instruction in place for settlement through the default settlement system/method, then this standing instruction is to be ignored."
    )]
    Alternative,
}
