// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the corporate action options available to the account owner.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bMfEktp-Ed-ak6NoX_4Aeg_73217179")]
[Description(@"Specifies the corporate action options available to the account owner.")]
[DerivedFrom(typeof(CorporateActionOptionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionOption5Code>))]
#endif
public enum CorporateActionOption5Code
{
    /// <summary>
    /// Option to choose cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_bMfEk9p-Ed-ak6NoX_4Aeg_160952572")]
    [Description(@"Option to choose cash.")]
    Cash = CorporateActionOptionCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_bMfElNp-Ed-ak6NoX_4Aeg_720605213")]
    [Description(@"Distribution of securities to holders.")]
    Security = CorporateActionOptionCode.Security, // same ordinal as derivation source for type conversions
}
