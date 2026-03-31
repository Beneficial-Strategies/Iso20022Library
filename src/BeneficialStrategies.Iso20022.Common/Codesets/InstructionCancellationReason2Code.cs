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
[IsoId("_aXIw9Np-Ed-ak6NoX_4Aeg_-1158791468")]
[Description(@"Specifies the reason why the instruction is cancelled.")]
[DerivedFrom(typeof(InstructionCancellationReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InstructionCancellationReason2Code>))]
#endif
public enum InstructionCancellationReason2Code
{
    /// <summary>
    /// Instruction has been cancelled as per your request.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_aXIw9dp-Ed-ak6NoX_4Aeg_-1158791466")]
    [Description(@"Instruction has been cancelled as per your request.")]
    CancelledByYourselves = InstructionCancellationReasonCode.CancelledByYourselves, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled by the settlement system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_aXIw9tp-Ed-ak6NoX_4Aeg_-1158791438")]
    [Description(@"Instruction has been cancelled by the settlement system.")]
    CancelledBySystem = InstructionCancellationReasonCode.CancelledBySystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled by the agent.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_aXIw99p-Ed-ak6NoX_4Aeg_-1158791437")]
    [Description(@"Instruction has been cancelled by the agent.")]
    CancelledByAgent = InstructionCancellationReasonCode.CancelledByAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled by another party than the instructing party, for example, market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_aXSh8Np-Ed-ak6NoX_4Aeg_-1158791190")]
    [Description(
        @"Instruction has been cancelled by another party than the instructing party, for example, market infrastructure such as a stock exchange."
    )]
    CancelledByAnotherParty = InstructionCancellationReasonCode.CancelledByAnotherParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original instruction has been cancelled and replaced due to a corporate action.
    /// Encoded/decoded by serializers as &quot;CANT&quot;.
    /// </summary>
    [EnumMember(Value = "CANT")]
    [IsoId("_aXSh8dp-Ed-ak6NoX_4Aeg_-1158791189")]
    [Description(
        @"Original instruction has been cancelled and replaced due to a corporate action."
    )]
    CancelledDueToTransformation = InstructionCancellationReasonCode.CancelledDueToTransformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original instruction has been cancelled and replaced to allow a partial or split settlement.
    /// Encoded/decoded by serializers as &quot;CANZ&quot;.
    /// </summary>
    [EnumMember(Value = "CANZ")]
    [IsoId("_aXSh8tp-Ed-ak6NoX_4Aeg_-1158791160")]
    [Description(
        @"Original instruction has been cancelled and replaced to allow a partial or split settlement."
    )]
    CancelledDueToSplitPartialSettlement =
        InstructionCancellationReasonCode.CancelledDueToSplitPartialSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled due to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_aXSh89p-Ed-ak6NoX_4Aeg_-1158791159")]
    [Description(@"Instruction has been cancelled due to a corporate action.")]
    CancelledDueToCorporateAction = InstructionCancellationReasonCode.CancelledDueToCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled by the issuer/registrar.
    /// Encoded/decoded by serializers as &quot;CREG&quot;.
    /// </summary>
    [EnumMember(Value = "CREG")]
    [IsoId("_aXSh9Np-Ed-ak6NoX_4Aeg_-1158791158")]
    [Description(@"Instruction has been cancelled by the issuer/registrar.")]
    CancelledByIssuerRegistrar = InstructionCancellationReasonCode.CancelledByIssuerRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has expired.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_aXSh9dp-Ed-ak6NoX_4Aeg_-1158791129")]
    [Description(@"Instruction has expired.")]
    Expired = InstructionCancellationReasonCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled; the security no longer exists or is no longer eligible on the market instructed. For corporate action related cancellation, CORP should be used.
    /// Encoded/decoded by serializers as &quot;SCEX&quot;.
    /// </summary>
    [EnumMember(Value = "SCEX")]
    [IsoId("_aXSh9tp-Ed-ak6NoX_4Aeg_-1158791098")]
    [Description(
        @"Instruction has been cancelled; the security no longer exists or is no longer eligible on the market instructed. For corporate action related cancellation, CORP should be used."
    )]
    SecuritiesNoLongerEligible = InstructionCancellationReasonCode.SecuritiesNoLongerEligible, // same ordinal as derivation source for type conversions
}
