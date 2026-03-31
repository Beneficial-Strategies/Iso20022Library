// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kpnylO5NEeCisYr99QEiWA_-1778832606")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Status6Code>))]
#endif
public enum Status6Code
{
    /// <summary>
    /// Instruction has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_kpxjkO5NEeCisYr99QEiWA_-61748503")]
    [Description(@"Instruction has been rejected.")]
    Rejected = StatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_kpxjke5NEeCisYr99QEiWA_203121317")]
    [Description(@"Processing has been completed.")]
    Completed = StatusCode.Completed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is queued.
    /// Encoded/decoded by serializers as &quot;QUED&quot;.
    /// </summary>
    [EnumMember(Value = "QUED")]
    [IsoId("_kpxjku5NEeCisYr99QEiWA_-1861474063")]
    [Description(@"Instruction is queued.")]
    Queued = StatusCode.Queued, // same ordinal as derivation source for type conversions
}
