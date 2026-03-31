// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-BCUoCz2EeOsiuMH68so7Q")]
[Description(@"Specifies additional information about the processed instruction.")]
[DerivedFrom(typeof(AcknowledgementReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AcknowledgementReason8Code>))]
#endif
public enum AcknowledgementReason8Code
{
    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__j-uESz2EeOsiuMH68so7Q")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason = AcknowledgementReasonCode.NarrativeReason, // same ordinal as derivation source for type conversions
}
