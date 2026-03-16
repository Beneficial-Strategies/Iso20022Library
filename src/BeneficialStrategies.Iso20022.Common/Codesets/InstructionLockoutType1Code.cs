// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specify the type of blocking when instructions are temporarily blocked for an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXPTYA7xEeuZI5Sr_GAcuA")]
[Description(
    @"Specify the type of blocking when instructions are temporarily blocked for an event."
)]
[DerivedFrom(typeof(InstructionLockoutTypeCode))]
public enum InstructionLockoutType1Code
{
    /// <summary>
    /// Event is locked out manually for instruction processing.  This relates to conversions, warrants and put events.
    /// Encoded/decoded by serializers as &quot;MANL&quot;.
    /// </summary>
    [EnumMember(Value = "MANL")]
    [IsoId("_g5Rl4Q7xEeuZI5Sr_GAcuA")]
    [Description(
        @"Event is locked out manually for instruction processing.  This relates to conversions, warrants and put events."
    )]
    ManualLocked = InstructionLockoutTypeCode.ManualLocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is not locked out manually for instruction processing. This relates to conversions, warrants and put events.
    /// Encoded/decoded by serializers as &quot;NOTL&quot;.
    /// </summary>
    [EnumMember(Value = "NOTL")]
    [IsoId("_g_SuUQ7xEeuZI5Sr_GAcuA")]
    [Description(
        @"Event is not locked out manually for instruction processing. This relates to conversions, warrants and put events."
    )]
    NotLocked = InstructionLockoutTypeCode.NotLocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is locked out systemically for instruction processing. This relates to conversion or warrant events due to an &quot;out of town&quot; record date on the disbursed security.
    /// Encoded/decoded by serializers as &quot;SYSL&quot;.
    /// </summary>
    [EnumMember(Value = "SYSL")]
    [IsoId("_hELOUQ7xEeuZI5Sr_GAcuA")]
    [Description(
        @"Event is locked out systemically for instruction processing. This relates to conversion or warrant events due to an ""out of town"" record date on the disbursed security."
    )]
    SystemicLocked = InstructionLockoutTypeCode.SystemicLocked, // same ordinal as derivation source for type conversions
}
