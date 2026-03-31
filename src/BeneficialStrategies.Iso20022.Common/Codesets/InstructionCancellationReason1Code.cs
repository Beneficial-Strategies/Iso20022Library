// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction is cancelled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aXIw8Np-Ed-ak6NoX_4Aeg_-339948724")]
[Description(@"Specifies the reason why the instruction is cancelled.")]
[DerivedFrom(typeof(InstructionCancellationReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InstructionCancellationReason1Code>))]
#endif
public enum InstructionCancellationReason1Code
{
    /// <summary>
    /// Instruction has been cancelled as per your request.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_aXIw8dp-Ed-ak6NoX_4Aeg_-339028661")]
    [Description(@"Instruction has been cancelled as per your request.")]
    CancelledByYourselves = InstructionCancellationReasonCode.CancelledByYourselves, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled by the settlement system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_aXIw8tp-Ed-ak6NoX_4Aeg_-339028630")]
    [Description(@"Instruction has been cancelled by the settlement system.")]
    CancelledBySystem = InstructionCancellationReasonCode.CancelledBySystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled by the agent.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_aXIw89p-Ed-ak6NoX_4Aeg_-339028569")]
    [Description(@"Instruction has been cancelled by the agent.")]
    CancelledByAgent = InstructionCancellationReasonCode.CancelledByAgent, // same ordinal as derivation source for type conversions
}
