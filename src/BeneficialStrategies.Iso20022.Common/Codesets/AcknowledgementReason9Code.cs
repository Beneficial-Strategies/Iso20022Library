// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about a processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WLJIwekIEemm4qhb2yFPOw")]
[Description(@"Specifies additional information about a processed instruction.")]
[DerivedFrom(typeof(AcknowledgementReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AcknowledgementReason9Code>))]
#endif
public enum AcknowledgementReason9Code
{
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_dJBg4ekIEemm4qhb2yFPOw")]
    [Description(@"Other. See Narrative.")]
    Other = AcknowledgementReasonCode.Other, // same ordinal as derivation source for type conversions
}
