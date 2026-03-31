// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the received status for the cross-element validation rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1VeIch-0EeuxStysDTgLiw")]
[Description(@"Specifies the received status for the cross-element validation rules.")]
[DerivedFrom(typeof(ValidationRuleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ValidationRuleReceived1Code>))]
#endif
public enum ValidationRuleReceived1Code
{
    /// <summary>
    /// Received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_Eth3kR-1EeuxStysDTgLiw")]
    [Description(@"Received.")]
    Received = ValidationRuleCode.Received, // same ordinal as derivation source for type conversions
}
