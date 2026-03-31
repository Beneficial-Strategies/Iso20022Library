// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the pay creditor by cheque instruction code for the cross-element validation rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y50Ksh-1EeuxStysDTgLiw")]
[Description(
    @"Specifies the pay creditor by cheque instruction code for the cross-element validation rules."
)]
[DerivedFrom(typeof(ValidationRuleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ValidationRulePayCreditorByCheque1Code>))]
#endif
public enum ValidationRulePayCreditorByCheque1Code
{
    /// <summary>
    /// Pay creditor by cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_XJzf0SAcEeuxStysDTgLiw")]
    [Description(@"Pay creditor by cheque.")]
    PayCreditorByCheque = ValidationRuleCode.PayCreditorByCheque, // same ordinal as derivation source for type conversions
}
