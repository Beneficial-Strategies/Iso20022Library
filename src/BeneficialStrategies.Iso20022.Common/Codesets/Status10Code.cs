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
[IsoId("_CqMBAKktEeynsLtPxJMJTQ")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusV2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<Status10Code>))]
public enum Status10Code
{
    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_kBGIQSm6EfGfZ9PfK70MMg")]
    [Description(@"Processing has been completed.")]
    Completed = StatusV2Code.Completed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing has been partially completed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_kBGIRym6EfGfZ9PfK70MMg")]
    [Description(@"Processing has been partially completed.")]
    PartiallyCompleted = StatusV2Code.PartiallyCompleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is queued.
    /// Encoded/decoded by serializers as &quot;QUED&quot;.
    /// </summary>
    [EnumMember(Value = "QUED")]
    [IsoId("_kBGIQym6EfGfZ9PfK70MMg")]
    [Description(@"Instruction is queued.")]
    Queued = StatusV2Code.Queued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_kBGIRSm6EfGfZ9PfK70MMg")]
    [Description(@"Instruction has been rejected.")]
    Rejected = StatusV2Code.Rejected, // same ordinal as derivation source for type conversions
}
