// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specify the type of blocking when instructions are temporarily blocked for an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-EhqAA7vEeuZI5Sr_GAcuA")]
[Description(
    @"Specify the type of blocking when instructions are temporarily blocked for an event."
)]
[Derivations(typeof(InstructionLockoutType1Code))]
public enum InstructionLockoutTypeCode
{
    /// <summary>
    /// Event is locked out systemically for instruction processing. This relates to conversion or warrant events due to an &quot;out of town&quot; record date on the disbursed security.
    /// Encoded/decoded by serializers as &quot;SYSL&quot;.
    /// </summary>
    [EnumMember(Value = "SYSL")]
    [IsoId("_1hQL8A7wEeuZI5Sr_GAcuA")]
    [Description(
        @"Event is locked out systemically for instruction processing. This relates to conversion or warrant events due to an ""out of town"" record date on the disbursed security."
    )]
    SystemicLocked,

    /// <summary>
    /// Event is locked out manually for instruction processing.  This relates to conversions, warrants and put events.
    /// Encoded/decoded by serializers as &quot;MANL&quot;.
    /// </summary>
    [EnumMember(Value = "MANL")]
    [IsoId("_EKGEoA7xEeuZI5Sr_GAcuA")]
    [Description(
        @"Event is locked out manually for instruction processing.  This relates to conversions, warrants and put events."
    )]
    ManualLocked,

    /// <summary>
    /// Event is not locked out manually for instruction processing. This relates to conversions, warrants and put events.
    /// Encoded/decoded by serializers as &quot;NOTL&quot;.
    /// </summary>
    [EnumMember(Value = "NOTL")]
    [IsoId("_KYW9sA7xEeuZI5Sr_GAcuA")]
    [Description(
        @"Event is not locked out manually for instruction processing. This relates to conversions, warrants and put events."
    )]
    NotLocked,
}
