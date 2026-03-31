// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a cancellation complete status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vjk7Udp-Ed-ak6NoX_4Aeg_126887481")]
[Description(@"Specifies the reason for a cancellation complete status.")]
[DerivedFrom(typeof(CancelledStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CancellationCompleteStatusReason1Code>))]
#endif
public enum CancellationCompleteStatusReason1Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_Vjk7Utp-Ed-ak6NoX_4Aeg_1328122502")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonCode.CancelledByYourself, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_Vjk7U9p-Ed-ak6NoX_4Aeg_1339203856")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem = CancelledStatusReasonCode.CancelledBySystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by the agent.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_Vjk7VNp-Ed-ak6NoX_4Aeg_1351207826")]
    [Description(@"Transaction is cancelled by the agent.")]
    CancelledByAgent = CancelledStatusReasonCode.CancelledByAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other (see additional information).
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vjk7Vdp-Ed-ak6NoX_4Aeg_1579319938")]
    [Description(@"Other (see additional information).")]
    Other = CancelledStatusReasonCode.Other, // same ordinal as derivation source for type conversions
}
