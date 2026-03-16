// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZfG8w9p-Ed-ak6NoX_4Aeg_-881860142")]
[Description(@"Specifies the reason for a rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
public enum RejectedStatusReason8Code
{
    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_ZfG8xNp-Ed-ak6NoX_4Aeg_-881859781")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime = RejectedStatusReasonCode.CutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructing party is not allowed to request a cancellation.
    /// Encoded/decoded by serializers as &quot;NALC&quot;.
    /// </summary>
    [EnumMember(Value = "NALC")]
    [IsoId("_ZfG8xdp-Ed-ak6NoX_4Aeg_-881859756")]
    [Description(@"Instructing party is not allowed to request a cancellation.")]
    NotAllowedToCancel = RejectedStatusReasonCode.NotAllowedToCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_ZfG8xtp-Ed-ak6NoX_4Aeg_-881859686")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legally impossible to cancel.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_ZfG8x9p-Ed-ak6NoX_4Aeg_-881859644")]
    [Description(@"Legally impossible to cancel.")]
    LegallyImpossible = RejectedStatusReasonCode.LegallyImpossible, // same ordinal as derivation source for type conversions
}
