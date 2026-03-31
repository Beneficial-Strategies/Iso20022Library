// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC (The Depository Trust Company) system status code of instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kWpW4JIWEeaNbfbSYshZYw")]
[Description(@"DTC (The Depository Trust Company) system status code of instruction.")]
[DerivedFrom(typeof(DTCInstructionStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCInstructionStatus2Code>))]
#endif
public enum DTCInstructionStatus2Code
{
    /// <summary>
    /// Instruction cancelled by client relating to survivor option event.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_q2UwEZIWEeaNbfbSYshZYw")]
    [Description(@"Instruction cancelled by client relating to survivor option event.")]
    Cancel = DTCInstructionStatusCode.Cancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation of conversion instruction upon agent approval only.
    /// Encoded/decoded by serializers as &quot;CCAN&quot;.
    /// </summary>
    [EnumMember(Value = "CCAN")]
    [IsoId("_rNiWMZIWEeaNbfbSYshZYw")]
    [Description(@"Cancellation of conversion instruction upon agent approval only.")]
    ConversionCancellation = DTCInstructionStatusCode.ConversionCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction dropped due to insufficient position.
    /// Encoded/decoded by serializers as &quot;DROP&quot;.
    /// </summary>
    [EnumMember(Value = "DROP")]
    [IsoId("_rYZiYZIWEeaNbfbSYshZYw")]
    [Description(@"Instruction dropped due to insufficient position.")]
    Dropped = DTCInstructionStatusCode.Dropped, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fully processed instruction.
    /// Encoded/decoded by serializers as &quot;MADE&quot;.
    /// </summary>
    [EnumMember(Value = "MADE")]
    [IsoId("_r82TQZIWEeaNbfbSYshZYw")]
    [Description(@"Fully processed instruction.")]
    Made = DTCInstructionStatusCode.Made, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction for CD early redemption awaiting paperwork. Instruction will become MADE when DTC releases instruction upon paperwork.
    /// Encoded/decoded by serializers as &quot;PDOC&quot;.
    /// </summary>
    [EnumMember(Value = "PDOC")]
    [IsoId("_tCnogZIWEeaNbfbSYshZYw")]
    [Description(
        @"Instruction for CD early redemption awaiting paperwork. Instruction will become MADE when DTC releases instruction upon paperwork."
    )]
    PendingDocumentation = DTCInstructionStatusCode.PendingDocumentation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction pending release or delete from approval function.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_tHh9sZIWEeaNbfbSYshZYw")]
    [Description(@"Instruction pending release or delete from approval function.")]
    PendingApproval = DTCInstructionStatusCode.PendingApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction waiting for update after submission.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_tNVDsZIWEeaNbfbSYshZYw")]
    [Description(@"Instruction waiting for update after submission.")]
    Pending = DTCInstructionStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction or withdrawal rejected by agent relating to survivor option event.
    /// Encoded/decoded by serializers as &quot;REJA&quot;.
    /// </summary>
    [EnumMember(Value = "REJA")]
    [IsoId("_ua_wsZIWEeaNbfbSYshZYw")]
    [Description(@"Instruction or withdrawal rejected by agent relating to survivor option event.")]
    RejectedByAgent = DTCInstructionStatusCode.RejectedByAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction did not pass initial validation.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_vAx-UZIWEeaNbfbSYshZYw")]
    [Description(@"Instruction did not pass initial validation.")]
    Reject = DTCInstructionStatusCode.Reject, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Previously recycled transactions have been “MADE” and the system is processing the updates.
    /// Encoded/decoded by serializers as &quot;REMD&quot;.
    /// </summary>
    [EnumMember(Value = "REMD")]
    [IsoId("_vsX5AZIWEeaNbfbSYshZYw")]
    [Description(
        @"Previously recycled transactions have been “MADE” and the system is processing the updates."
    )]
    RecycleMade = DTCInstructionStatusCode.RecycleMade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rescinded by Issuer.
    /// Encoded/decoded by serializers as &quot;RESC&quot;.
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_xL5LAZIWEeaNbfbSYshZYw")]
    [Description(@"Rescinded by Issuer.")]
    Rescinded = DTCInstructionStatusCode.Rescinded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction moved from one client account to another for put events.
    /// Encoded/decoded by serializers as &quot;SWUN&quot;.
    /// </summary>
    [EnumMember(Value = "SWUN")]
    [IsoId("_xzwcQZIWEeaNbfbSYshZYw")]
    [Description(@"Instruction moved from one client account to another for put events.")]
    Swung = DTCInstructionStatusCode.Swung, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client instruction withdrawn for events with withdrawal privilege.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_yOPY0ZIWEeaNbfbSYshZYw")]
    [Description(@"Client instruction withdrawn for events with withdrawal privilege.")]
    Withdrawn = DTCInstructionStatusCode.Withdrawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction waiting for position. Instruction will subsequently either become “Made” or “Dropped” by end of day.
    /// Encoded/decoded by serializers as &quot;RECY&quot;.
    /// </summary>
    [EnumMember(Value = "RECY")]
    [IsoId("_zz2rwZIWEeaNbfbSYshZYw")]
    [Description(
        @"Instruction waiting for position. Instruction will subsequently either become “Made” or “Dropped” by end of day."
    )]
    Recycle = DTCInstructionStatusCode.Recycle, // same ordinal as derivation source for type conversions
}
