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
[IsoId("_bKZZ5Np-Ed-ak6NoX_4Aeg_-572672162")]
[Description(@"Specifies the status of a corporate action instruction.")]
[DerivedFrom(typeof(CorporateActionInstructionProcessingStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionInstructionProcessingStatus1Code>))]
#endif
public enum CorporateActionInstructionProcessingStatus1Code
{
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_bKZZ5dp-Ed-ak6NoX_4Aeg_-1187289407")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = CorporateActionInstructionProcessingStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Default action is taken.
    /// Encoded/decoded by serializers as &quot;DFLA&quot;.
    /// </summary>
    [EnumMember(Value = "DFLA")]
    [IsoId("_bKZZ5tp-Ed-ak6NoX_4Aeg_-426524254")]
    [Description(@"Default action is taken.")]
    DefaultAction = CorporateActionInstructionProcessingStatusCode.DefaultAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing. In other words, this means that the instruction has been received, is processable and has been validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bKZZ59p-Ed-ak6NoX_4Aeg_27563015")]
    [Description(
        @"Instruction has been acknowledged/accepted for further processing. In other words, this means that the instruction has been received, is processable and has been validated for further processing."
    )]
    Accepted = CorporateActionInstructionProcessingStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction&apos;s processing is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_bKZZ6Np-Ed-ak6NoX_4Aeg_1494711778")]
    [Description(@"Instruction's processing is pending.")]
    Pending = CorporateActionInstructionProcessingStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been rejected for further processing due to system reasons.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_bKZZ6dp-Ed-ak6NoX_4Aeg_1858486184")]
    [Description(@"Instruction has been rejected for further processing due to system reasons.")]
    Rejected = CorporateActionInstructionProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as &quot;STIN&quot;.
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_bKjK4Np-Ed-ak6NoX_4Aeg_-1982393843")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction = CorporateActionInstructionProcessingStatusCode.StandingInstruction, // same ordinal as derivation source for type conversions
}
