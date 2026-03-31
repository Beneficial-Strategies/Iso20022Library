// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined notice type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1oOpwzL3EeKU9IrkkToqcw_800966479")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined notice type."
)]
[Derivations(typeof(NoticeType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NoticeTypeCode>))]
#endif
public enum NoticeTypeCode
{
    /// <summary>
    /// Notice is universal.
    /// Encoded/decoded by serializers as &quot;UNVL&quot;.
    /// </summary>
    [EnumMember(Value = "UNVL")]
    [IsoId("_1oOpxDL3EeKU9IrkkToqcw_529250699")]
    [Description(@"Notice is universal.")]
    Universal,

    /// <summary>
    /// Notice is specific to the securities registered in DTC&apos;s (The Depository Trust Company) nominee name.
    /// Encoded/decoded by serializers as &quot;CEDE&quot;.
    /// </summary>
    [EnumMember(Value = "CEDE")]
    [IsoId("_1oOpxTL3EeKU9IrkkToqcw_1017030316")]
    [Description(
        @"Notice is specific to the securities registered in DTC's (The Depository Trust Company) nominee name."
    )]
    CedeAndCo,
}
