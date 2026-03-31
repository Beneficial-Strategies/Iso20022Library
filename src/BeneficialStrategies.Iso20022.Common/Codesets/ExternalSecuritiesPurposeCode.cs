// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external securities purpose code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5eZzoPomEe2ClqPWkEN24A")]
[Description(
    @"Specifies the external securities purpose code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalSecuritiesPurpose1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalSecuritiesPurposeCode>))]
#endif
public enum ExternalSecuritiesPurposeCode
{
    /// <summary>
    /// Relates to collateral management.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_5eZzrPomEe2ClqPWkEN24A")]
    [Description(@"Relates to collateral management.")]
    CollateralManagement,

    /// <summary>
    /// Relates to securities lending.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_5eZztPomEe2ClqPWkEN24A")]
    [Description(@"Relates to securities lending.")]
    SecuritiesLending,

    /// <summary>
    /// Relates to settlements.
    /// Encoded/decoded by serializers as &quot;STMT&quot;.
    /// </summary>
    [EnumMember(Value = "STMT")]
    [IsoId("_5eZzqfomEe2ClqPWkEN24A")]
    [Description(@"Relates to settlements.")]
    Settlements,
}
