// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a securities settlement condition modification request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZK188Np-Ed-ak6NoX_4Aeg_-1146323229")]
[Description(@"Specifies the status of a securities settlement condition modification request.")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementConditionModificationProcessingStatus1Code>))]
#endif
public enum SettlementConditionModificationProcessingStatus1Code
{
    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZK188dp-Ed-ak6NoX_4Aeg_-1146323136")]
    [Description(
        @"Instruction has been acknowledged/accepted for further processing by the account servicer."
    )]
    AcknowledgedAccepted = InstructionProcessingStatusCode.AcknowledgedAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZK188tp-Ed-ak6NoX_4Aeg_-1146323114")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected = InstructionProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions
}
