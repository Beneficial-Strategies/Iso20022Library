// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the narrative reason code for the cross-element validation rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_067hgh-0EeuxStysDTgLiw")]
[Description(@"Specifies the narrative reason code for the cross-element validation rules.")]
[DerivedFrom(typeof(ValidationRuleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ValidationRuleNarrative1Code>))]
#endif
public enum ValidationRuleNarrative1Code
{
    /// <summary>
    /// Narrative.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_MEQ0kR-1EeuxStysDTgLiw")]
    [Description(@"Narrative.")]
    Narrative = ValidationRuleCode.Narrative, // same ordinal as derivation source for type conversions
}
