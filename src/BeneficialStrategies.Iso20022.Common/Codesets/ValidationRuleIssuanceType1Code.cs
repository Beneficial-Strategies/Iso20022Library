// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the instruction for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rW7kBCBqEeugLNJneiyzbA")]
[Description(
    @"Specifies the instruction for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets."
)]
[DerivedFrom(typeof(ValidationRuleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ValidationRuleIssuanceType1Code>))]
#endif
public enum ValidationRuleIssuanceType1Code
{
    /// <summary>
    /// Undertaking issued direct.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ykFHMSBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued direct.")]
    UndertakingIssuedDirect = ValidationRuleCode.UndertakingIssuedDirect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking issued via confirming party.
    /// Encoded/decoded by serializers as &quot;ISCO&quot;.
    /// </summary>
    [EnumMember(Value = "ISCO")]
    [IsoId("_yxUR8SBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued via confirming party.")]
    UndertakingIssuedViaConfirmingParty = ValidationRuleCode.UndertakingIssuedViaConfirmingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking issued via advising party.
    /// Encoded/decoded by serializers as &quot;ISAD&quot;.
    /// </summary>
    [EnumMember(Value = "ISAD")]
    [IsoId("_y3r_sSBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued via advising party.")]
    UndertakingViaAdvisingParty = ValidationRuleCode.UndertakingViaAdvisingParty, // same ordinal as derivation source for type conversions
}
