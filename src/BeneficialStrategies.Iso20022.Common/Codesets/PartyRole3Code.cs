// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the party in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xqjtwPRCEeqAradXpAelDQ")]
[Description(@"Specifies the role of the party in the transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyRole3Code>))]
#endif
public enum PartyRole3Code
{
    /// <summary>
    /// Legal entity, other than the issuer, who gives a guarantee. The guarantor becomes liable in case of default.
    /// Encoded/decoded by serializers as &quot;GATR&quot;.
    /// </summary>
    [EnumMember(Value = "GATR")]
    [IsoId("_0BtyYfRCEeqAradXpAelDQ")]
    [Description(
        @"Legal entity, other than the issuer, who gives a guarantee. The guarantor becomes liable in case of default."
    )]
    Guarantor = PartyRoleCode.Guarantor, // same ordinal as derivation source for type conversions
}
