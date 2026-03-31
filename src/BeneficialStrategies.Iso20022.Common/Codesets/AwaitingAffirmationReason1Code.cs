// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an awaiting affirmation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Jx09ojEeC60axPepSq7g_-961152106")]
[Description(@"Specifies the reason why the instruction has an awaiting affirmation status.")]
[DerivedFrom(typeof(AwaitingAffirmationReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AwaitingAffirmationReason1Code>))]
#endif
public enum AwaitingAffirmationReason1Code
{
    /// <summary>
    /// Affirmation has not been received yet.
    /// Encoded/decoded by serializers as &quot;WAFF&quot;.
    /// </summary>
    [EnumMember(Value = "WAFF")]
    [IsoId("__0Jx1NojEeC60axPepSq7g_684115329")]
    [Description(@"Affirmation has not been received yet.")]
    AwaitingAffirmation = AwaitingAffirmationReasonCode.AwaitingAffirmation, // same ordinal as derivation source for type conversions
}
