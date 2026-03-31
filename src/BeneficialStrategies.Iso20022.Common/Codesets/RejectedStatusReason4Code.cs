// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ViiZhdp-Ed-ak6NoX_4Aeg_-901743273")]
[Description(@"Specifies the reason for a rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectedStatusReason4Code>))]
#endif
public enum RejectedStatusReason4Code
{
    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_ViiZhtp-Ed-ak6NoX_4Aeg_-640387122")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime = RejectedStatusReasonCode.CutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructing party is not allowed to request a cancellation.
    /// Encoded/decoded by serializers as &quot;NALC&quot;.
    /// </summary>
    [EnumMember(Value = "NALC")]
    [IsoId("_ViiZh9p-Ed-ak6NoX_4Aeg_-640386732")]
    [Description(@"Instructing party is not allowed to request a cancellation.")]
    NotAllowedToCancel = RejectedStatusReasonCode.NotAllowedToCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_ViiZiNp-Ed-ak6NoX_4Aeg_-640386347")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legally impossible to cancel.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_VirjcNp-Ed-ak6NoX_4Aeg_-640386174")]
    [Description(@"Legally impossible to cancel.")]
    LegallyImpossible = RejectedStatusReasonCode.LegallyImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another reason for the status rejected.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Virjcdp-Ed-ak6NoX_4Aeg_277257123")]
    [Description(@"Another reason for the status rejected.")]
    Other = RejectedStatusReasonCode.Other, // same ordinal as derivation source for type conversions
}
