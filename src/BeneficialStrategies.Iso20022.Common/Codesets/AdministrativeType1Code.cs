// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the administrative type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3BW3kDNKEeylu6lH-gut-A")]
[Description(@"Code that specifies the administrative type.")]
[DerivedFrom(typeof(AdministrativeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AdministrativeType1Code>))]
#endif
public enum AdministrativeType1Code
{
    /// <summary>
    /// Other administrative type defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_6oeIMTNKEeylu6lH-gut-A")]
    [Description(@"Other administrative type defined at national level.")]
    OtherNational = AdministrativeTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other administrative type defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6tdV4TNKEeylu6lH-gut-A")]
    [Description(@"Other administrative type defined at private level.")]
    OtherPrivate = AdministrativeTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Text message.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_6zMxgTNKEeylu6lH-gut-A")]
    [Description(@"Text message.")]
    TextMessage = AdministrativeTypeCode.TextMessage, // same ordinal as derivation source for type conversions
}
