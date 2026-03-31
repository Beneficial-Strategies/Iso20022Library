// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a corporate action instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bKjK4dp-Ed-ak6NoX_4Aeg_-1308410939")]
[Description(@"Specifies the status of a corporate action instruction.")]
[Derivations(typeof(CorporateActionInstructionProcessingStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionInstructionProcessingStatusCode>))]
#endif
public enum CorporateActionInstructionProcessingStatusCode
{
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_bKjK4tp-Ed-ak6NoX_4Aeg_86891368")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled,

    /// <summary>
    /// Default action is taken.
    /// Encoded/decoded by serializers as &quot;DFLA&quot;.
    /// </summary>
    [EnumMember(Value = "DFLA")]
    [IsoId("_bKjK49p-Ed-ak6NoX_4Aeg_1478052223")]
    [Description(@"Default action is taken.")]
    DefaultAction,

    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing. In other words, this means that the instruction has been received, is processable and has been validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bKjK5Np-Ed-ak6NoX_4Aeg_1586320101")]
    [Description(
        @"Instruction has been acknowledged/accepted for further processing. In other words, this means that the instruction has been received, is processable and has been validated for further processing."
    )]
    Accepted,

    /// <summary>
    /// Instruction&apos;s processing is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_bKjK5dp-Ed-ak6NoX_4Aeg_271390723")]
    [Description(@"Instruction's processing is pending.")]
    Pending,

    /// <summary>
    /// Instruction has been rejected for further processing due to system reasons.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_bKjK5tp-Ed-ak6NoX_4Aeg_363574550")]
    [Description(@"Instruction has been rejected for further processing due to system reasons.")]
    Rejected,

    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as &quot;STIN&quot;.
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_bKsU0Np-Ed-ak6NoX_4Aeg_-721845566")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction,
}
