// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an awaiting cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Ti0dojEeC60axPepSq7g_-1322175613")]
[Description(@"Specifies the reason why the instruction has an awaiting cancellation status.")]
[DerivedFrom(typeof(AwaitingCancellationReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AwaitingCancellationReason1Code>))]
#endif
public enum AwaitingCancellationReason1Code
{
    /// <summary>
    /// Cancellation has not been received yet.
    /// Encoded/decoded by serializers as &quot;WCAN&quot;.
    /// </summary>
    [EnumMember(Value = "WCAN")]
    [IsoId("__0Ti0tojEeC60axPepSq7g_323091822")]
    [Description(@"Cancellation has not been received yet.")]
    AwaitingCancellation = AwaitingCancellationReasonCode.AwaitingCancellation, // same ordinal as derivation source for type conversions
}
